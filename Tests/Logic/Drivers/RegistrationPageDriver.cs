using Selenium.Webdriver.Domify;
using Tests.Logic.Pages;

namespace Tests.Logic.Drivers
{
    public class RegistrationPageDriver
    {
        private readonly RegistrationPage _page;

        public RegistrationPageDriver(RegistrationPage page)
        {
            _page = page;
        }

        public void RegisterUser(string username, string password, string confirmPassword)
        {
            _page.Username.Text = username;
            _page.Password.Text = password;
            _page.ConfirmPassword.Text = confirmPassword;
            _page.RegisterButton.Click();
        }
    }
}