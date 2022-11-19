using SeleniumTests;
using OpenQA.Selenium;

namespace SeleniumTests

{
    [TestFixture]
    public class LoginTest : TestBase
    {
        [Test, Order(0)]
        public void LoginCaseTest()
        {

            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("raxmankulova.v@mail.ru", "Le26ra1703.");
            app.Auth.Login(user);
            app.Navigation.OpenHomePage();
        }
    }
}

