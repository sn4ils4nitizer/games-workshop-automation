using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BasePage;
using GamesWorkshopPO;
using KTDashPageObject;

namespace Games_Workshop_Bot
{
    public class KTDashTests
    {

        basePage basePage = new basePage();
        KTDashPO KTPO = new KTDashPO();

        [SetUp]
        public void Setup2()
        {
            basePage.NavigateTo("https://ktdash.app/");
            basePage.Maximize();
       
        }

        [Test]
        public void LoginTest()
        {
            basePage.Click(KTPO.loginBtn);
            basePage.WaitForElement(KTPO.unername, 10);
            basePage.SendText(KTPO.unername, "chaoscultist1");
            basePage.SendText(KTPO.password, "chaoscult1");
            basePage.Click(KTPO.loginBtn2);
        }
        [Test]
        public void Test2()
        {

        }
        [TearDown]
        public void Teardown2()
        {
            //basePage.CloseBrowser();
        }
    }
}