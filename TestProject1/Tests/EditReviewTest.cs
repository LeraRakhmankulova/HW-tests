using SeleniumTests;

namespace SeleniumTests

{
    [TestFixture]
    public class EditReviewTest : TestBase
    {

        [Test, Order(0)]
        public void EditReviewhCaseTest()
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("raxmankulova.v@mail.ru", "Le26ra1703.");
            app.Auth.Login(user);
            app.Navigation.OpenForumnPage();
            CommentData comment = new CommentData("Очень красивые рисуки!");
            app.Comment.CreateNewComment(comment);

            CommentData editedComment = new CommentData("Круто!");
            app.Comment.EditComment(editedComment);
        }
    }
}

