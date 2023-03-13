using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Selenium.Main.Genric
{
    public  class WebDriverUtilities
    {

        /// <summary>
        /// this is usefull to go to page perticular page
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="Url"></param>
        public void GoToUrl(IWebDriver driver, String Url)
        {
            driver.Navigate().GoToUrl(Url);

        }

        /// <summary>
        ///  usefull for waite for findelement and find elememts
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="timeinseconds"></param>
        public void implicityWaites(IWebDriver driver, int timeinseconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeinseconds);

        }


       

        /// <summary>
        ///  this is usefull to accept the alert 
        /// </summary>
        /// <param name="driver"></param>
        public void AlertAcceptl(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();

        }

        /// <summary>
        /// this is usefull to Dismiss the alert 
        /// </summary>
        /// <param name="driver"></param>

        public static void AlertDissmiss(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Dismiss();

        }

        /// <summary>
        /// this method is usefull for to select dropdowpOption by Visibletext
        /// </summary>
        /// <param name="element"></param>
        /// <param name="visbletext"></param>
        public void SelectElements(IWebElement element, String visbletext)
        {
            string VisibleText = visbletext.Trim();
            SelectElement s = new SelectElement(element);
            s.SelectByText(VisibleText);
        }

        /// <summary>
        ///  this method is usefull for to select dropdowpOption by index
        /// </summary>
        /// <param name="element"></param>
        /// <param name="index"></param>
        public void SelectElements(IWebElement element, int index)
        {
            SelectElement s = new SelectElement(element);
            s.SelectByIndex(index);
        }


        /// <summary>
        ///  this method is usefull for to select dropdowpOption by Value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="element"></param>
        public void SelectElements(String value,IWebElement element)
        {
            SelectElement s = new SelectElement(element);
            s.SelectByValue(value);

        }

        /// <summary>
        ///  this method is usefull to swithto in to diff frames by using index value
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="index"></param>
        public void HandleFrames(IWebDriver driver, int index)
        {
            driver.SwitchTo().Frame(index);

        }

        /// <summary>
        /// this method is usefull to swithto in to diff frames by using frame element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        public void HandleFrames(IWebDriver driver, IWebElement element)
        {
            driver.SwitchTo().Frame(element);

        }

        /// <summary>
        /// this method is usefull to Movethe mouse cursor to perticular element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        public void MouseAction(IWebDriver driver, IWebElement element)
        {
            Actions a = new Actions(driver);
            a.MoveToElement(element);

        }

        /// <summary>
        /// this method is usefull to rigthClicking  on perticular element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="driver"></param>
        public void MouseAction( IWebElement element, IWebDriver driver)
        {
            Actions a = new Actions(driver);
            a.ContextClick(element);

        }

        /// <summary>
        /// this method is usefull to Swith to perticular window
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="window"></param>

        public void MouseAction(IWebDriver driver, String window)
        {
            driver.SwitchTo().Window(window);

        }

        /// <summary>
        ///  this method is usefull to handel disable elemntes setting the value of element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="value"></param>
        /// <param name="element"></param>
        public void HandleDisableElement(IWebDriver driver, String value, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
           // js.ExecuteScript("arguments[0].value='" + value + "'", element);
            js.ExecuteScript("document.getElementsByName('projectName').value=" + value + "");

        }

        /// <summary>
        ///  this method is usefull to click on disabled element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        public void JavaScripButtonClick(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", element);

        }

        public void ScrollUptoBottom(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");

        }
    }
}
