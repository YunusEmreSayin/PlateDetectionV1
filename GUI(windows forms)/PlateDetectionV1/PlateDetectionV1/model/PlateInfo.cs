using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateDetectionV1.model
{
    public class PlateInfo
    {
        public int PlateId { get; set; }
        public string Plate { get; set; }
        public string OwnerName { get; set; }
        public string OwnerSurname { get; set; }
        public DateTime RegisterDate { get; set; }


    }
}
