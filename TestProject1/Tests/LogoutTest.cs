using SeleniumTests;
using OpenQA.Selenium;

namespace SeleniumTests

{
    [TestFixture]
    public class LogoutTest : AuthBase
    {
        [Test, Order(3)]
        public void LogoutCaseTest()
        {
            app.Navigation.OpenHomePage();
            app.Auth.Logout();
        }
    }
}

