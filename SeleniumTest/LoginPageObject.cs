using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTest
{
    public class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObject Login(string userName, string password)
        {
            this.txtUserName.EnterText(userName);
            this.txtPassword.EnterText(password);
            this.btnLogin.Clicks();

            //return page object
            return new EAPageObject();
        }
    }
}
