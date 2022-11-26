using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;

namespace SeleniumTests
{
    public class AppManager
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;

        private NavigationHelper navigation;
        private LoginHelper auth;
        private CommentHelper comment;
        public AppManager()
        {
            driver = new ChromeDriver(@"C:\Users\Valeria\Downloads\chromedriver_win32");
            baseURL = "https://grouple.co/";
            verificationErrors = new StringBuilder();
            driver.Manage().Window.Maximize();
            comment = new CommentHelper(this);
            auth = new LoginHelper(this);
            navigation = new NavigationHelper(this, baseURL);
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
        public NavigationHelper Navigation
        {
            get
            {
                return navigation;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return auth;
            }
        }

        public CommentHelper Comment
        {
            get
            {
                return comment;
            }
        }

        public void Stop()
        {
            driver.Quit();
        }
        
    }
}
