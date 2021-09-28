using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MarsFramework.Global;
using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.Base;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;

namespace MarsFramework.Pages
{
    class Hours
    {
        public Hours()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

        }
      
       //Click on Hours
       [FindsBy(How = How.Name, Using = "availabiltyHour")]
       private IWebElement hours { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement Ehours { get; set; }
        internal void Selecthours()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Hours");
            wait(5);
            Ehours.Click();
            var h1 = new SelectElement(hours);
            h1.SelectByValue(ExcelLib.ReadData(2, "Hours"));

            try
            {
                Base.test = Base.extent.StartTest("select available hours");
                string Expectedvalue = ExcelLib.ReadData(3, "Hours");
                string Actualvalue = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span")).Text;
                if (Expectedvalue == Actualvalue)
                {
                    Base.test.Log(LogStatus.Pass, "Test Pass");
                    SaveScreenShotClass.SaveScreenshot(driver, "available Hours Selected");

                }
                else
                
                    Base.test.Log(LogStatus.Fail, "Test fail");
                }
                catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test fail", e.Message);

            }

        }
            
        }


    }

