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
    class Education
    {
        public Education()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Education")]
        private IWebElement edubtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement addedubtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement clgadd { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement clgcountry { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement degreetitle { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement degreenm { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement yearofgraduation { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement addedu { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i")]
        private IWebElement editedu { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input")]
        private IWebElement editclg { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select")]
        private IWebElement editclgcou { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select")]
        private IWebElement editdegtitle { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input")]
        private IWebElement eddegreenm { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select")]
        private IWebElement edyearofgrd { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]")]
        private IWebElement uptedu { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i")]
        private IWebElement deedu { get; set; }


        internal void addeducation()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Education");
            wait(10);
            edubtn.Click();

            addedubtn.Click();
            clgadd.SendKeys(ExcelLib.ReadData(2, "University"));
            var co1 = new SelectElement(clgcountry);
            co1.SelectByValue(ExcelLib.ReadData(2, "Country"));
            var dt1 = new SelectElement(degreetitle);
            dt1.SelectByValue(ExcelLib.ReadData(2, "Title"));

            degreenm.SendKeys(ExcelLib.ReadData(2, "Degree"));
            var ygrgua = new SelectElement(yearofgraduation);
            ygrgua.SelectByValue(ExcelLib.ReadData(2, "Graduation Year"));
            wait(5);
            addedu.Click();
            driver.Navigate().Refresh();
            wait(5);
            edubtn.Click();
            wait(5);
            IWebElement edu = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            validate("add education", (ExcelLib.ReadData(2, "University")), edu);
        }
        internal void editeducation()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Education");
            wait(10);
            edubtn.Click();
            editedu.Click();
            wait(5);    
            editclg.Clear();
            editclg.SendKeys(ExcelLib.ReadData(4, "University"));
            var co1 = new SelectElement(editclgcou);
            co1.SelectByValue(ExcelLib.ReadData(4, "Country"));
            var dt1 = new SelectElement(editdegtitle);
            dt1.SelectByValue(ExcelLib.ReadData(4, "Title"));
            eddegreenm.Clear();
            eddegreenm.SendKeys(ExcelLib.ReadData(4, "Degree"));
            var ygrgua = new SelectElement(edyearofgrd);
            ygrgua.SelectByValue(ExcelLib.ReadData(4, "Graduation Year"));
            wait(5);
            uptedu.Click();
            driver.Navigate().Refresh();
            edubtn.Click();
            wait(10);
            IWebElement ededu = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            validate("edit education", (ExcelLib.ReadData(4, "University")), ededu);


        }
        internal void deleteedu()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Education");
            wait(5);
            edubtn.Click();
            deedu.Click();
            Base.test = Base.extent.StartTest("Delete education");
            Base.test.Log(LogStatus.Pass, "test pass");
            SaveScreenShotClass.SaveScreenshot(driver, "education delete");


        }

    }

}