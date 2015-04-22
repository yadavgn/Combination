﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Brick.DemoTest.UnitTest
{
    /// <summary>
    ///This is a test class for SimpleClassTest and is intended
    ///to contain all SimpleClassTest Unit Tests
    ///</summary>
    [TestClass]
    public class SimpleClassTest
    {
        [TestMethod]
        public void GetText_NoInput_ReturnsStaticText()
        {
            var target = new SimpleClass();
            Assert.AreEqual("MSTestRunner", target.GetText());
        }


        /// <summary>
        ///A test for GetTextFromAppConfig
        ///</summary>
        [TestMethod]
        public void GetTextFromAppConfig_NoInput_ReturnsStaticTextFromAppConfig()
        {
            var target = new SimpleClass();
            Assert.AreEqual("MSTestRunner from app.config", target.GetTextFromAppConfig());
        }
    }
}
