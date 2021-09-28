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
using System.Threading;

namespace MarsFramework.Pages
{
    class SentRequest
    {
        public SentRequest()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[2]/div/a[2]/button")]
        private IWebElement signoutbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section[1]/div/a[2]")]
        private IWebElement profileBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]")]
        private IWebElement managerebtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]/div/a[2]")]
        private IWebElement sentreqbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[3]/td[8]/button")]
        private IWebElement reviewbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[2]/div/div[3]/button")]
        private IWebElement closebtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div[1]/input")]
        private IWebElement serchskillbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/section/div/div[1]/div[1]/div/a[9]")]
        private IWebElement funlifestylebtn { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/section/div/div[1]/div[5]/button[1]")]
        private IWebElement onlinebtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/div[1]/a[2]/p")]
        private IWebElement ddbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[3]")]
        private IWebElement reqbtn { get; set; }
        [FindsBy(How =How.XPath,Using = "/html/body/div[4]/div/div[3]/button[1]")]
        private IWebElement ybtn { get; set; }

        internal void sentreq()
        {
            
            wait(5);
            signoutbtn.Click();
            ExcelLib.PopulateInCollection(ExcelPath, "SignIn");
            driver.Navigate().GoToUrl(ExcelLib.ReadData(5, "Url"));

            SignIntab.Click();
            Email.SendKeys(ExcelLib.ReadData(5, "UserName"));
            Password.SendKeys(ExcelLib.ReadData(5, "Password"));
            LoginBtn.Click();
            wait(10);
            
            ExcelLib.PopulateInCollection(ExcelPath, "SentRequest");
            wait(10);
            
            //reviewbtn.Click();
            //wait(5);
            //closebtn.Click();
            //wait(10);
            
            //wait(5);
            serchskillbtn.SendKeys(ExcelLib.ReadData(2, "SentRequest"));
            serchskillbtn.SendKeys(Keys.Enter);
            wait(5);
            funlifestylebtn.Click();
            wait(10);
            onlinebtn.Click();
            wait(10);
            ddbtn.Click();
            wait(10);
            reqbtn.Click();
            wait(10);
            ybtn.Click();
            wait(10);
            driver.Navigate().Refresh();
            Thread.Sleep(1000);
            profileBtn.Click();
            wait(10);
            managerebtn.Click();
            Thread.Sleep(1000);
            sentreqbtn.Click();

            wait(10);

            IWebElement sr = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/table/tbody/tr[1]/td[2]/a"));
            validate("Sent Request", (ExcelLib.ReadData(2, "SentRequest")), sr);





        }












    }
}
