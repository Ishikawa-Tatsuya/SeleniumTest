using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using System.IO;

namespace Test
{
    [TestClass]
    public class Sample
    {
        FirefoxDriver _driver;

        [TestInitialize]
        public void TestInitialize()
        {
            _driver = new FirefoxDriver();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void Test()
        {
            var path = Path.GetFullPath("../../../Target/Index.html");
            var url = "file:///" + path;
            _driver.Url = url;
        }
    }
}
