using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTests
{
    public class ReviewHelper : HelperBase
    {

        public ReviewHelper(AppManager manager) 
            : base(manager)
        {
        }

        public void CreateNewReview(ReviewData review)
        {
            driver.FindElement(By.Id("edittags")).Click();
            driver.FindElement(By.Id("edittags")).Clear();
            driver.FindElement(By.Id("edittags")).SendKeys(review.Description.ToString());
            driver.FindElement(By.Id("btnPostSubmit")).Click();
        }

        public ReviewData GetCreatedReviewDataById(int idData)
        {
            driver.Navigate().GoToUrl("https://forum.otzyv.ru/tema/8062/1980/");
            var result =  driver.FindElement(By.XPath($"//div[@id='{idData}']/div[2]")).Text;
            return new ReviewData(result);
        }

    public void EditReviewData(ReviewData review)
        {
            driver.FindElement(By.LinkText("Редактировать")).Click();
            driver.Navigate().GoToUrl("https://forum.otzyv.ru/files/editpost.php?id=468932&f=https%3A%2F%2Fforum.otzyv.ru%2Ftema%2F8062%2F1980%2F%23468923");
            driver.FindElement(By.Id("edittags")).Click();
            driver.FindElement(By.Id("edittags")).Clear();
            driver.FindElement(By.Id("edittags")).SendKeys(review.Description.ToString());
            driver.FindElement(By.Id("btnPostSubmit")).Click();
        }
    }
}
