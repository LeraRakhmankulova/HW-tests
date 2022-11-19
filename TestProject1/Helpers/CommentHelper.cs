using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text.RegularExpressions;

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
            driver.FindElement(By.Id("text")).Click();
            driver.FindElement(By.Id("text")).Clear();
            driver.FindElement(By.Id("text")).SendKeys(comment.Description.ToString());
        }

        public CommentData GetCreatedComment()
        {
            var result = driver.FindElement(By.Id("comment-3352263")).Text;
            return new CommentData(result);
        }

        public void EditComment(CommentData comment)
        {
            driver.FindElement(By.Id("3352267")).Click();
            driver.FindElement(By.XPath("//*[@id=\"text\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"text\"]")).Clear();
            driver.FindElement(By.XPath("//*[@id=\"text\"]")).SendKeys("привет всем!!");
            driver.FindElement(By.XPath("//form[@id=' ']/input")).Click();
        }

        public void RemoveComment()
        {
            acceptNextAlert = true;
            driver.FindElement(By.Name("")).Click();
            driver.FindElement(By.LinkText("удалить")).Click();
        }
    }
}

