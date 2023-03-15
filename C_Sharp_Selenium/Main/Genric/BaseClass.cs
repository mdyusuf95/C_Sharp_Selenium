

//[assembly:Parallelize(Workers =1,Scope =ExecutionScope.ClassLevel)]




using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using C_Sharp_Selenium.Main.ObjectRepositry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Events;
using System;

namespace C_Sharp_Selenium.Main.Genric
{
    [TestClass]
    public class BaseClass
    {
        public static TestContext _testcontext;
       
        public static ExtentReports extent;
        public static ExtentTest test;
        public static IWebDriver driver;
        public static EventFiringWebDriver eventFiringWebDriver;


        public WebDriverUtilities Wd_util=new WebDriverUtilities();
        public CShapUtilities cs_util = new CShapUtilities();
        public DataBaseUtilities dB_util = new DataBaseUtilities();
        public ExcelUtilities excel_util = new ExcelUtilities();

    
     
     
        [AssemblyInitialize]
        
        public static void ClassInitialize(TestContext context)
        {
             
           
            _testcontext = context;
            string Url = context.Properties["Url"].ToString();

           string Browser = context.Properties["Browser"].ToString();

           if (Browser.Equals("Chrome"))
            driver = new ChromeDriver(); 

            else if (Browser.Equals("firefox"))
            driver = new FirefoxDriver();

            Console.WriteLine("Open browser ");
            eventFiringWebDriver = new CustomEventFiringHandler(driver);
            driver = eventFiringWebDriver;

            driver.Navigate().GoToUrl(Url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Manage().Window.Maximize();
           

            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\yusuf\source\repos\C_Sharp_Selenium\C_Sharp_Selenium\Repo\MyTestReport.html");        
            extent.AttachReporter(htmlReporter);
          

        }



        [TestInitialize]
         public  void logIn()
         {
            
            String username =_testcontext.Properties["username"].ToString();
            String password =_testcontext.Properties["password"].ToString();
            
            LogInPage logInPage=new LogInPage(driver);
            logInPage.SetLogIn(username,password);
            Console.WriteLine("login to app");
           
         //  test.Log(Status.Info, _testcontext.TestName.ToString());
           

        }

       

        [TestCleanup]
        public void logOut()
        {
           
            HomePage homePage =new HomePage(driver);
            homePage.getLogOut().Click();
            Console.WriteLine("logout");
           test = extent.CreateTest(_testcontext.TestName.ToString());
            if (_testcontext.CurrentTestOutcome == UnitTestOutcome.Passed)
            {
                
              
                test.Log(Status.Pass);
                test.Log(Status.Info, _testcontext.CurrentTestOutcome.ToString());
            }
            



        }

        [AssemblyCleanup]
        public static void CloseBrowser()
        {
           

            driver.Quit();
            extent.Flush();
            Console.WriteLine("close the browser");



        }

    }
}
