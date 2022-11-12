﻿using SeleniumTests;

namespace SeleniumTests
{
    public class TestBase
    {

        protected AppManager app;

        [SetUp]
        public void SetupTest()
        {
            app = new AppManager();
        }
        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }
    }
}
