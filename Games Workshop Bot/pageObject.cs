using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasePage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GamesWorkshopPO
{
    
    public class GamesWorkshop
    { 
        //Page Elements

        //Cookies pop-up
       public By rejectCookies = By.Id("onetrust-reject-all-handler");
       public By chooseLanguage = By.XPath("//*[@id='country-selector']/ul/li[17]/a");
    }
    
}
