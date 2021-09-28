using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    class Notification
    {
        public Notification()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/div")]
        private IWebElement notifi { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/div/div/span/div/div[2]/div/center/a")]
        private IWebElement seeall { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a")]
        private IWebElement loadmore { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input")]
        private IWebElement chk1 {get; set;}
        [FindsBy (How =How.XPath,Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[1]/div[3]")]
        private IWebElement delchk { get; set; }
        [FindsBy (How = How.XPath,Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[2]/div/div/div[3]/input")]

        private IWebElement chk2 { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[9]/div[1]/center/a")]

        private IWebElement showless { get; set; }


        internal void notification()
        {
            wait(10);
            notifi.Click();
            wait(10);
            seeall.Click();
            wait(10);
            loadmore.Click();
            wait(10);
            chk1.Click();
            wait(10);
            delchk.Click();
           
           
            Base.test = Base.extent.StartTest("Delete Notification");
            Base.test.Log(LogStatus.Pass, "test pass");
            SaveScreenShotClass.SaveScreenshot(driver, "Notification delete");





        }


    }
}
