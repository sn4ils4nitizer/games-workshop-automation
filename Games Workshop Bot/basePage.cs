using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasePage
{
    public class basePage
    {
       protected IWebDriver driver = new ChromeDriver();

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SetImplicitWait(int seconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public void Click(By locator)
        {
            driver.FindElement(locator).Click();
        }    
    }
}
    
