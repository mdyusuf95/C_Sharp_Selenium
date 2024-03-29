﻿using C_Sharp_Selenium.Main.Genric;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;

namespace C_Sharp_Selenium.Main.ObjectRepositry
{
    public  class ProjectsPage
    {
        [FindsBy(How =How.XPath,Using = "//span[.='Create Project']")]
        private IWebElement ProjectCreateBtn { get; set; }

        [FindsBy(How = How.Name, Using = "projectName")]
        private IWebElement projectNameBox { get; set; }

        [FindsBy(How = How.Name, Using = "teamSize")]
        private IWebElement teamSizeBox { get; set; }

        [FindsBy(How = How.Name, Using = "createdBy")]
        private IWebElement projectManagerBox { get; set; }


        [FindsBy(How = How.XPath, Using = "(//select)[2]")]
        private IWebElement projectStatusDropDown { get; set; }

        [FindsBy(How =How.XPath,Using= "//input[@class='btn btn-success']")]
        private IWebElement submitBtn { get; set; }

        [FindsBy(How = How.XPath, Using = ("//a[@class='delete']/i"))]
        private IList<IWebElement> deleteIcon { get; set; }

        //input[@value='Delete']

        [FindsBy(How = How.XPath, Using = ("//input[@type='button' and @value='Delete']"))]
        private IWebElement deleteBtn { get; set; }

        [FindsBy(How = How.XPath, Using = ("//button[@class='Toastify__close-button Toastify__close-button--success']"))]
        private IWebElement alertCloseBtnOnAdd { get; set; }


        [FindsBy(How = How.XPath, Using = ("//button[@class='Toastify__close-button Toastify__close-button--success']"))]
        private IWebElement alertCloseBtnOnDelete { get; set; }



        public ProjectsPage()
        {
            PageFactory.InitElements(Utility.GetDriver(), this);
        }

        public IWebElement getProjectCreateBtn()
        {
            return ProjectCreateBtn;
        }

        public IWebElement getProjectnameBox()
        {
            return projectNameBox;
        }

        public IWebElement getteamSizeBox()
        {
            return teamSizeBox;
        }

        public IWebElement getprojectManagerBox()
        {
            return projectManagerBox;
        }

        public IWebElement getprojectStatusDropDown()
        {
            return projectStatusDropDown;
        }

        public IWebElement getSubmitBtn()
        {
            return submitBtn;
        }

        public IList<IWebElement> getDeleteIcon()
        {
            return deleteIcon;
        }

        public IWebElement getDelelteBtn()
        {
            return deleteBtn;
        }

        public IWebElement getAlertCloseeBtnOnAdd()
        {
            return alertCloseBtnOnAdd;
        }
        public IWebElement getAlertBtnOnDelete()
        {
            return alertCloseBtnOnDelete;
        }
        //input[@value='Delete']



        public void SetProject(String ProjecctNmae,String  TeamSize,String ProjectMannager,String ProjecctStatus)
        {
            
           
          int random=  Utility.GetCShapUtilities().RandomInteger(1000);
            projectNameBox.SendKeys(ProjecctNmae+random);
            Utility.GetWebDriverUtilities().HandleDisableElement( TeamSize, teamSizeBox);
            projectManagerBox.SendKeys(ProjectMannager);
   
            int random1= Utility.GetCShapUtilities().RandomInteger(3);
            Utility.GetWebDriverUtilities().SelectElements(projectStatusDropDown ,random1);
            submitBtn.Click();
           
            Utility.GetWebDriverUtilities().WaitUntilElementVisible( "//button[@class='Toastify__close-button Toastify__close-button--success']");
            alertCloseBtnOnAdd.Click();

        }

        public void DeleteAllProjects()
        {
            foreach(IWebElement ele in deleteIcon)
            {
                ele.Click();
                deleteBtn.Click();
            }
        }
    }
}
