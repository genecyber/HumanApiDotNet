using System;

namespace HumanApiDotNet.DataModel
{
    public class BloodPressure
    {
        public int id { get; set; }
        public DateTime timestamp { get; set; }
        public BloodPressureValue value { get; set; }
        public string unit { get; set; }
    }
}