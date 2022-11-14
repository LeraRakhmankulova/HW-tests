using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;

namespace SeleniumTests
{
    public class AppManager
    {
        private static ThreadLocal<AppManager> app = new ThreadLocal<AppManager>();

        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;

        private NavigationHelper navigation;
        private LoginHelper auth;
        private ReviewHelper review;
        private AppManager()
        {
            driver = new ChromeDriver(@"C:\Users\Valeria\Downloads\chromedriver_win32");
            baseURL = "https://forum.otzyv.ru";
            verificationErrors = new StringBuilder();
            driver.Manage().Window.Maximize();
            review = new ReviewHelper(this);
            auth = new LoginHelper(this);
            navigation = new NavigationHelper(this, baseURL);
        }

        public static AppManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                AppManager newInstance = new AppManager();
                newInstance.Navigation.OpenHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }
        ~AppManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                //ignore
            }
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

        public ReviewHelper Review
        {
            get
            {
                return review;
            }
        }

        public void Stop()
        {
            driver.Quit();
        }
        
    }
}
