using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarframeStat.MainStatGetter;

namespace WarframeStatUnitTests
{
    [TestClass]
    public class JsonGetterFactoryTest
    {
        [TestMethod]
        public void GetJsonGetterTest()
        {
            MainStatGetterFactory factory = new MainStatGetterFactory();
            AbstractMainStatGetter Jsongetter = factory.GetJsonGetter(JsonGetterType.FromWarframeStat);

            Assert.IsInstanceOfType(Jsongetter,typeof(WarframeMainStatGetter));
        }
    }
}
