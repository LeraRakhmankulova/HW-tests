using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTests
{
    public class CommentHelper : HelperBase
    {

        public CommentHelper(AppManager manager) 
            : base(manager)
        {
        }

        public void CreateNewComment(CommentData comment)
        {
            
            driver.FindElement(By.XPath("//img[@alt='Пачка фанартов, как и обещала']")).Click();
            driver.Navigate().GoToUrl("https://grouple.co/user/post/40352/pachka_fanartov__kak_i_obechala");
            driver.FindElement(By.Id("text")).Click();
            driver.FindElement(By.Id("text")).Clear();
            driver.FindElement(By.Id("text")).SendKeys(comment.Description.ToString());
            driver.FindElement(By.XPath("//form[@id=' ']/div/div[2]")).Click();
            driver.FindElement(By.Name(" ")).Click();
        }

        public CommentData GetCreatedComment()
        {
            var result =  driver.FindElement(By.XPath($"//*[@id=\"comment-3351905\"]/div")).Text;
            return new CommentData(result);
        }

    public void EditCommenta(CommentData comment)
        {
            driver.FindElement(By.LinkText("Редактировать")).Click();
            driver.Navigate().GoToUrl("https://forum.otzyv.ru/files/editpost.php?id=468932&f=https%3A%2F%2Fforum.otzyv.ru%2Ftema%2F8062%2F1980%2F%23468923");
            driver.FindElement(By.Id("edittags")).Click();
            driver.FindElement(By.Id("edittags")).Clear();
            driver.FindElement(By.Id("edittags")).SendKeys(comment.Description.ToString());
            driver.FindElement(By.Id("btnPostSubmit")).Click();
        }
    }
}
