using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarframeStat.MainStatGetter;

namespace WarframeStatUnitTests
{
    [TestClass]
    public class JsonGetterFactoryTest
    {
        [TestMethod]
        public void GetMainStatGetterTest()
        {
            MainStatGetterFactory factory = new MainStatGetterFactory();
            AbstractMainStatGetter Jsongetter = factory.GetMainStatGetter(MainStatGetterType.FromWarframeStat);

            Assert.IsInstanceOfType(Jsongetter,typeof(WarframeMainStatGetter));
        }

        [TestMethod]
        public void GetMainStatGetterDefaultTest()
        {
            MainStatGetterFactory factory = new MainStatGetterFactory();
            AbstractMainStatGetter Jsongetter = factory.GetMainStatGetter((MainStatGetterType)4);

            Assert.IsNull(Jsongetter);
        }
    }
}
