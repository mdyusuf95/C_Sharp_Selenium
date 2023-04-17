using C_Sharp_Selenium.Main.Genric;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace C_Sharp_Selenium.Tests
{
    [TestClass]  
    public  class HomePageTest:BaseClass
    {

       
       
        [TestCategory("smoke")]
        public void HomeDisplayTest()
        {

           
            

            //home page titel should ="React App"
            String Expectedtiltel = "React App";
            String Actualtiltle=Utility.GetDriver() .Title;
            Assert.IsTrue(Expectedtiltel.Equals(Actualtiltle));
           

            //test log
            Utility.GetWebDriverUtilities().LogTest(extent, _testcontext, MethodBase.GetCurrentMethod().Name);
        }

       [TestMethod]
        [TestCategory("smoke")]
        public void HomePageElementsDisplayedTest()
        {
          

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

            //test log
            Utility.GetWebDriverUtilities().LogTest(extent, _testcontext, MethodBase.GetCurrentMethod().Name);
        }

        [TestMethod]
        [TestCategory("smoke")]
        public void HomePageElementsEnableTest()
        {
          //  homePage = new HomePage(driver);

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

            //test log
            Utility.GetWebDriverUtilities().LogTest(extent, _testcontext, MethodBase.GetCurrentMethod().Name);
        }



    }
}
