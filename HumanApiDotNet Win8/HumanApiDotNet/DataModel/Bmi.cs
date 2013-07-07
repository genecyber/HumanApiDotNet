using System;

namespace HumanApiDotNet.DataModel
{
    public class Bmi
    {
        public int id { get; set; }
        public int userId { get; set; }
        public DateTime timestamp { get; set; }
        public decimal value { get; set; }
        public string unit { get; set; }
    }
}