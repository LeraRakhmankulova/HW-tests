using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using OpenQA.Selenium.Support.UI;
using System.ComponentModel.Design;

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
            driver.FindElement(By.Name(" ")).Click();
        }

        public CommentData GetCreatedComment()

        {
            var result = driver.FindElement(By.XPath($"//*[@id=\"comment-3352546\"]/div")).Text;
            return new CommentData(result);
        }
        public CommentData GetEditedComment()

        {
            var result = driver.FindElement(By.XPath($"//*[@id=\"comment-3352552\"]/div")).Text;
            return new CommentData(result);
        }

        public void EditComment(CommentData comment)
        {
            driver.FindElement(By.Id("3352552")).Click();
            driver.FindElement(By.XPath("//*[@id=\"text\"]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"text\"]")).Clear();
            driver.FindElement(By.XPath("//*[@id=\"text\"]")).SendKeys(comment.ToString());
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

