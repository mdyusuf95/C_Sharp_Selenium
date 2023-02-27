using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Selenium.Main.Genric
{
    internal class CustomEventFiringHandler : EventFiringWebDriver
    {
        public CustomEventFiringHandler(IWebDriver parentDriver) : base(parentDriver)
        {
            Console.WriteLine("initialiesd");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override void Dispose(bool disposing)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnElementClicked(WebElementEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnElementClicking(WebElementEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnElementValueChanged(WebElementValueEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnElementValueChanging(WebElementValueEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnException(WebDriverExceptionEventArgs e)
        {
            Console.WriteLine("hiiii");
            
        }

        protected override void OnFindElementCompleted(FindElementEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnFindingElement(FindElementEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnNavigated(WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnNavigatedBack(WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnNavigatedForward(WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnNavigating(WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnNavigatingBack(WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnNavigatingForward(WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnScriptExecuted(WebDriverScriptEventArgs e)
        {
            Console.WriteLine("hiiii");
        }

        protected override void OnScriptExecuting(WebDriverScriptEventArgs e)
        {
            Console.WriteLine("hiiii");
        }
    }
}
