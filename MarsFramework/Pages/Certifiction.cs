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
    class Certifiction

    {
        public Certifiction()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        [FindsBy(How = How.LinkText,Using = "Certifications")]
        private IWebElement certi { get; set; }
        [FindsBy(How = How.XPath,Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement addnew { get; set; }
        [FindsBy(How = How.Name,Using = "certificationName")]
        private IWebElement cername { get; set; }
        [FindsBy(How = How.Name,Using = "certificationFrom")]
        private IWebElement certfrom { get; set; }
        [FindsBy(How =How.Name,Using = "certificationYear")]
        private IWebElement certiyear { get; set; }
        [FindsBy(How = How.XPath,Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")]
        private IWebElement ceradd { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i")]
        private IWebElement upcert { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        private IWebElement upacert { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i")]
        private IWebElement decer { get; set; }



        internal void addcertificate()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Certifications");
            wait(10);
            certi.Click();
            addnew.Click();
            cername.SendKeys(ExcelLib.ReadData(2, "Certificate"));
            certfrom.SendKeys(ExcelLib.ReadData(2, "From"));
            var y1 = new SelectElement(certiyear);
            y1.SelectByValue(ExcelLib.ReadData(2, "Year"));
            ceradd.Click();
            driver.Navigate().Refresh();
            wait(5);
            certi.Click();
            wait(5);
            IWebElement ce = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            validate("add certificate",(ExcelLib.ReadData(2, "Certificate")),ce);





        }
        internal void editcertification()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Certifications");
            wait(5);
            certi.Click();
            upcert.Click();
            cername.Clear();
            cername.SendKeys(ExcelLib.ReadData(5, "Certificate"));
            certfrom.Clear();
            certfrom.SendKeys(ExcelLib.ReadData(5, "From"));
            var y1 = new SelectElement(certiyear);
            y1.SelectByValue(ExcelLib.ReadData(5, "Year"));
            upacert.Click();
            driver.Navigate().Refresh();
            wait(5);
            certi.Click();
            wait(5);
            IWebElement ece = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            validate("edit certificate", (ExcelLib.ReadData(5, "Certificate")), ece);


        }
        internal void deletecertificaate()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Certifications");
            wait(10);
            certi.Click();
            decer.Click();
            Base.test = Base.extent.StartTest("Delete Certifiction");
            Base.test.Log(LogStatus.Pass, "test pass");
            SaveScreenShotClass.SaveScreenshot(driver, "certificate delete");
        }
    }
}
