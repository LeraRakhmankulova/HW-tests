using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests;
using System.Text;

namespace SeleniumTests
{
    public class TestBase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver(@"C:\Users\Valeria\Downloads\chromedriver_win32");
            baseURL = "https://grouple.co/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        public void CreateNewComment(CommentData comment)
        {
            driver.FindElement(By.Id("text")).Click();
            driver.FindElement(By.Id("text")).Clear();
            driver.FindElement(By.Id("text")).SendKeys(comment.Description.ToString());
            driver.FindElement(By.Name(" ")).Click();
        }
        public void Login(AccountData user)
        {
            driver.Navigate().GoToUrl("https://grouple.co/");
            driver.FindElement(By.XPath("//*[@id=\"wrap\"]/header/div/div[1]/div[2]/div[1]/div[1]/div[3]/a")).Click();
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys(user.Username.ToString());
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(user.Password.ToString());
            driver.FindElement(By.XPath("//input[@value='Вход']")).Click();
        }
        public void Logout()
        {
            driver.FindElement(By.XPath("//div[@id='wrap']/header/div/div/div[2]/div/div/div[6]/a/span")).Click();
            driver.FindElement(By.XPath("//div[@id='accountMenu']/div/a[6]/div")).Click();
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://grouple.co/");
        }

        public void OpenForumnPage()
        {
            driver.Navigate().GoToUrl($"{baseURL}community/sort/hot");
            driver.FindElement(By.LinkText("книжный шкаф")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
