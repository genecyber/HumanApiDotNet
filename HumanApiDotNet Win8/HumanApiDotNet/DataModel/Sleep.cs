using System;

namespace HumanApiDotNet.DataModel
{
    public class Sleep
    {
        public int id { get; set; }
        public int userId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int timeAsleep { get; set; }
        public int timeAwake { get; set; }
    }
}