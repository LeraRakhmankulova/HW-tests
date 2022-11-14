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
//            app.Navigation.OpenReviewPage();
//            ReviewData reviewData = new ReviewData("5:32 - хороший сериал");
//            app.Review.CreateNewReview(reviewData);

//            ReviewData newReview = app.Review.GetCreatedReviewDataById(468923);
//            Assert.That(newReview.Description, Is.EqualTo(reviewData.Description));
//        }
//    }
//}

