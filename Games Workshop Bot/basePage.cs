using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasePage
{
    internal class basePage
    {
        IWebDriver driver = new ChromeDriver();

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
    
