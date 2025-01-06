using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PlateDetectionV1.model;

namespace PlateDetectDatabaseService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlateDetectMainController : Controller
    {
        public readonly IConfiguration _configuration;
        public PlateDetectMainController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("getPlates")]
        public ActionResult<PlateInfo> GetPlates()
        {
            
            // Plakaların ekleneceği liste oluşturuluyor
            List<PlateInfo> list = new List<PlateInfo>();

            // Hata Yönetimi try / catch bloğu
            try
            {
                Console.WriteLine("Girdi 1");
                // Bağlantı için appsetting.json dosyasından connection string alma ve bağlantı oluşturma
                string conString = _configuration.GetConnectionString("DefaultConnection");
                Console.WriteLine(conString);

                SqlConnection con = new SqlConnection(conString);
                Console.WriteLine("Girdi 2");

                // Gerçekleştiriliecek sql query'si girilir ve komut olarak atanır
                string cmdString = "SELECT * FROM tblPlate";
                SqlCommand cmd = new SqlCommand(cmdString, con);

                // bağlantı açılır
                con.Open();

                // komut üzerinden veri okuyucu oluşturulur ve okuma yapıldığı sürece döngüde kalır
                var dr = cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    Console.WriteLine("Girdi 3 okuyor");

                    // Datareader daki veriler plaka'ya atanır

                    PlateInfo plate = new PlateInfo();
                    plate.PlateId = (int)dr["PlateId"];
                    plate.Plate = dr["Plate"].ToString();
                    plate.RegisterDate = (DateTime) dr["RegisterDate"];
                    plate.OwnerName = dr["OwnerName"].ToString();
                    plate.OwnerSurname = dr["OwnerSurname"].ToString();

                    //plaka listeye eklenir
                    list.Add(plate);
                }

                // işi biten elemanlar kapatılır
                dr.Close();
                con.Close();

                // liste sonuç olarak dönülür.
                return Ok(list);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        [Route("getPlateByID")]
        public ActionResult<PlateInfo> getPlateByID(string userPlate)
        {

            // Plakaların ekleneceği liste oluşturuluyor
            List<PlateInfo> list = new List<PlateInfo>();

            // Hata Yönetimi try / catch bloğu
            try
            {
                Console.WriteLine("Girdi 1");
                // Bağlantı için appsetting.json dosyasından connection string alma ve bağlantı oluşturma
                string conString = _configuration.GetConnectionString("DefaultConnection");
                Console.WriteLine(conString);

                SqlConnection con = new SqlConnection(conString);
                Console.WriteLine("Girdi 2");

                // Gerçekleştiriliecek sql query'si girilir ve komut olarak atanır
                string cmdString = "SELECT * FROM tblPlate WHERE Plate=@plate";
                SqlCommand cmd = new SqlCommand(cmdString, con);
                cmd.Parameters.AddWithValue("@plate", userPlate);

                // bağlantı açılır
                con.Open();

                // komut üzerinden veri okuyucu oluşturulur ve okuma yapıldığı sürece döngüde kalır
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Girdi 3 okuyor");

                    // Datareader daki veriler plaka'ya atanır

                    PlateInfo plate = new PlateInfo();
                    plate.PlateId = (int)dr["PlateId"];
                    plate.Plate = dr["Plate"].ToString();
                    plate.RegisterDate = (DateTime)dr["RegisterDate"];
                    plate.OwnerName = dr["OwnerName"].ToString();
                    plate.OwnerSurname = dr["OwnerSurname"].ToString();

                    //plaka listeye eklenir
                    list.Add(plate);
                }

                // işi biten elemanlar kapatılır
                dr.Close();
                con.Close();

                // liste sonuç olarak dönülür.
                return Ok(list);
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost]
        [Route("getOperations")]
        public ActionResult<List<Operation>> GetOperations([FromBody] PlateInfo plate)
        {
            // Operasyonların ekleneceği liste oluşturuluyor
            List<Operation> operations = new List<Operation>();

            // Hata Yönetimi try / catch bloğu
            try
            {
                // appsettings.json dosyasından connection string alma ve bağlantı oluşturma
                string conString = _configuration.GetConnectionString("DefaultConnection");
                using (SqlConnection con = new SqlConnection(conString))
                {
                    // SQL sorgusu hazırlanıyor
                    string cmdString = "SELECT OperationId, PlateId, OperationCategory, OperationDate FROM tblOperation WHERE PlateId = @PlateId";
                    using (SqlCommand cmd = new SqlCommand(cmdString, con))
                    {
                        // Plate sınıfından plateId alınıyor
                        cmd.Parameters.AddWithValue("@PlateId", plate.PlateId);

                        // Bağlantı açılıyor
                        con.Open();

                        // Veri okuyucu oluşturuluyor
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                // DataReader'daki veriler Operation nesnesine atanıyor
                                Operation operation = new Operation
                                {
                                    OperationId = Convert.ToInt32(dr["OperationId"]),
                                    PlateId = Convert.ToInt32(dr["PlateId"]),
                                    OperationCategory = dr["OperationCategory"].ToString(),
                                    OperationDate = Convert.ToDateTime(dr["OperationDate"])
                                };

                                // Operasyon listeye ekleniyor
                                operations.Add(operation);
                            }
                        }
                    }
                }

                // Liste JSON formatında sonuç olarak dönülüyor
                return Ok(operations);
            }
            catch (Exception ex)
            {
                // Hata mesajı loglanabilir veya özelleştirilebilir
                return StatusCode(500, new { message = "Bir hata oluştu.", error = ex.Message });
            }
        }

        [HttpPost]
        [Route("insertplateinfo")]
        public IActionResult InsertPlateInfo([FromBody]PlateInfo plateInfo)
        {
            try
            {
                // SQL bağlantısı oluşturuluyor
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    // SQL sorgusu hazırlanıyor
                    string cmdString = "INSERT INTO tblPlate(Plate, OwnerName, OwnerSurname, RegisterDate) VALUES(@Plate, @OwnerName, @OwnerSurname, @RegisterDate)";
                    using (SqlCommand cmd = new SqlCommand(cmdString, con))
                    {
                        // Parametreler atanıyor
                        cmd.Parameters.AddWithValue("@Plate", plateInfo.Plate);
                        cmd.Parameters.AddWithValue("@OwnerName", plateInfo.OwnerName);
                        cmd.Parameters.AddWithValue("@OwnerSurname", plateInfo.OwnerSurname);
                        cmd.Parameters.AddWithValue("@RegisterDate", plateInfo.RegisterDate);

                        // Bağlantı açılıyor ve sorgu çalıştırılıyor
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return Ok(new { message = "PlateInfo başarıyla eklendi." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "PlateInfo eklenirken bir hata oluştu.", error = ex.Message });
            }
        }

        [HttpPost]
        [Route("insertoperation")]
        public IActionResult InsertOperation([FromBody] Operation operation)
        {
            try
            {
                // SQL bağlantısı oluşturuluyor
                using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    // SQL sorgusu hazırlanıyor
                    string cmdString = "INSERT INTO tblOperation(PlateId, OperationCategory, OperationDate) VALUES(@PlateId, @OperationCategory, @OperationDate)";
                    using (SqlCommand cmd = new SqlCommand(cmdString, con))
                    {
                        // Parametreler atanıyor
                        cmd.Parameters.AddWithValue("@PlateId", operation.PlateId);
                        cmd.Parameters.AddWithValue("@OperationCategory", operation.OperationCategory);
                        cmd.Parameters.AddWithValue("@OperationDate", operation.OperationDate);

                        // Bağlantı açılıyor ve sorgu çalıştırılıyor
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return Ok(new { message = "Operation başarıyla eklendi." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Operation eklenirken bir hata oluştu.", error = ex.Message });
            }
        }

    }
}   
