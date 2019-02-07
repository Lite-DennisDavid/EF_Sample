using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestData.Entities
{
    public class MeasurementParameter
    {
        public int MeasurementParameterId { get; set; }
        public string Name { get; set; }

        public string Source { get; set; }
        public string Units { get; set; }

        public string Pass { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
    }
}
