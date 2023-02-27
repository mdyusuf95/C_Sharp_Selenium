

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


    }
}
