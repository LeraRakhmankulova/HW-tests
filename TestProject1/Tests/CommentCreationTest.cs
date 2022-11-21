using SeleniumTests;
using OpenQA.Selenium;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace SeleniumTests

{
    [TestFixture]
    public class CommentCreationTest : AuthBase
    {

        [Test, Order(1)]
        public void CreateNewReviewCaseTest()
        {
            app.Navigation.OpenForumnPage();
            CommentData comment = new CommentData("всем привет! тут кто-то есть?");
            app.Comment.CreateNewComment(comment);

            CommentData newComment = app.Comment.GetCreatedComment();
            Assert.That(newComment.Description, Is.EqualTo(comment.Description));
        }
        public static IEnumerable<CommentData> CommentDataFromXmlFile()
        {
            return (List<CommentData>)new XmlSerializer(typeof(List<CommentData>))
                .Deserialize(new StreamReader(@"..\..\..\Data\comments.xml"));
        }

        [Test, Order(2), TestCaseSource(nameof(CommentDataFromXmlFile))]
        public void CreateFromXml(CommentData commentData)
        {
            app.Navigation.OpenForumnPage();
            app.Comment.CreateNewComment(commentData);
        }
    }
}

