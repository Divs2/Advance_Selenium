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
    class EarnTarget
    {
        public EarnTarget()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        [FindsBy(How = How.Name, Using = "availabiltyTarget")]
        private IWebElement earntarget  { get; set; }
        [FindsBy(How = How.XPath,Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement etarget { get; set; }
         internal void Selectearntarget()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "EarnTarget");
            wait(10);
            etarget.Click();
            var t1 = new SelectElement(earntarget);
            t1.SelectByValue(ExcelLib.ReadData(2, "EarnTarget"));

            try
            {
                Base.test = Base.extent.StartTest("Select earn target");
                String Expectedvalue = ExcelLib.ReadData(3, "EarnTarget");
                String Actualvalue = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span")).Text;
                if (Expectedvalue == Actualvalue)
                {
                    Base.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(driver, "earn target selected");
                }
                else
                    Base.test.Log(LogStatus.Fail, "Test Fail");
            }
            catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test fail", e.Message);
            }

        }
}
    }

