using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Games_Workshop_Bot
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
          
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            IWebElement ele1 = driver.FindElement(By.Name("q"));
            ele1.SendKeys("word bearers" + Keys.Enter);
            IWebElement ele2 = driver.FindElement(By.Id("rso"));
            var ele2Text = ele2.Text;
            Assert.That(ele2Text, Does.Contain("word bearers").IgnoreCase);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}