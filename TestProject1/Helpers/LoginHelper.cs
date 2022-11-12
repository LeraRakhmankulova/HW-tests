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

        public LoginHelper(AppManager manager) : base(manager)
        {
        }

        public void Login(AccountData user)
        {
            driver.FindElement(By.Id("auth_name")).Click();
            driver.FindElement(By.Id("auth_name")).Clear();
            driver.FindElement(By.Id("auth_name")).SendKeys(user.Username.ToString());
            driver.FindElement(By.Id("auth_pass")).Click();
            driver.FindElement(By.Id("auth_pass")).Clear();
            driver.FindElement(By.Id("auth_pass")).SendKeys(user.Password.ToString());
            driver.FindElement(By.XPath("//input[@value='Войти']")).Click();
        }

        public void Logout()
        {
            driver.FindElement(By.Id("call_user")).Click();
            driver.FindElement(By.LinkText("Выйти")).Click();
            driver.FindElement(By.Name("exit")).Click();
            driver.FindElement(By.XPath("//input[@value='Выйти']")).Click();
        }
    }
}
