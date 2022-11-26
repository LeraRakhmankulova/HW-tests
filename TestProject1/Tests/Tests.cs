using SeleniumTests;
using OpenQA.Selenium;
using System.Xml.Serialization;
using System.Xml.Linq;
using OpenQA.Selenium.Firefox;
using System.Text;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestFixture]
    public class Tests : TestBase
    {
        [Test, Order(1)]
        public void LoginCaseTest()
        {
            OpenHomePage();
            AccountData user = new AccountData("test1000lera@mail.ru", "Le26ra1703.");
            Login(user);
            OpenHomePage();
            Logout();
        }

        [Test, Order(1)]
        public void CreateNewReviewCaseTest()
        {
            AccountData user = new AccountData("test1000lera@mail.ru", "Le26ra1703.");
            Login(user);
            OpenForumnPage();
            CommentData comment = new CommentData("посоветуйте книгу)");
            CreateNewComment(comment);
            OpenForumnPage();
        }
        
    }
}

