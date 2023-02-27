
using AventStack.ExtentReports.Core;
using AventStack.ExtentReports.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Selenium.Main.Genric
{
    public class MyTestListener : ITestListener
    {
        public void OnAuthorAssigned(Test test, Author author)
        {
            
        }

        public void OnCategoryAssigned(Test test, Category category)
        {
            
        }

        public void OnDeviceAssigned(Test test, Device device)
        {
            
        }

        public void OnLogAdded(Test test, Log log)
        {
           
        }

        public void OnNodeStarted(Test node)
        {
            
        }

        public void OnScreenCaptureAdded(Test test, ScreenCapture screenCapture)
        {
            
        }

        public void OnScreenCaptureAdded(Log log, ScreenCapture screenCapture)
        {
            
        }

        public void OnTestRemoved(Test test)
        {
            
        }

        public void OnTestStarted(Test test)
        {
            Console.WriteLine("OntestStarted");
        }
    }
}
