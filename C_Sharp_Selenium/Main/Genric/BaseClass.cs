

//[assembly:Parallelize(Workers =1,Scope =ExecutionScope.ClassLevel)]




using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using C_Sharp_Selenium.Main.ObjectRepositry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System;

namespace C_Sharp_Selenium.Main.Genric
{
    [TestClass]
    public abstract  class BaseClass
    {
        public static IWebDriver driver { get; set; }
        public static TestContext _testcontext { get; set; }
        public static  MyTestListener _testListener;
        public static  ExtentReports extent;
        public static ExtentTest test;
        public static MyTestListener testListener;
        public static EventFiringWebDriver eventFiringWebDriver { get; set; }


        public WebDriverUtilities Wd_util=new WebDriverUtilities();
        public CShapUtilities cs_util = new CShapUtilities();
        public DataBaseUtilities dB_util = new DataBaseUtilities();
        public ExcelUtilities excel_util = new ExcelUtilities();

     /// <summary>
     /// 
     /// </summary>
     
     /// <param name="myname"></param>
        [AssemblyInitialize]
        
        public static void ClassInitialize(TestContext context )
        {
            ChromeOptions options = new ChromeOptions();
           // options.AddArguments("headless");

            Console.WriteLine("Open browser ");
            _testcontext = context;
            String Url = context.Properties["Url"].ToString();
          
            driver =new ChromeDriver(/*options*/);
           
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            testListener = new MyTestListener();

            driver.Manage().Window.Maximize();
            eventFiringWebDriver = new CustomEventFiringHandler(driver);

            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\yusuf\source\repos\C_Sharp_Selenium\C_Sharp_Selenium\Repo\MyTestReport.html");
//            test.Log(Status.Info, context.TestName.ToString());
            extent.AttachReporter(htmlReporter);
            test = extent.CreateTest("Openbrowser");





        }



        [TestInitialize]
         public  void login()
         {
           
            String username =_testcontext.Properties["username"].ToString();
            String password =_testcontext.Properties["password"].ToString();
           // _testListener = new MyTestListener();
            LogInPage logInPage=new LogInPage(driver);
            logInPage.SetLogIn(username,password);
            Console.WriteLine("login to app");
          
            test.Log(Status.Info, _testcontext.TestName.ToString());


        }

        [TestCleanup]
        public void logOut()
        {
            String screenshotPath;
            String name;

            if (_testcontext.CurrentTestOutcome != UnitTestOutcome.Passed)
            {
                 name=_testcontext.TestName;
                screenshotPath = $"C:\\Users\\yusuf\\source\\repos\\C_Sharp_Selenium\\C_Sharp_Selenium\\ScreenShots\\{DateTime.Now:yyyy-MM-dd_HH-mm-ss}"+name+".png";
                ITakesScreenshot screenshot = (ITakesScreenshot)driver;
                 screenshot.GetScreenshot().SaveAsFile(screenshotPath);
                _testcontext.AddResultFile(screenshotPath);
                _testcontext.WriteLine("Screenshot:");

                test = extent.CreateTest(_testcontext.TestName);
                test.Log(Status.Fail);
                test.AddScreenCaptureFromPath($"C:\\Users\\yusuf\\source\\repos\\C_Sharp_Selenium\\C_Sharp_Selenium\\ScreenShots\\{DateTime.Now:yyyy-MM-dd_HH-mm-ss}" + _testcontext.TestName.ToString() + ".png");
                _testcontext.AddResultFile(screenshotPath);


            }
            else
            {
                test = extent.CreateTest(_testcontext.TestName);
                test.Log(Status.Pass);

            }



            HomePage homePage =new HomePage(driver);
            homePage.getLogOut().Click();
            Console.WriteLine("logout");
           

            //test.Log(Status.Info,_testcontext.CurrentTestOutcome.ToString);
            // Perform test steps here
           

        }

        [AssemblyCleanup]
        public static void CloseBrowser()
        {
            Console.WriteLine("close the browser");

            driver.Quit();
            extent.Flush();

        
            
        }

    }
}
