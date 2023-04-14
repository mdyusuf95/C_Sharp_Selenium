using Bytescout.Spreadsheet;
using C_Sharp_Selenium.Main.Genric;
using C_Sharp_Selenium.Main.ObjectRepositry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading;


namespace C_Sharp_Selenium.Tests
{
    [TestClass]
    
    public  class ProjectsTest:BaseClass


    {
       
        
         
        [DataTestMethod]
        [DynamicData(nameof(ExcelUtilities.GetExcelData),DynamicDataSourceType.Method)]
        public void Createprojet(String createdby,String Projectname,String Status,string teamsize )
        {


            homePage.getProjects().Click();
            projectsPage.getProjectCreateBtn().Click();
            projectsPage.SetProject(Projectname,teamsize,createdby,Status);
            
        }

        [TestMethod]
       
        public void DeleteProjets()
        {

           // HomePage home = new HomePage();
            homePage.getProjects().Click();
            Utility.GetWebDriverUtilities().ScrollUptoBottom();

            var deleteIcons = projectsPage.getDeleteIcon();
            DeleteProjets:
            try
            {
                foreach (var element in deleteIcons)
                {
                    element.Click();
                    projectsPage.getDelelteBtn().Click();
                    Thread.Sleep(500);
                    projectsPage.getAlertBtnOnDelete().Click();
                    

                }
            }
            catch(Exception e)
            {
                goto DeleteProjets;
            }
           

        }

      

        public static IEnumerable<object[]> GetExcelData()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(PathConstans.ExcelPath);
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
