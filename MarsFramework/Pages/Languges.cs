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

namespace MarsFramework.Pages
{
    class Languges
    {
        public Languges()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);


        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")]
        private IWebElement createlanguge { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement addnew { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        private IWebElement addlang { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        private IWebElement languagelevel { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement savelanguage { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i")]
        private IWebElement editlang { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")]
        private IWebElement editlan { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]")]
        private IWebElement updatebtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]")]
        private IWebElement deletelan { get; set; }

        internal void addlanguage()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Language");
            wait(5);
            createlanguge.Click();
            addnew.Click();
            addlang.SendKeys(ExcelLib.ReadData(2, "Language"));
            var l1 = new SelectElement(languagelevel);
            l1.SelectByValue(ExcelLib.ReadData(2,"Level"));
            savelanguage.Click();
            try
            {
                Base.test = Base.extent.StartTest("add language");
                wait(5);
                String Expectedvalue = ExcelLib.ReadData(2, "Language");
                wait(10);
                string Actualvalue = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
                if (Expectedvalue == Actualvalue)
                {
                    Base.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(driver, "language added");
                }
                else
                    Base.test.Log(LogStatus.Fail, "Test fail");

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail,"test fail", e.Message);


            }


        }
        internal void editlanguage()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Language");
            wait(5);
            editlang.Click();
            editlan.Clear();
            editlan.SendKeys(ExcelLib.ReadData(8, "Language"));
            wait(5);
            updatebtn.Click();
            driver.Navigate().Refresh();
            try
            {
                Base.test = Base.extent.StartTest("Edit Language");
                wait(5);
                String Expectedvalue = ExcelLib.ReadData(8, "Language");
                wait(10);
                String Actualvalue = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]")).Text;
                if (Expectedvalue == Actualvalue)
                {
                    Base.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(driver, "language updated");

                }
                else
                    Base.test.Log(LogStatus.Fail, "Test fail");

            }
            catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test fail", e.Message);

            }
            

        }
        internal void languagedel()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Language");
            wait(5);
            deletelan.Click();
            driver.Navigate().Refresh();
            
            try
            {

                Base.test = Base.extent.StartTest("Delete Language");
                String expectedvalue = ExcelLib.ReadData(8, "Language");
                String actualvalue = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]")).Text;
                if (expectedvalue != actualvalue)
                {
                    Base.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(driver, "Delete Language");

                }
                else
                    Base.test.Log(LogStatus.Fail, "Test fail");

            }
            catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, "test fail", e.Message);
            }
        }
    }
}

