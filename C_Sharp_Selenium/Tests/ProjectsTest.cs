using Bytescout.Spreadsheet;
using C_Sharp_Selenium.Main.Genric;
using C_Sharp_Selenium.Main.ObjectRepositry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Selenium.Tests
{
    [TestClass]
    
    public  class ProjectsTest:BaseClass


    {
       
        public ProjectsPage projectsPage { get; set; }
         
        [DataTestMethod]
        [DynamicData(nameof(ExcelUtilities.GetExcelData),DynamicDataSourceType.Method)]
        public void Createprojet(String createdby,String Projectname,String Status,string teamsize )
        {
           
            HomePage home=new HomePage(driver);
            home.getProjects().Click();
            projectsPage = new ProjectsPage(driver);
            
            projectsPage.getProjectCreateBtn().Click();
            projectsPage.SetProject(driver,Projectname,teamsize,createdby,Status);
            Thread.Sleep(500);
            projectsPage.getAlertCloseeBtnOnAdd().Click();
     
            
        }

        [TestMethod]
        
        public void DeleteProjets()
        {

            HomePage home = new HomePage(driver);
            home.getProjects().Click();
            projectsPage = new ProjectsPage(driver);
            Wd_util.ScrollUptoBottom(driver);
            Thread.Sleep(5000);


            var deleteIcons = projectsPage.getDeleteIcon();
                int c = 0;
                foreach (var element in deleteIcons)
                {
                    element.Click();
                    projectsPage.getDelelteBtn().Click();
                    Thread.Sleep(500);

                    projectsPage.getAlertBtnOnDelete().Click();
                    projectsPage = new ProjectsPage(driver);
                   // Wd_util.ScrollUptoBottom(driver);
                }
           

        }

      

        public static IEnumerable<object[]> GetExcelData()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile("C:\\Users\\yusuf\\source\\repos\\C_Sharp_Selenium\\C_Sharp_Selenium\\TestData\\data1.xlsx");
            var ws = spreadsheet.Workbook.Worksheets["Sheet1"];
            int row = ws.UsedRangeRowMax;
            for (int i = 1; i <= row; i++)
            {
                string CreatedBy = ws.Cell(i, 0).ToString();
                string Project = ws.Cell(i, 1).ToString();
                string Status = ws.Cell(i, 2).ToString();
                string teamSize = ws.Cell(i, 3).ToString();

                yield return new object[] { CreatedBy, Project, Status, teamSize };
            }

        }
    }
}
