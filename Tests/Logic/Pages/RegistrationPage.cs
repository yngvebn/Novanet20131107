using System.Linq;
using OpenQA.Selenium;
using Selenium.Webdriver.Domify;
using Selenium.Webdriver.Domify.Elements;

namespace Tests.Logic.Pages
{
    [PageDescription("UserRegistration", "/Account/Register")]
    public class RegistrationPage: Page
    {
        public TextField Username
        {
            get
            {
                return Document.TextField("UserName");
            }
        }

        public TextField Password
        {
            get
            {
                return Document.TextField("Password");
            }
        }

        public TextField ConfirmPassword
        {
            get
            {
                return Document.TextField("ConfirmPassword");
            }
        }

        public Button RegisterButton
        {
            get
            {
                return Document.Buttons().SingleOrDefault(button => button.Text == "Register");
            }
        }
    }
}