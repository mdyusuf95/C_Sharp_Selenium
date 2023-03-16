using AventStack.ExtentReports.Model;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
           
            BaseClass.test.Log(Status.Fail);
        }

       
    }
}
