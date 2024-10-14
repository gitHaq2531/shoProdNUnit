using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoProdSample.ObjectRepositoryShoProd
{
    internal class SignInSignUpPage
    {
        IWebDriver driver;
        public SignInSignUpPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement usernameTextField;
        public IWebElement getUsernameTextField() { return usernameTextField; }

        [FindsBy(How = How.Id, Using = "exampleInputPassword1")]
        private IWebElement logInPasswordTextField;
        public IWebElement getLogInPasswordTextField() { return logInPasswordTextField;}

        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement loginButton;
        public IWebElement getLoginButton() { return loginButton; }

        //business logic for SignIn...
        public void SignInToApp(string username,string password)
        {
            usernameTextField.SendKeys(username);
            logInPasswordTextField.SendKeys(password);
            loginButton.Click();
        }

        [FindsBy(How = How.Id, Using = "fullname")]
        private IWebElement fullNameTextField;
        public IWebElement getFullNameTextField() { return fullNameTextField; }

        [FindsBy(How=How.Name,Using = "emailid")]
        private IWebElement emailTextField;
        public IWebElement getEmailTextField() { return emailTextField; }

        [FindsBy(How= How.Id, Using = "contactno")]
        private IWebElement contactTextField;
        public IWebElement getContactTextField() { return contactTextField; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement signUpPasswordTextField;
        public IWebElement getSignUpPasswordTextField() { return signUpPasswordTextField; }

        [FindsBy(How = How.Id, Using = "confirmpassword")]
        private IWebElement confirmPasswordTextField;
        public IWebElement getConfirmPasswordTextField() {return confirmPasswordTextField; }

        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement submitButton;
        public IWebElement getSubmitButton() { return submitButton; }
        
    }
}
