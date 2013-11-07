using System;
using System.Reflection;
using TechTalk.SpecFlow;
using Selenium.Webdriver.Domify;
using Tests.Logic.Pages;

namespace Tests.Logic.Steps.Given
{
    [Binding]
    public class GenericGivens
    {
        [Given(@"I navigate to the (.*) page")]
        public void GivenINavigateToTheUserRegistrationPage(string pageTitle)
        {
            var document = Browser.Driver.Document();
            document.Settings.BaseUri = new Uri("http://localhost:50293/");
            document.Navigation.GoTo(Assembly.GetExecutingAssembly(), pageTitle);
        }

    }
}