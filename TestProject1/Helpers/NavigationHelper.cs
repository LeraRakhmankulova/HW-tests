using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(AppManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://otzyv.ru/");
        }

        public void OpenReviewPage()
        {
            driver.FindElement(By.LinkText("Кино")).Click();
            driver.Navigate().GoToUrl("https://kino.otzyv.ru/");
        }
    }
}
