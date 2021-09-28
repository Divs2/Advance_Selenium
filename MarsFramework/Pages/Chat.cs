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
    class Chat
    {
        public Chat()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        [FindsBy(How = How.XPath,Using = "/html/body/div[1]/div/div[1]/div[2]/div/a[1]")]
        private IWebElement chatbtn { get; set; }
         [FindsBy(How = How.XPath,Using = "/html/body/div/div/div/div[2]/div/div[2]/div/div/div/div/input")]
         private IWebElement chatmsg { get; set; }
        [FindsBy(How =How.XPath,Using = "/html/body/div/div/div/div[2]/div/div[2]/div/div/div/div/button[1]")]
        private IWebElement sebtn { get; set; }

        internal void chat()
        {
            ExcelLib.PopulateInCollection(ExcelPath, "Chat");
            wait(10);
            chatbtn.Click();
            wait(5);
            chatmsg.SendKeys(ExcelLib.ReadData(2, "Chat"));
            wait(5);
            sebtn.Click();
            wait(10);
            IWebElement cc = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div/div/span/div[4]/div/div/span"));
            validate("chat", (ExcelLib.ReadData(2, "Chat")), cc);
        }
    }
}
