using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData.WebApi.Models
{
    public class TestDataL1Model
    {
        public int TestDataId { get; set; }
        public string SerialNumber { get; set; }
        public string CustomerSerialNumber { get; set; }
        public int WaferId { get; set; }
        public string BatchNumber { get; set; }
        public string PartNumber { get; set; }
    }
}
