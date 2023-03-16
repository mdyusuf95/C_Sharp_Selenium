

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

        public static WebDriverUtilities Wd_util = new WebDriverUtilities();
        public static CShapUtilities cs_util = new CShapUtilities();
        public static DataBaseUtilities dB_util = new DataBaseUtilities();
        public static ExcelUtilities excel_util = new ExcelUtilities();

    
        [AssemblyInitialize]
        public static void ClassInitialize(TestContext context)
        {
             
            _testcontext = context;
            string Browser = context.Properties["Browser"].ToString();
            string Url = context.Properties["Url"].ToString();


           driver= Wd_util.OpenBrowserAndMaximizeAndImplicitWait(driver, Browser);
           driver= Wd_util.GetEventfiringWebDriver(driver);
           Wd_util.Get(driver, Url);

           extent= Wd_util.CreateExtentReportAndAttachToHtml(extent);
          

        }

        [TestInitialize]
         public  void logIn()
         {
            
            String username =_testcontext.Properties["username"].ToString();
            String password =_testcontext.Properties["password"].ToString();
            
            LogInPage logInPage=new LogInPage(driver);
            logInPage.SetLogIn(username,password);
           
        }

        [TestCleanup]
        public void logOut()
        {
            Wd_util.LogTest(extent, _testcontext);
            HomePage homePage =new HomePage(driver);
            homePage.LogOut();
        }

        [AssemblyCleanup]
        public static void CloseBrowser()
        {
            Wd_util.Quit(driver, extent);
        }

    }
}
