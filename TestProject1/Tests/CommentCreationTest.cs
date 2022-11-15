//using SeleniumTests;
//using OpenQA.Selenium;

//namespace SeleniumTests

//{
//    [TestFixture]
//    public class ReviewCreationTest : TestBase
//    {

//        [Test, Order(2)]
//        public void CreateNewReviewCaseTest()
//        {
//            app.Navigation.OpenHomePage();
//            AccountData user = new AccountData("raxmankulova.v@mail.ru", "Le26ra1703.");
//            app.Auth.Login(user);
//            app.Navigation.OpenForumnPage();
//            CommentData comment = new CommentData("Очень красивые рисуки!");
//            app.Comment.CreateNewComment(comment);

//            CommentData newComment = app.Comment.GetCreatedComment();
//            Assert.That(newComment.Description, Is.EqualTo(comment.Description));
//        }
//    }
//}

