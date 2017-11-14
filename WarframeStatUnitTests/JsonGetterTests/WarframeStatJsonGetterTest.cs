using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarframeStat.JsonGetter;
using WarframeStat.Statistics;

namespace WarframeStatUnitTests.JsonGetterTests
{
    [TestClass]
    public class WarframeStatJsonGetterTest
    {
        [TestMethod]
        public void GetMainStatTest()
        {
            WarframeStatJsonGetter jsonGetter = new WarframeStatJsonGetter();
            MainStat stat = jsonGetter.GetMainStat();

            Assert.IsNotNull(stat);
        }
    }
}
