using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarframeStat.MainStatGetter;
using WarframeStat.Statistics;

namespace WarframeStatUnitTests.JsonGetterTests
{
    [TestClass]
    public class WarframeMainStatGetterTest
    {
        [TestMethod]
        public void GetMainStatTest()
        {
            WarframeMainStatGetter jsonGetter = new WarframeMainStatGetter();
            MainStat stat = jsonGetter.GetMainStat();

            Assert.IsNotNull(stat);
        }
    }
}
