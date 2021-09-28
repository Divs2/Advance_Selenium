using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;
using static MarsFramework.Global.Base;

namespace MarsFramework.Pages
{
    class Description
    {
        public Description()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        [FindsBy(How=How.XPath,Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        private IWebElement des { get; set; }
        [FindsBy(How =How.Name,Using = "value")]
        private IWebElement text { get; set; }
        [FindsBy(How = How.XPath,Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        private IWebElement sbtn { get; set; }
         
        internal void adddescription()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Description");
            wait(10);
            des.Click();
            wait(5);
            text.SendKeys(Keys.Control + "a");
            text.SendKeys(Keys.Backspace);
            
            text.SendKeys(ExcelLib.ReadData(2, "Description"));
            sbtn.Click();
            wait(10);
            IWebElement ed = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            validate("add description", (ExcelLib.ReadData(2, "Description")), ed);

        }
       
    }
}
