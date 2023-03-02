
using AventStack.ExtentReports.Core;
using AventStack.ExtentReports.Model;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Selenium.Main.Genric
{
    public class MyTestListener : ITestLogger
    {
        public void Initialize(TestLoggerEvents events, string testRunDirectory)
        {
            if(events.Equals("Pass"))
                Console.WriteLine("hi");
            Console.WriteLine(testRunDirectory);
        }
    }
}
