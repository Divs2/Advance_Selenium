using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.Base;
using MarsFramework.Global;
using RelevantCodes.ExtentReports;
using System.Threading;

namespace MarsFramework.Pages
{
    class ChangePassword
    {
        public ChangePassword()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/span")]
        private IWebElement prbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/span/div/a[2]")]
        private IWebElement cpwd { get; set; }
        [FindsBy(How = How.Name, Using = "oldPassword")]
        private IWebElement OP { get; set; }
        [FindsBy(How = How.Name, Using = "newPassword")]
        private IWebElement NP { get; set; }
        [FindsBy(How = How.Name, Using = "confirmPassword")]
        private IWebElement CP { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[4]/button")]
        private  IWebElement savebtn {get; set;}

        internal void changepwd()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "ChangePassword");
            wait(10);
            prbtn.Click();
            Thread.Sleep(5000);
            cpwd.Click();
            wait(5);
            OP.SendKeys(ExcelLib.ReadData(2, "Current Password"));
            wait(5);
            NP.SendKeys(ExcelLib.ReadData(2, "Password"));
            wait(5);
            CP.SendKeys(ExcelLib.ReadData(2, "Password"));
            wait(5);
            savebtn.Click();
            driver.Navigate().Refresh();
            Thread.Sleep(5000);

            prbtn.Click();
            Thread.Sleep(5000);
            cpwd.Click();
            wait(5);
            OP.SendKeys(ExcelLib.ReadData(2, "Password"));
            wait(5);
            NP.SendKeys(ExcelLib.ReadData(2, "Current Password"));
            wait(5);
            CP.SendKeys(ExcelLib.ReadData(2, "Current Password"));
            wait(5);
            savebtn.Click();


            Base.test = Base.extent.StartTest("Change Password");
            Base.test.Log(LogStatus.Pass, "test pass");
            SaveScreenShotClass.SaveScreenshot(driver, "Change Password");

        }
    }
}
