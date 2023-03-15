using C_Sharp_Selenium.Main.Genric;
using C_Sharp_Selenium.Main.ObjectRepositry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Selenium.Tests
{
    [TestClass]
    public class LogInPageTest
    {
       

        [TestMethod]
        [TestCategory("smoke")]
        public void LogInPageElementsAreEnabled()
        {  
            // Elements present in Login page Should be Enabled 
            LogInPage logInPage = new LogInPage(BaseClass.driver);
           

            //username button should be Enabled 
            bool usernameBox = logInPage.GetUsernameBox().Enabled;
            Assert.IsTrue(usernameBox);

            //PasswordBox should be Enabled
            bool PasswordBox = logInPage.GetPassWordBox().Enabled;
            Assert.IsTrue(PasswordBox);

            //Signinbtn should be Enabled
            bool signInBtn = logInPage.GetSignInBtn().Enabled;
            Assert.IsTrue(signInBtn);
            
        }

        [TestMethod]
        [TestCategory("smoke")]
        public void LogInPageElementsArePresent()
        {


            //singin loginpage all elements should present
            LogInPage logInPage = new LogInPage(BaseClass.driver);

            //signin text should be display 
            bool singCardBody = logInPage.GetSignCardBody().Displayed;
            Assert.IsTrue(singCardBody);

            //signInText Should be display
            bool signInText = logInPage.GetSignInText().Displayed;
            Assert.IsTrue(signInText);

            //username button should be display
            bool usernameBox = logInPage.GetUsernameBox().Displayed;
            Assert.IsTrue(usernameBox);

            //PasswordBox should be display
            bool PasswordBox = logInPage.GetPassWordBox().Displayed;
            Assert.IsTrue(PasswordBox);

            //Signinbtn should be display 
            bool signInBtn = logInPage.GetSignInBtn().Displayed;
            Assert.IsTrue(signInBtn);
        }
    }
  
  }
    
    

