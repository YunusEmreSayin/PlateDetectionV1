
FROM python:3.12-slim

# Çalışma dizinini ayarla
WORKDIR /app

# Sistem bağımlılıklarını yükle
RUN apt-get update && apt-get install -y \
    libgl1-mesa-glx \
    libglib2.0-0 \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/*

# Gereksinim dosyasını kopyala ve bağımlılıkları yükle
COPY back/requirements.txt .

RUN pip install --no-cache-dir -r requirements.txt

# Uygulama kodlarını kopyala
COPY . .

# Çalıştırma komutunu tanımla
CMD ["python", "app.py"]