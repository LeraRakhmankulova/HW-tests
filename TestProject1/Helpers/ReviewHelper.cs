using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTests;

namespace SeleniumTests
{
    public class ReviewHelper : HelperBase
    {

        public ReviewHelper(AppManager manager) : base(manager)
        {
        }

        public void CreateNewReview(ReviewData review)
        {
            driver.FindElement(By.LinkText("Золотые соседи")).Click();
            driver.FindElement(By.XPath("//div[@id='main']/div/section[3]/a")).Click();
            driver.FindElement(By.Id("edittags")).Click();
            driver.FindElement(By.Id("edittags")).Clear();
            driver.FindElement(By.Id("edittags")).SendKeys(review.Description.ToString());
            driver.FindElement(By.Id("btnPostSubmit")).Click();
        }
    }
}
