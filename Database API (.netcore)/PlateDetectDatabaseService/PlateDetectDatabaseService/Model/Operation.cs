using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateDetectionV1.model
{
    public class Operation
    {
        public int OperationId { get; set; }

        public int PlateId { get; set; }
        public string OperationCategory { get; set; }
        public DateTime OperationDate { get; set; }
    }
}
