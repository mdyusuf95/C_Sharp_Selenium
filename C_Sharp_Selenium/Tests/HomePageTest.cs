using C_Sharp_Selenium.Main.Genric;
using C_Sharp_Selenium.Main.ObjectRepositry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Selenium.Tests
{
    [TestClass]  
    public  class HomePageTest:BaseClass
    {

        public HomePage homePage;
        [TestMethod ,Priority(-1)]
        public void HomeDisplayTest()
        {

           //home should displayed 
            homePage=new HomePage(driver);

            //home page titel should ="React App"
            String Expectedtiltel = "React App";
            String Actualtiltle=driver.Title;
            Assert.AreEqual(Expectedtiltel,Actualtiltle);
           

        }

       [TestMethod,Priority(0)]
        public void HomePageElementsDisplayedTest()
        {
            homePage = new HomePage(driver);

            // testyantra should display
            Assert.IsTrue(homePage.getTestYantra().Displayed);

            //Menu should display
            Assert.IsTrue(homePage.getMenu().Displayed);

            //home should display
            Assert.IsTrue(homePage.getHome().Displayed);

            //Projects should display
            Assert.IsTrue(homePage.getProjects().Displayed);

            // users should display
            Assert.IsTrue(homePage.getUsers().Displayed);

            //settings should display
            Assert.IsTrue(homePage.getSettings().Displayed);

            //logOut should display
            Assert.IsTrue(homePage.getLogOut().Displayed);

        }

        [TestMethod,Priority(1)]
        public void HomePageElementsEnableTest()
        {
            homePage = new HomePage(driver);

            // testyantra should display
            Assert.IsTrue(homePage.getTestYantra().Enabled);

            //Menu should display
            Assert.IsTrue(homePage.getMenu().Enabled);

            //home should display
            Assert.IsTrue(homePage.getHome().Enabled);

            //Projects should display
            Assert.IsTrue(homePage.getProjects().Enabled);

            // users should display
            Assert.IsTrue(homePage.getUsers().Enabled);

            //settings should display
            Assert.IsTrue(homePage.getSettings().Enabled);

            //logOut should display
            Assert.IsTrue(homePage.getLogOut().Enabled);

        }



    }
}
