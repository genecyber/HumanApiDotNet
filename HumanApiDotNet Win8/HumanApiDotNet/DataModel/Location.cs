namespace HumanApiDotNet.DataModel
{
    public class PlaceLocation
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }

    public class Place
    {
        public PlaceLocation location { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Location
    {
        public string endTime { get; set; }
        public string startTime { get; set; }
        public string type { get; set; }
        public Place place { get; set; }
    }
}
