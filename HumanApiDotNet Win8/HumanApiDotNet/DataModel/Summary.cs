namespace HumanApiDotNet.DataModel
{
    public class Summary
    {
        public Summary(){}

        public int id { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public BloodGlucose bloodGlucose { get; set; }
        public BloodPressure bloodPressure { get; set; }
        public Bmi bmi { get; set; }
        public BodyFat bodyFat { get; set; }
        public Height height { get; set; }
        public HeartRate heartRate { get; set; }
        public Weight weight { get; set; }
        public Activity activities { get; set; }
        public Sleep sleep { get; set; }
    }
}