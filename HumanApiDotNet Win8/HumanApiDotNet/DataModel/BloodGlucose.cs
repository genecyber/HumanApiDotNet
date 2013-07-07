using System;

namespace HumanApiDotNet.DataModel
{
    public class BloodGlucose
    {
        public int id { get; set; }
        public DateTime timestamp { get; set; }
        public int value { get; set; }
        public string unit { get; set; }
        public int userId { get; set; }
    }
}