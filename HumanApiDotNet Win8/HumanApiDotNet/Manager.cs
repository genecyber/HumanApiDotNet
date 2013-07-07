using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HumanApiDotNet.DataModel;
using Newtonsoft.Json;

namespace HumanApiDotNet
{
    public class Manager
    {
        private static Manager _instance;
        private readonly Uri _baseUrl = new Uri("http://humanapi.co/v1/human/");

        public Manager()
        {
            _instance = this;
        }
        public static Manager Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                return _instance = new Manager();
            }
        }
        private async Task<string> MakeWebRequest(String command)
        {
            var http = new HttpClient();
            var response = await http.GetAsync(_baseUrl + command);
            return await response.Content.ReadAsStringAsync();
        }
        private T Objectify<T>(String response)
        {
            return JsonConvert.DeserializeObject<T>(response);
        }

        public Profile GetProfile()
        {
            var response = MakeWebRequest("profile");
            return Objectify<Profile>(response.Result);
        }

        public Summary GetSummary()
        {
            var response = MakeWebRequest("");
            return Objectify<Summary>(response.Result);
        }

        public Activity GetRecentActivitySummary()
        {
            var response = MakeWebRequest("activity");
            return Objectify<Activity>(response.Result);
        }

        public Activity GetActivitySummaryByDate(DateTime date)
        {
            var response = MakeWebRequest("activity/daily/" + date.ToString("u").Split(' ').First());
            return Objectify<Activity>(response.Result);
        }

        public Activity GetActivitySeries()
        {
            var response = MakeWebRequest("activity/series");
            return Objectify<Activity>(response.Result);
        }

        public Activity GetActivitySeriesByDate(DateTime date)
        {
            var response = MakeWebRequest("activity/series/" + date.ToString("u").Split(' ').First());
            return Objectify<Activity>(response.Result);
        }
        //Glucose
        public List<BloodGlucose> GetRecentGlucose()
        {
            var response = MakeWebRequest("blood_glucose");
            return Objectify<List<BloodGlucose>>(response.Result);
        }

        public BloodGlucose GetGlucoseByDate(DateTime date)
        {
            return GetGlucoseByDate(date.ToString("u").Split(' ').First());
        }

        public BloodGlucose GetGlucoseByDate(String date)
        {
            var response = MakeWebRequest("blood_glucose/daily/" + date);
            return Objectify<BloodGlucose>(response.Result);
        }

        public BloodGlucose GetGlucoseById(int id)
        {
            var response = MakeWebRequest("blood_glucose/" + id);
            return Objectify<BloodGlucose>(response.Result);
        }
        //BloodPressure
        public List<BloodPressure> GetRecentBloodPressure()
        {
            var response = MakeWebRequest("blood_pressure");
            return Objectify<List<BloodPressure>>(response.Result);
        }

        public BloodPressure GetBloodPressureByDate(DateTime date)
        {
            return GetBloodPressureByDate(date.ToString("u").Split(' ').First());
        }

        public BloodPressure GetBloodPressureByDate(String date)
        {
            var response = MakeWebRequest("blood_pressure/daily/" + date);
            return Objectify<BloodPressure>(response.Result);
        }

        public BloodPressure GetBloodPressureById(int id)
        {
            var response = MakeWebRequest("blood_pressure/" + id);
            return Objectify<BloodPressure>(response.Result);
        }
        //Bmi
        public List<Bmi> GetRecentBmi()
        {
            var response = MakeWebRequest("bmi");
            return Objectify<List<Bmi>>(response.Result);
        }

        public List<Bmi> GetBmiByDate(DateTime date)
        {
            return GetBmiByDate(date.ToString("u").Split(' ').First());
        }

        public List<Bmi> GetBmiByDate(String date)
        {
            var response = MakeWebRequest("bmi/daily/" + date);
            return Objectify<List<Bmi>>(response.Result);
        }

        public Bmi GetBmiById(int id)
        {
            var response = MakeWebRequest("bmi/" + id);
            return Objectify<Bmi>(response.Result);
        }
        //Body_fat
        public List<BodyFat> GetRecentBodyFat()
        {
            var response = MakeWebRequest("body_fat");
            return Objectify<List<BodyFat>>(response.Result);
        }

        public List<BodyFat> GetBodyFatByDate(DateTime date)
        {
            return GetBodyFatByDate(date.ToString("u").Split(' ').First());
        }

        public List<BodyFat> GetBodyFatByDate(String date)
        {
            var response = MakeWebRequest("body_fat/daily/" + date);
            return Objectify<List<BodyFat>>(response.Result);
        }

        public BodyFat GetBodyFatById(int id)
        {
            var response = MakeWebRequest("body_fat/" + id);
            return Objectify<BodyFat>(response.Result);
        }
        //HeartRate
        public List<HeartRate> GetRecentHeartRate()
        {
            var response = MakeWebRequest("heart_rate");
            return Objectify<List<HeartRate>>(response.Result);
        }

        public HeartRate GetHeartRateByDate(DateTime date)
        {
            return GetHeartRateByDate(date.ToString("u").Split(' ').First());
        }

        public HeartRate GetHeartRateByDate(String date)
        {
            var response = MakeWebRequest("heart_rate/daily/" + date);
            return Objectify<HeartRate>(response.Result);
        }

        public HeartRate GetHeartRateById(int id)
        {
            var response = MakeWebRequest("heart_rate/" + id);
            return Objectify<HeartRate>(response.Result);
        }
        //Height
        public List<Height> GetRecentHeight()
        {
            var response = MakeWebRequest("height");
            return Objectify<List<Height>>(response.Result);
        }

        public Height GetHeightByDate(DateTime date)
        {
            return GetHeightByDate(date.ToString("u").Split(' ').First());
        }

        public Height GetHeightByDate(String date)
        {
            var response = MakeWebRequest("height/daily/" + date);
            return Objectify<Height>(response.Result);
        }

        public Height GetHeightById(int id)
        {
            var response = MakeWebRequest("height/" + id);
            return Objectify<Height>(response.Result);
        }
        //Location
        public List<Location> GetRecentLocations()
        {
            var response = MakeWebRequest("location");
            return Objectify<List<Location>>(response.Result);
        }

        public List<Location> GetLocationByDate(DateTime date)
        {
            return GetLocationByDate(date.ToString("u").Split(' ').First());
        }

        public List<Location> GetLocationByDate(String date)
        {
            var response = MakeWebRequest("location/daily/" + date);
            return Objectify<List<Location>>(response.Result);
        }
        //Sleep
        public List<Sleep> GetRecentSleep()
        {
            var response = MakeWebRequest("sleep");
            return Objectify<List<Sleep>>(response.Result);
        }

        public List<Sleep> GetSleepByDate(DateTime date)
        {
            return GetSleepByDate(date.ToString("u").Split(' ').First());
        }

        public List<Sleep> GetSleepByDate(String date)
        {
            var response = MakeWebRequest("sleep/daily/" + date);
            return Objectify<List<Sleep>>(response.Result);
        }

        public Sleep GetSleepById(int id)
        {
            var response = MakeWebRequest("sleep/" + id);
            return Objectify<Sleep>(response.Result);
        }
        //Weight
        public List<Weight> GetRecentWeight()
        {
            var response = MakeWebRequest("weight");
            return Objectify<List<Weight>>(response.Result);
        }

        public List<Weight> GetWeightByDate(DateTime date)
        {
            return GetWeightByDate(date.ToString("u").Split(' ').First());
        }

        public List<Weight> GetWeightByDate(String date)
        {
            var response = MakeWebRequest("weight/daily/" + date);
            return Objectify<List<Weight>>(response.Result);
        }

        public Weight GetWeightById(int id)
        {
            var response = MakeWebRequest("weight/" + id);
            return Objectify<Weight>(response.Result);
        }



    }

}
