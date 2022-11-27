using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    [TestFixture]
    public class LoginTest : TestBase
    {
        [Test, Order(1)]
        public void LoginCaseTest()
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("test1000lera@mail.ru", "Le26ra1703.");
            app.Auth.Login(user);
            app.Navigation.OpenHomePage();
        }
    }
}
