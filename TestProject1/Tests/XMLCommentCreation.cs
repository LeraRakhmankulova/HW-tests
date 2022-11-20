using SeleniumTests;
using OpenQA.Selenium;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace SeleniumTests

{
    [TestFixture]
    public class XMLCommentCreationTest : TestBase
    {
        public static IEnumerable<CommentData> CommentDataFromXmlFile()
        {
            return (List<CommentData>)new XmlSerializer(typeof(List<CommentData>))
                .Deserialize(new StreamReader(@"..\..\..\Data\comments.xml"));
        }

        [Test, Order(1), TestCaseSource(nameof(CommentDataFromXmlFile))]
        public void CreateFromXml(CommentData commentData)
        {
            app.Navigation.OpenHomePage();
            AccountData user = new AccountData("raxmankulova.v@mail.ru", "Le26ra1703.");
            app.Auth.Login(user);
            app.Navigation.OpenForumnPage();
            app.Comment.CreateNewComment(commentData);
        }
    }
}

