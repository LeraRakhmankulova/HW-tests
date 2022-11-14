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
    public class LoginHelper : HelperBase
    {

        public LoginHelper(AppManager manager)
            : base(manager)
        {
        }

        public void Login(AccountData user)
        {
            driver.FindElement(By.XPath("//div[@id='__next']/div/div/header/nav[2]/div/ul[2]/li/a")).Click();
            driver.Navigate().GoToUrl("https://todoist.com/auth/login");
            driver.FindElement(By.Id("element-0")).Click();
            driver.FindElement(By.Id("element-0")).Clear();
            driver.FindElement(By.Id("element-0")).SendKeys(user.Username.ToString());
            driver.FindElement(By.Id("element-3")).Click();
            driver.FindElement(By.Id("element-3")).Clear();
            driver.FindElement(By.Id("element-3")).SendKeys(user.Password.ToString());
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        public void Logout()
        {
            driver.FindElement(By.Id("call_user")).Click();
            driver.FindElement(By.LinkText("Выйти")).Click();
            driver.FindElement(By.Name("exit")).Click();
            driver.FindElement(By.XPath("//input[@value='Выйти']")).Click();
        }

        //public void TestLogin()
        //{
        //    driver.FindElement(By.XPath("//div[@id='__next']/div/div/header/nav[2]/div/ul[2]/li/a")).Click();
        //    driver.Navigate().GoToUrl("https://todoist.com/auth/login");
        //    driver.FindElement(By.Id("element-0")).Click();
        //    driver.FindElement(By.Id("element-0")).Clear();
        //    driver.FindElement(By.Id("element-0")).SendKeys("raxmankulova.v@mail.ru");
        //    driver.FindElement(By.Id("element-3")).Click();
        //    driver.FindElement(By.Id("element-3")).Clear();
        //    driver.FindElement(By.Id("element-3")).SendKeys("Le26ra1703.");
        //    driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        //    driver.Navigate().GoToUrl("https://todoist.com/app/");
        //}
    }
}
