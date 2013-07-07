using System.Collections.Generic;

namespace HumanApiDotNet.DataModel
{
    public class Activity
    {
        public string date { get; set; }
        public int light { get; set; }
        public int moderate { get; set; }
        public int vigorous { get; set; }
        public int steps { get; set; }
        public string unit { get; set; }
        public List<Series> series { get; set; }
    }
}