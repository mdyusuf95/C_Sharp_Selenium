


using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace C_Sharp_Selenium.Main.ObjectRepositry
{
     class LogInPage
    {

        [FindsBy(How =How.Id,Using =("usernmae"))]
        private IWebElement UsernameBox { get; set; }

        [FindsBy(How = How.Id, Using = ("inputPassword"))]
        private IWebElement PasswordBox { get; set; }

        [FindsBy(How = How.XPath, Using = ("//button[.='Sign in']"))]
        private IWebElement SignInBtn { get; set; }

        [FindsBy(How = How.XPath, Using = ("//h5[@class='card-title text-center']"))]
        private IWebElement SignInText { get; set; }

        [FindsBy(How = How.XPath, Using = ("//div[@class='card-body']"))]
        private IWebElement SignCardBody { get; set; }


        public LogInPage(IWebDriver driver )
        {
            PageFactory.InitElements(driver, this);
        }


        public void SetLogIn(String username ,String Password )
        {
            UsernameBox.SendKeys(username);
            PasswordBox.SendKeys(Password);
            SignInBtn.Click();

        }

        public IWebElement GetUsernameBox()
        {
            return UsernameBox;
        }
        public IWebElement GetPassWordBox()
        {
            return PasswordBox;
        }
        public IWebElement GetSignInBtn()
        {
            return SignInBtn;      
        }
        public IWebElement GetSignInText()
        {
            return SignInText;
        }
        public IWebElement GetSignCardBody()
        {
            return SignCardBody;
        }

    }
}
