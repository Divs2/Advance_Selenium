using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.Base;
using OpenQA.Selenium.Support.UI;
using MarsFramework.Global;
using RelevantCodes.ExtentReports;
using System;

namespace MarsFramework.Pages
{
    internal class Availabilty
    {
        public Availabilty()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);


        }
        //Click on Availabilty
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement availabilty { get; set; }


        internal void selectavailabilty()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "availabilty");
            wait(5);
            IWebElement edava = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            edava.Click();
            var Ll = new SelectElement(availabilty);
            Ll.SelectByValue(ExcelLib.ReadData(2, "availabilty"));


            try
            {
                //Start report

                Base.test = Base.extent.StartTest("Select availabilty");
                string ExpectedValue = ExcelLib.ReadData(3, "availabilty");
                string ActualValue = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span")).Text;
                //check expected and actual value are same
                if (ExpectedValue == ActualValue)
                {
                    Base.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(driver, "availabilty Selected");



                }
                else

                    Base.test.Log(LogStatus.Fail, "Test fail");

            }
            catch (Exception e)

            {
                Base.test.Log(LogStatus.Fail, "Test fail", e.Message);

            }
        }

       

    }

    



    }    






