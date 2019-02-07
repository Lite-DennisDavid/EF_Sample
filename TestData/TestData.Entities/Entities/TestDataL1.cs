using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData.Entities
{
    public class TestDataL1
    {
        [Key]
        public int TestDataId { get; set; }
        public string SerialNumber { get; set; }
        public string CustomerSerialNumber { get; set; }
        public string BatchNumber { get; set; }
        public string PartNumber { get; set; }
        public MeasurementParameter TestMeas { get; set; }
    }
}
