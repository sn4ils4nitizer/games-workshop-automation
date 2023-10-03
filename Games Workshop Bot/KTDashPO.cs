﻿using System;
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
        public By titleWelcome = By.XPath("/html/body/div[20]/h1");
        public By cancelInstallBtn = By.XPath("//*[@id='installmodal']/div/div/div[3]/button[1]");
     
    }

}
