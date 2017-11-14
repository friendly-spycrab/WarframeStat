using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarframeStat.JsonGetter;

namespace WarframeStatUnitTests
{
    [TestClass]
    public class JsonGetterFactoryTest
    {
        [TestMethod]
        public void GetJsonGetterTest()
        {
            JsonGetterFactory factory = new JsonGetterFactory();
            AbstractJsonGetter Jsongetter = factory.GetJsonGetter(JsonGetterType.FromWarframeStat);

            Assert.IsInstanceOfType(Jsongetter,typeof(WarframeStatJsonGetter));
        }
    }
}
