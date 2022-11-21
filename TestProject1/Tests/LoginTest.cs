using SeleniumTests;
using OpenQA.Selenium;

namespace SeleniumTests

{
    [TestFixture]
    public class LoginTest : TestBase
    {
        [Test, Order(0)]
        public void LoginWithValidData()
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData(Settings.Login, Settings.Password);
            app.Auth.Login(user);
            app.Navigation.OpenHomePage();
            app.Auth.Logout();
        }

        [Test, Order(1)]
        public void LoginWithInvalidData()
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("raxmankulova.v@mail.ru", "Le26ra1703.");
            app.Auth.Login(user);
            app.Navigation.OpenHomePage();
        }
    }
}

