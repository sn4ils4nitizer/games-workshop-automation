using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasePage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KTDashPageObject
{

    public class KTDashPO
    {
        //Page Elements
        public By unername = By.Id("username");
        public By password = By.Id("password");
        public By loginBtn = By.XPath("//*[@id='navbarNav']/ul/li[3]/a");
        public By loginBtn2 = By.XPath("/html/body/div[2]/form/button");
        
     
    }

}
