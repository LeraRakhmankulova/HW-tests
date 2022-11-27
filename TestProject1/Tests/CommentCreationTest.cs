using SeleniumTests;
using OpenQA.Selenium;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace SeleniumTests

{
    [TestFixture]
    public class CommentCreationTest : TestBase
    {
        [Test, Order(1)]
        public void LoginCaseTest()
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("test1000lera@mail.ru", "Le26ra1703.");
            app.Auth.Login(user);
            app.Navigation.OpenHomePage();
        }

        [Test, Order(2)]
        public void CreateNewReviewCaseTest()
        {
            app.Navigation.OpenForumnPage();
            CommentData comment = new CommentData("посоветуйте книгу)");
            app.Comment.CreateNewComment(comment);
            app.Navigation.OpenForumnPage();
            CommentData newComment = app.Comment.GetCreatedComment();
            Assert.That(newComment.Description, Is.EqualTo(comment.Description));
        }
    }
}

