using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarframeStat;
using WarframeStat.MainStatGetter;
using WarframeStat.Statistics;

namespace WarframeStatUnitTests
{
    [TestClass]
    public class MainStatUpdatorTest
    {

        [TestMethod]
        public void ToTimeSpanTest()
        {
            MainStatUpdator updator = new MainStatUpdator(MainStatGetterType.FromWarframeStat);
            PrivateObject PrivateO = new PrivateObject(updator);

            TimeSpan Time = (TimeSpan)PrivateO.Invoke("ToTimeSpan","20h 10m 5s");

            Assert.AreEqual(Time,new TimeSpan(20,10,5));
        }

        [TestMethod]
        public void UpdateCetusCycle()
        {
            MainStatUpdator updator = new MainStatUpdator(MainStatGetterType.FromWarframeStat);
            PrivateObject PrivateO = new PrivateObject(updator);

            CetusCycle cycle = updator.stat.CetusCycle;

            cycle.TimeLeft = "20h 10m 5s";

            cycle = (CetusCycle)PrivateO.Invoke("UpdateCetusCycle",cycle,new TimeSpan(0,0,10));

            Assert.AreEqual(cycle.TimeLeft,"20h 9m 55s");
        }


    }
}
