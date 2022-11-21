using SeleniumTests;

namespace SeleniumTests

{
    [TestFixture]
    public class EditReviewTest : TestBase
    {

        [Test, Order(4)]
        public void EditReviewhCaseTest()
        {
            app.Navigation.OpenForumnPage();

            CommentData comment = new CommentData("как дела?");
            app.Comment.CreateNewComment(comment);

            CommentData editedComment = new CommentData("привет!");
            app.Comment.EditComment(editedComment);
        }
    }
}

