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

            string filePath = $"C:\\Users\\yusuf\\source\\repos\\C_Sharp_Selenium\\C_Sharp_Selenium\\ScreenShots\\{DateTime.Now:yyyy-MM-dd_HH-mm-ss}" + name+ ".png";
            var SS = (ITakesScreenshot)e.Driver;
            SS.GetScreenshot().SaveAsFile(filePath);
            BaseClass. test = BaseClass.extent.CreateTest(BaseClass._testcontext.TestName);
           
            BaseClass.test.AddScreenCaptureFromPath($"C:\\Users\\yusuf\\source\\repos\\C_Sharp_Selenium\\C_Sharp_Selenium\\ScreenShots\\{DateTime.Now:yyyy-MM-dd_HH-mm-ss}" + name + ".png");
            BaseClass. _testcontext.AddResultFile(filePath);
            Console.WriteLine("Screen shot captchred");
            BaseClass.test.Log(Status.Fail);
        }
    }
}
