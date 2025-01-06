
# Gerekli kütüphanelerin içeri aktarılması

from flask import Flask, request, jsonify
import cv2
import easyocr
import re
from inference_sdk import InferenceHTTPClient
import os
from waitress import serve


# Servis uygulamasının oluşturulması
app = Flask(__name__)

# Yapay zeka API'siyle bağlantı kurma
CLIENT = InferenceHTTPClient(
    api_url="https://detect.roboflow.com",
    api_key="Y184tITXDGPGho1AGSwj"
)

# Plakayı okumak için gerekli olan nesnenin tanımlanması
reader = easyocr.Reader(['en'])  # Türkçe karakterler olmadığı için İngilizce olarak yükleniyor

@app.route('/process_image', methods=['POST'])
def process_image():
    # Görüntü dosyasının sağlanıp sağlanmadığını kontrol et
    if 'file' not in request.files:
        return jsonify({'error': 'Hiçbir dosya sağlanmadı'}), 400

    file = request.files['file']

    # Dosyanın bir görüntü olup olmadığını kontrol et
    if file and file.filename.lower().endswith(('png', 'jpg', 'jpeg')):
        # Dosyayı geçici olarak kaydet
        image_path = os.path.join('temp', file.filename)
        os.makedirs(os.path.dirname(image_path), exist_ok=True)
        file.save(image_path)

        # Görüntüyü işle
        try:
            # Yüklenen görüntü üzerinde Roboflow ile çıkarım yap
            result = CLIENT.infer(image_path, model_id="platedetect-y7boq/1")

            # Orijinal görüntüyü yükle
            image = cv2.imread(image_path)
            if image is None:
                raise FileNotFoundError(f"Görüntü '{image_path}' yüklenemedi.")

            formatted_texts = []

            if "predictions" in result:
                for prediction in result["predictions"]:
                    x, y, width, height = prediction["x"], prediction["y"], prediction["width"], prediction["height"]

                    # Çerçeve koordinatlarını hesapla
                    left = int(x - width / 2)
                    top = int(y - height / 2)
                    right = int(x + width / 2)
                    bottom = int(y + height / 2)

                    # İlgi alanını (ROI) çıkar
                    roi = image[top:bottom, left:right]

                    # OCR performansı için ROI'yi gri tonlamaya dönüştür
                    gray_roi = cv2.cvtColor(roi, cv2.COLOR_BGR2GRAY)

                    # EasyOCR kullanarak ROI üzerinde OCR işlemi yap
                    result_text = reader.readtext(gray_roi)
                    text = " ".join([item[1] for item in result_text])

                    # Metni büyük harfe dönüştür ve boşlukları kaldır
                    formatted_text = text.replace(" ", "").upper()

                    # Metin başında "TR" varsa kaldır
                    if formatted_text.startswith("TR"):
                        formatted_text = formatted_text[2:]

                    # Özel kuralları uygula: Sayılar arasında harflere izin ver, ancak sayılardan sonra harf olmasın
                    formatted_text = re.sub(r'^[A-Z]+|[A-Z]+$', '', formatted_text)

                    # Formatlanmış metni listeye ekle
                    formatted_texts.append(formatted_text.strip())

                # Formatlanmış metin(ler)i yanıt olarak döndür
                return jsonify({
                    'formatted_texts': formatted_texts
                })
            else:
                return jsonify({'error': 'Hiçbir tahmin bulunamadı'}), 400
        except Exception as e:
            return jsonify({'error': str(e)}), 500
    else:
        return jsonify({'error': 'Geçersiz dosya türü. Lütfen geçerli bir görüntü yükleyin.'}), 400


if __name__ == '__main__':
    serve(app, host='0.0.0.0', port=8021)
