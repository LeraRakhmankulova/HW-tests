using SeleniumTests;

namespace SeleniumTests

{
    [TestFixture]
    public class EditReviewTest : AuthBase
    {

        [Test, Order(2)]
        public void EditReviewhCaseTest()
        {

            app.Navigation.OpenForumnPage();
            CommentData comment = new CommentData("наверное нет...");
            app.Comment.CreateNewComment(comment);

            CommentData editedComment = new CommentData("наверное нет... жаль");
            app.Comment.EditComment(editedComment);

            CommentData newComment = app.Comment.GetCreatedComment();
            Assert.That(newComment.Description, Is.EqualTo(comment.Description));
        }
    }
}
