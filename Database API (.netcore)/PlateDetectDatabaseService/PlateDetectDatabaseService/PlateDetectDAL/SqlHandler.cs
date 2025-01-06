using System.Data;
using System.Data.SqlClient;
using PlateDetectionV1.model;
using Microsoft.Extensions.Configuration;

namespace PlateDetectDatabaseService.PlateDetectDAL
{
    public class SqlHandler
    {
        private readonly IConfiguration _configuration;
        private readonly string _conString;

        public SqlHandler(IConfiguration configuration)
        {
            _configuration = configuration;
            _conString = _configuration.GetConnectionString("DefaultConnection");
        }

        public void AddPlateInfo(PlateInfo plateInfo)
        {
            using (SqlConnection con = new SqlConnection(_conString))
            {
                string cmdString = "INSERT INTO PlateInfo(PlateId, Plate, OwnerName, OwnerSurname, RegisterDate) VALUES(@PlateId, @Plate, @OwnerName, @OwnerSurname, @RegisterDate)";

                using (SqlCommand cmd = new SqlCommand(cmdString, con))
                {
                    CreatePlateInfoParams(cmd,plateInfo);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void CreatePlateInfoParams(SqlCommand cmd,PlateInfo plateInfo)
        {
            cmd.Parameters.AddWithValue("@PlateId", plateInfo.PlateId);
            cmd.Parameters.AddWithValue("@Plate", plateInfo.Plate);
            cmd.Parameters.AddWithValue("@OwnerName", plateInfo.OwnerName);
            cmd.Parameters.AddWithValue("@OwnerSurname", plateInfo.OwnerSurname);
            cmd.Parameters.AddWithValue("@RegisterDate", plateInfo.RegisterDate);
        }

        public List<PlateInfo> getPlates()
        {
            var plateList = new List<PlateInfo>();

            using (SqlConnection con = new SqlConnection(_conString))
            {
                string cmdString = "SELECT PlateId, Plate, OwnerName, OwnerSurname, RegisterDate FROM PlateInfo";

                using (SqlCommand cmd = new SqlCommand(cmdString, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            plateList.Add(new PlateInfo
                            {
                                PlateId = reader.GetInt32(0),
                                Plate = reader.GetString(1),
                                OwnerName = reader.GetString(2),
                                OwnerSurname = reader.GetString(3),
                                RegisterDate = reader.GetDateTime(4)
                            });
                        }
                    }
                }
            }

            return plateList;
        }
    }
}
