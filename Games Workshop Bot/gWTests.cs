using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BasePage;
using GamesWorkshopPO;

namespace Games_Workshop_Bot
{
    public class Tests
    {

        basePage basePage = new basePage();
        GamesWorkshop gwPO = new GamesWorkshop();

        [SetUp]
        public void Setup()
        {
            

            basePage.NavigateTo("https://www.games-workshop.com");
            basePage.Maximize();

        }

        [Test]
        public void GetToGWWebsite()
        {
            //basePage.SetImplicitWait(10);
            basePage.WaitForElement(gwPO.rejectCookies, 10);
            basePage.Click(gwPO.rejectCookies);
            //basePage.SetImplicitWait(5);
            basePage.WaitForElement(gwPO.chooseLanguage, 10);
            basePage.Click(gwPO.chooseLanguage);

            //Games Workshop website detects automation. More tests will be automated on KTDash
        }

        [TearDown]
        public void Teardown()
        {
            //basePage.CloseBrowser();
        }
    }
}