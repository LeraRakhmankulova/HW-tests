using SeleniumTests;
using OpenQA.Selenium;

namespace SeleniumTests

{
    [TestFixture]
    public class LogoutTest : TestBase
    {
        [Test, Order(1)]
        public void LogoutCaseTest()
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("Lera26422002", "Le26ra1703.");
            app.Auth.Login(user);
            app.Navigation.OpenHomePage();
            app.Auth.Logout();
        }
    }
}

