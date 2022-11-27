using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class AuthBase : TestBase
    {
        [SetUp]
        public void SetupTest()
        {
            AccountData user = new AccountData(Settings.Login, Settings.Password);
            app.Auth.Login(user);
        }

    }
}
