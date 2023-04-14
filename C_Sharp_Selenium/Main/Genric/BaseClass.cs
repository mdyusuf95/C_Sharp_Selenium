

//[assembly:Parallelize(Workers =1,Scope =ExecutionScope.ClassLevel)]

using AventStack.ExtentReports;
using C_Sharp_Selenium.Main.ObjectRepositry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace C_Sharp_Selenium.Main.Genric
{
    [TestClass]
    public class BaseClass
    {
        public static TestContext _testcontext;
       
       
        public static IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentTest test;

        //public static WebDriverUtilities Wd_util;
        //public static CShapUtilities cs_util;
        //public static DataBaseUtilities dB_util;
        //public static ExcelUtilities excel_util;
        public  HomePage homePage;
        public LogInPage logInPage;
        public ProjectsPage projectsPage;

        [AssemblyInitialize]
        public static void ClassInitialize(TestContext context)
        {
             
            _testcontext = context;
            string Browser = context.Properties["Browser"].ToString();
            string Url = context.Properties["Url"].ToString();

            Utility.SetWebDriverUtilities(new WebDriverUtilities());
            Utility.SetExcelUtilities(new ExcelUtilities());
            Utility.SetCShapUtilities(new CShapUtilities());

            WebDriverUtilities Wd_util=Utility.GetWebDriverUtilities();


             Wd_util.OpenBrowserAndMaximizeAndImplicitWait( Browser);


          //  driver = Wd_util.GetEventfiringWebDriver(driver);
           Wd_util.Get( Url);

           extent= Wd_util.CreateExtentReportAndAttachToHtml(extent);

           



        }

        [TestInitialize]
         public  void logIn()
         {
            
            String username =_testcontext.Properties["username"].ToString();
            String password =_testcontext.Properties["password"].ToString();

            logInPage = new LogInPage();
            homePage = new HomePage();
            projectsPage = new ProjectsPage();

            logInPage.SetLogIn(username,password);
           
        }

        [TestCleanup]
        public void logOut()
        {
            Utility.GetWebDriverUtilities().LogTest(extent, _testcontext);
           
            homePage.LogOut();
        }

        [AssemblyCleanup]
        public static void CloseBrowser()
        {
            Utility.GetWebDriverUtilities().Quit(extent);
        }

    }
}
