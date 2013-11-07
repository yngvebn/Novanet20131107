using NUnit.Framework;
using Selenium.Webdriver.Domify;
using TechTalk.SpecFlow;

namespace Tests.Logic.Steps.Then
{
    [Binding]
    public class GenericGivens
    {
        [Then(@"I should be logged in as (.*)")]
        public void ThenIShouldBeLoggedInAs(string user)
        {
            Assert.That(Browser.Driver.Document().ContainsText(string.Format("hello {0}!", user)));

        }
 
    }
}