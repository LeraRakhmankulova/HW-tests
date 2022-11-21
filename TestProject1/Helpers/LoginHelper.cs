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
        public bool IsLoggedIn(string username)
        {
            string text = driver.FindElement(By.XPath("//*[@id=\"wrap\"]/header/div/div[1]/div[2]/div[1]/div[1]/div[6]/a/span[1]/text()")).Text;
            return text == username;
        }
        public bool IsLoggedIn()
        {
            string text = driver.FindElement(By.XPath("//*[@id=\"wrap\"]/header/div/div[1]/div[2]/div[1]/div[1]/div[6]/a/span[1]/text()")).Text;
            return text != "Sign in";
        }

        public void Login(AccountData user)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(user.Username))
                {
                    return;
                }
                Logout();
            }
            driver.FindElement(By.XPath("//div[@id='wrap']/header/div/div/div[2]/div/div/div[3]/a")).Click();
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
    }
}
