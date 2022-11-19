//using SeleniumTests;

//namespace SeleniumTests

//{
//    [TestFixture]
//    public class EditReviewTest : TestBase
//    {

//        [Test, Order(2)]
//        public void EditReviewhCaseTest()
//        {
//            app.Navigation.OpenHomePage();
//            AccountData user = new AccountData("raxmankulova.v@mail.ru", "Le26ra1703.");
//            app.Auth.Login(user);
//            app.Navigation.OpenForumnPage();
//            CommentData comment = new CommentData("наверное нет...");
//            app.Comment.CreateNewComment(comment);

//            CommentData editedComment = new CommentData("наверное нет... жаль");
//            app.Comment.EditComment(editedComment);

//            CommentData newComment = app.Comment.GetCreatedComment();
//            Assert.That(newComment.Description, Is.EqualTo(comment.Description));
//        }
//    }
//}

