
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace C_Sharp_Selenium.Main.ObjectRepositry
{
    public  class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//a[.='Test Yantra']")]
        private IWebElement TestYantra { get; set; }


        [FindsBy(How = How.XPath, Using = ("//p[.='Menu']"))]
        private IWebElement Menu { get; set; }

        [FindsBy(How=How.XPath,Using =("//a[.='Home']"))]
        private IWebElement Home { get; set; }

        [FindsBy(How=How.XPath,Using = "//a[.='Projects']")]
        private IWebElement Projects { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.='Users']")]
        private IWebElement Users { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.='Settings']")]
        private IWebElement Settings { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[.='Logout']")]
        private IWebElement Logout { get; set; }


        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        public IWebElement getTestYantra()
        {
            return TestYantra;
        }

        public IWebElement getHome()
        {
            return Home;
        }

        public IWebElement getMenu()
        {
            return Menu;
        }

        public IWebElement getProjects()
        {
            return Projects;
        }

        public IWebElement getUsers()
        {
            return Users;
        }

        public IWebElement getSettings()
        {
            return Settings;
        }

        public IWebElement getLogOut()
        {
            return Logout;
        }


    }
}
