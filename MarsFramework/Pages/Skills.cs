using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.Base;
using OpenQA.Selenium.Support.UI;
using MarsFramework.Global;
using RelevantCodes.ExtentReports;
using static NUnit.Core.NUnitFramework;

namespace MarsFramework.Pages
{
    class Skills
    {
        public Skills()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Skills")]
        private IWebElement skillbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement addnewbtn { get; set; }
        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement addskil { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement skilllevel { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")]
        private IWebElement addskills { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")]
        private IWebElement editskil { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        private IWebElement uptbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i")]
        private IWebElement deletebtn { get; set; }

        internal void addskill()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Skills");
            wait(5);
            skillbtn.Click();
            wait(5);
            addnewbtn.Click();
            addskil.SendKeys(ExcelLib.ReadData(2, "Skills"));
            var s1 = new SelectElement(skilllevel);
            s1.SelectByValue(ExcelLib.ReadData(2, "Levels"));
            addskills.Click();
            driver.Navigate().Refresh();
            skillbtn.Click();
            try
            {
                Base.test = Base.extent.StartTest("Skills Added");
                wait(5);
                String Expectedvalue = ExcelLib.ReadData(2, "Skills");
                wait(5);
                String actualvalue = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                if (Expectedvalue == actualvalue)
                {
                    Base.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(driver, "skill added");
                }

                else
                    Base.test.Log(LogStatus.Fail, "Test fail");

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "test fail", e.Message);

            }




           
        }
        internal void editskill()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Skills");
            wait(5);
            skillbtn.Click();
            editskil.Click();
            addskil.Clear();
            addskil.SendKeys(ExcelLib.ReadData(5, "Skills"));
            uptbtn.Click();
            driver.Navigate().Refresh();
            skillbtn.Click();
            IWebElement eskill = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            validate("Skill edit", (ExcelLib.ReadData(5, "Skills")),eskill);


        }

        internal void deleteskills()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Skills");
            wait(10);
            skillbtn.Click();
            deletebtn.Click();
            Base.test = Base.extent.StartTest("Delete Skill");
            Base.test.Log(LogStatus.Pass, "test pass");
            SaveScreenShotClass.SaveScreenshot(driver, "skill delete");
          

           
        }
    }
}
