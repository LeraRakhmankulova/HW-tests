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

        public NavigationHelper(AppManager manager, string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://otzyv.ru");
        }

        public void OpenReviewPage()
        {
            driver.Navigate().GoToUrl($"{baseURL}/razdel/8/");
            driver.FindElement(By.LinkText("Какие у вас любимые сериалы?")).Click();
            driver.Navigate().GoToUrl($"{baseURL}/tema/7722/?v=131122143451");
        }

        public void OpenLastReviewPages(int id)
        {
            driver.Navigate().GoToUrl($"{baseURL}/tema/8062/1980/#{id}");
        }

        public void OpenEditReviewPage()
        {
            driver.FindElement(By.XPath("//div[@id='main']/section[3]/div/div/div[3]/a")).Click();
            driver.Navigate().GoToUrl($"{baseURL}/tema/8062/1980/");
        }
    }
}
