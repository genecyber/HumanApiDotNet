namespace HumanApiDotNet.DataModel
{
    public class Profile
    {
        public Profile(){}

        public string userId { get; set; }
        public string email { get; set; }
        public string createdAt { get; set; }
        public DefaultTimeZone defaultTimeZone { get; set; }
    }
    public class DefaultTimeZone
    {
        public string id { get; set; }
        public int offset { get; set; }
    }


}
