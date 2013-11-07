using Selenium.Webdriver.Domify;
using TechTalk.SpecFlow;
using Tests.Logic.Arguments;
using Tests.Logic.Drivers;
using Tests.Logic.Pages;

namespace Tests.Logic.Steps.Given
{
    [Binding]
    public class RegistrationGiven
    {
        [Given(@"I register with the following information")]
        public void GivenIRegisterWithTheFollowingInformation(RegistrationInfo info)
        {
            var driver =
                new RegistrationPageDriver(Browser.Driver.Document().Navigation.GetCurrentPage<RegistrationPage>());
            driver.RegisterUser(info.Username, info.Password, info.ConfirmPassword);
        }
 
    }
}