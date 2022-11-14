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

        public void TestLogin()
        {
            driver.Navigate().GoToUrl("https://accounts.meister.co/login?_sp=565620dd-ba2e-4e88-9c64-77412cbdcb27.1668417123744&product=meistertask&locale=ru&return_to=https%3A%2F%2Fwww.meistertask.com%2Fapp&r=140672");
            driver.FindElement(By.Id("login_email_login")).Click();
            driver.FindElement(By.Id("login_email_login")).Clear();
            driver.FindElement(By.Id("login_email_login")).SendKeys("raxmankulova.v@mail.ru");
            driver.FindElement(By.XPath("//form[@id='email_login_form']/fieldset/div[2]/label")).Click();
            driver.FindElement(By.Id("login_email_password")).Clear();
            driver.FindElement(By.Id("login_email_password")).SendKeys("Le26ra1703.");
            driver.FindElement(By.Id("btn_signin")).Click();
            driver.Navigate().GoToUrl("https://www.meistertask.com/app/onboarding");
            driver.Navigate().GoToUrl("https://www.meistertask.com/app/dashboard");
            driver.FindElement(By.CssSelector("div.kr-view.react-dialog-box > div.kr-view > div.kr-view > div.kr-view > div.kr-view > div.kr-view > div.kr-view > div.kr-view > div.kr-view > div.kr-view > div.kr-view > svg > path")).Click();
        }
    }
}
