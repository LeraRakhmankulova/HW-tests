using SeleniumTests;
using System.Text;

namespace SeleniumTests
{
    public class TestBase
    {

        protected AppManager app;
        public static Random rnd = new Random();

        [SetUp]
        public void SetupTest()
        {
            app = AppManager.GetInstance();
        }
        public static string GenerateRandomString(int max)
        {
            int rndValue = Convert.ToInt32(rnd.NextDouble() * max);
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < rndValue; i++)
            {
                builder.Append(Convert.ToChar(32 + Convert.ToInt32(rnd.NextDouble() * 65)));

            }
            return builder.ToString();
        }

    }
}
