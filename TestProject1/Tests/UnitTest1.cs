

namespace SeleniumTests

{
    [TestFixture]
    public class UntitledTestCase : TestBase
    {

        [Test]
        public void AuthCaseTest()
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("Lera2002", "Le26ra1703.");
            app.Auth.Login(user);
        }

        [Test]
        public void CreateNewTasktCaseTest()
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("Lera2002", "Le26ra1703.");
            app.Auth.Login(user);
            app.Navigation.OpenReviewPage();
            ReviewData reviewData = new ReviewData("Текст для создания отзыва");
            app.Review.CreateNewReview(reviewData);
            app.Navigation.OpenReviewPage();
        }
    }
}

