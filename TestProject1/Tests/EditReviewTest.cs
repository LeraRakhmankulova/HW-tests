using SeleniumTests;

namespace SeleniumTests

{
    [TestFixture]
    public class EditReviewTest : TestBase
    {

        [Test, Order(3)]
        public void EditReviewhCaseTest()
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("Lera26422002", "Le26ra1703.");
            app.Auth.Login(user);
            app.Navigation.OpenReviewPage();
            ReviewData reviewData = new ReviewData("старый отзыв");
            app.Review.CreateNewReview(reviewData);

            app.Navigation.OpenEditReviewPage();
            ReviewData newReviewData = new ReviewData("новый тозыв");
            app.Review.EditReviewData(newReviewData);

            app.Navigation.OpenReviewPage();
            ReviewData newReview = app.Review.GetCreatedReviewDataById(468923);
            Assert.That(newReview.Description, Is.EqualTo(newReviewData.Description));
        }
    }
}

