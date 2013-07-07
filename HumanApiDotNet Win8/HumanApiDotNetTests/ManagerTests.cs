
using System;
using System.Collections.Generic;
using System.Linq;
using HumanApiDotNet;
using HumanApiDotNet.DataModel;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace HumanApiDotNetTests
{
    [TestClass]
    public class ManagerTests
    {
        [TestMethod]
        public void ManagerInstanceNotNull()
        {
            Assert.IsNotNull(Manager.Instance);
        }

        [TestMethod]
        public void ManagerInstanceOnlyInstantiatesOnce()
        {
            var manager = new Manager();
            Assert.AreEqual(manager, Manager.Instance);
        }

        [TestMethod]
        public void CanConvertJsonTimeToDateTime()
        {
            List<BloodGlucose> bg = Manager.Instance.GetRecentGlucose();
            Assert.IsNotNull(bg.First().timestamp);
        }


        [TestMethod]
        public void CanParseNestedClassObjectsFromJson()
        {
            Profile profile = Manager.Instance.GetProfile();
            Assert.IsNotNull(profile);
            Assert.AreEqual(profile.defaultTimeZone.offset, -28800);
        }

        [TestMethod]
        public void CanParseSummary()
        {
            Summary summary = Manager.Instance.GetSummary();
            Assert.IsNotNull(summary);
        }

        [TestMethod]
        public void CanParseActivitySummary()
        {
            Activity activity = Manager.Instance.GetRecentActivitySummary();
            Assert.IsNotNull(activity);
            Assert.IsNotNull(activity.date);
            Assert.IsNotNull(activity.light);
            Assert.IsNotNull(activity.moderate);
            Assert.IsNotNull(activity.steps);
            Assert.IsNotNull(activity.unit);
            Assert.IsNotNull(activity.vigorous);
        }

        [TestMethod]
        public void CanParseActivitySummaryByDate()
        {
            Activity activity = Manager.Instance.GetActivitySummaryByDate(DateTime.Now);
            Assert.IsNotNull(activity);
        }

        [TestMethod]
        public void CanParseSeriesInActivityWhenSeriesExists()
        {
            Activity series = Manager.Instance.GetActivitySeries();
            Assert.IsNotNull(series.series);
        }

        [TestMethod]
        public void CanParseActivitySeriesByDate()
        {
            Activity activity = Manager.Instance.GetActivitySeriesByDate(DateTime.Now);
            Assert.IsNotNull(activity);
        }
        //Glucose
        [TestMethod]
        public void CanParseBloodGlucose()
        {
            var bg = Manager.Instance.GetRecentGlucose();
            Assert.IsNotNull(bg);
        }

        [TestMethod]
        public void CanParseGlucoseByDate()
        {
            BloodGlucose glucose = Manager.Instance.GetGlucoseByDate("2013-06-21");
            Assert.IsNotNull(glucose);
        }

        //BloodPressure
        [TestMethod]
        public void CanParseBloodPressure()
        {
            var bg = Manager.Instance.GetRecentGlucose();
            Assert.IsNotNull(bg);
        }

        [TestMethod]
        public void CanParseBloodPressureByDate()
        {
            BloodPressure bp = Manager.Instance.GetBloodPressureByDate("2013-06-21");
            Assert.IsNotNull(bp);
        }

        [TestMethod]
        public void CanParseBloodPressureById()
        {
            BloodPressure bp = Manager.Instance.GetBloodPressureById(1);
            Assert.IsNotNull(bp);
        }

        //Bmi
        [TestMethod]
        public void CanParseBmi()
        {
            var bg = Manager.Instance.GetRecentBmi();
            Assert.IsNotNull(bg);
        }

        [TestMethod]
        public void CanParseBmiByDate()
        {
            List<Bmi> bmi = Manager.Instance.GetBmiByDate("2013-06-21");
            Assert.IsNotNull(bmi);
        }

        [TestMethod]
        public void CanParseBmiById()
        {
            Bmi bmi = Manager.Instance.GetBmiById(1);
            Assert.IsNotNull(bmi);
        }
        //BodyFat
        [TestMethod]
        public void CanParseBodyFat()
        {
            var bodyFat = Manager.Instance.GetRecentBodyFat();
            Assert.IsNotNull(bodyFat);
        }

        [TestMethod]
        public void CanParseBodyFatByDate()
        {
            List<BodyFat> bodyFat = Manager.Instance.GetBodyFatByDate("2013-06-21");
            Assert.IsNotNull(bodyFat);
        }

        [TestMethod]
        public void CanParseBodyFatById()
        {
            BodyFat bodyFat = Manager.Instance.GetBodyFatById(1);
            Assert.IsNotNull(bodyFat);
        }
        //HeartRate
        [TestMethod]
        public void CanParseHeartRate()
        {
            var heartRate = Manager.Instance.GetRecentHeartRate();
            Assert.IsNotNull(heartRate);
        }

        [TestMethod]
        public void CanParseHeartRateByDate()
        {
            HeartRate heartRate = Manager.Instance.GetHeartRateByDate("2013-06-21");
            Assert.IsNotNull(heartRate);
        }

        [TestMethod]
        public void CanParseHeartRateById()
        {
            HeartRate heartRate = Manager.Instance.GetHeartRateById(1);
            Assert.IsNotNull(heartRate);
        }
        //Height
        [TestMethod]
        public void CanParseHeight()
        {
            var height = Manager.Instance.GetRecentHeight();
            Assert.IsNotNull(height);
        }

        [TestMethod]
        public void CanParseHeightByDate()
        {
            Height height = Manager.Instance.GetHeightByDate("2013-06-21");
            Assert.IsNotNull(height);
        }

        [TestMethod]
        public void CanParseHeightById()
        {
            Height height = Manager.Instance.GetHeightById(1);
            Assert.IsNotNull(height);
        }
        //Location
        [TestMethod]
        public void CanParseLocation()
        {
            var location = Manager.Instance.GetRecentLocations();
            Assert.IsNotNull(location);
        }

        [TestMethod]
        public void CanParseLocationByDate()
        {
            List<Location> location = Manager.Instance.GetLocationByDate("2013-06-21");
            Assert.IsNotNull(location);
        }

        //Sleep
        [TestMethod]
        public void CanParseSleep()
        {
            var sleep = Manager.Instance.GetRecentSleep();
            Assert.IsNotNull(sleep);
        }

        [TestMethod]
        public void CanParseSleepByDate()
        {
            List<Sleep> sleep = Manager.Instance.GetSleepByDate("2013-06-21");
            Assert.IsNotNull(sleep);
        }

        [TestMethod]
        public void CanParseSleepById()
        {
            Sleep sleep = Manager.Instance.GetSleepById(1);
            Assert.IsNotNull(sleep);
        }
        //Weight
        [TestMethod]
        public void CanParseWeight()
        {
            var weight = Manager.Instance.GetRecentWeight();
            Assert.IsNotNull(weight);
        }

        [TestMethod]
        public void CanParseWeightByDate()
        {
            List<Weight> weight = Manager.Instance.GetWeightByDate("2013-06-21");
            Assert.IsNotNull(weight);
        }

        [TestMethod]
        public void CanParseWeightById()
        {
            Weight weight = Manager.Instance.GetWeightById(1);
            Assert.IsNotNull(weight);
        }
    }
}
