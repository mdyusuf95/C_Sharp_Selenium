
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;


namespace C_Sharp_Selenium.Main.Genric
{
    internal class CustomEventFiringHandler : EventFiringWebDriver
    {    
        public CustomEventFiringHandler(IWebDriver parentDriver) : base(parentDriver)
        {
            
        }

        protected override void OnException(WebDriverExceptionEventArgs e)
        {
           string name= BaseClass._testcontext.TestName.ToString();

            string filePath = PathConstans.ScreenShotFile + name+ ".png";
            var SS = (ITakesScreenshot)e.Driver;
            SS.GetScreenshot().SaveAsFile(filePath);
            BaseClass. test = BaseClass.extent.CreateTest(BaseClass._testcontext.TestName);
           
            BaseClass.test.AddScreenCaptureFromPath(PathConstans.ScreenShotFile + name + ".png");
            BaseClass. _testcontext.AddResultFile(filePath);
            Console.WriteLine("Screen shot captchred");
           
            BaseClass.test.Log(Status.Fail,e.ToString());
        }

       
    }
}
