using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Selenium.Webdriver.Domify;
using TechTalk.SpecFlow;

namespace Tests.Logic.Steps
{
    [Binding]
    public class BrowserSetupClass
    {
        [BeforeFeature]
        public static void StartWebDriver()
        {
            Browser.Driver = new ChromeDriver(@"C:\Users\YngveBakken\Documents\visual studio 2013\Projects\Demo20131107\Drivers\");
            
        }

        [AfterFeature]
        public static void KillWebDriver()
        {
            Browser.Driver.Close();
            Browser.Driver.Dispose();
        }
    }
}