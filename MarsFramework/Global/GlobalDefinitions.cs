﻿using Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace MarsFramework.Global
{
    class GlobalDefinitions
    {
        //Initialise the browser
        public static IWebDriver driver { get; set; }

        #region WaitforElement 

        public static void wait(int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

        }
        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        }
        #endregion
        #region RadioButton
        public static void radiobutton(String A, String B, String C, IWebElement D, IWebElement E)
        {
            if (A == B)
            {
                D.Click();

            }
            else if (A == C)
            {
                E.Click();
            }
            else
            {
                throw new ElementNotVisibleException("Element not found");
            }
        }
        #endregion

        #region validation
        public static void validate(String A, String B, IWebElement C)
        {
            try
            {
                Base.test = Base.extent.StartTest(A);
                wait(5);
                if (B == C.Text)
                {
                    Base.test.Log(LogStatus.Pass, "Test pass");
                    SaveScreenShotClass.SaveScreenshot(driver, A);
                }
                else
                    Base.test.Log(LogStatus.Fail, "Test fail");

            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Test fail", e.Message);
            }
        }
        #endregion
        #region Checkbox
        public static void checkbox(String A, string B, string C)
        {
            if (A == "Sun")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")).Click();
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")).SendKeys(B);
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input")).SendKeys(C);


            }

            else if (A == "Mon")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")).Click();
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input")).SendKeys(B);
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input")).SendKeys(C);

            }
            else if (A == "Tue")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")).Click();
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")).SendKeys(B);
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")).SendKeys(C);


            }
            else if(A=="Wed")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")).Click();
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[2]/input")).SendKeys(B);
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[3]/input")).SendKeys(C);
            }
            else if(A=="Thu")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input")).Click();
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input")).SendKeys(B);
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input")).SendKeys(C);
            }

            else if (A=="Fri")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[1]/div/input")).Click();
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[2]/input")).SendKeys(B);
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[3]/input")).SendKeys(C);
            }
            else if(A=="Sat")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")).Click();
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")).SendKeys(B);
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[3]/input")).SendKeys(C);
            }
            else
            {
                throw new ElementNotVisibleException("select correct day");
            }
        }


        #endregion

        #region clear checklist
        public static void clearcheckbox(String A)
        {
            if (A == "Sun")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input")).Click();
                


            }

            else if (A == "Mon")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")).Click();
                

            }
            else if (A == "Tue")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")).Click();
                

            }
            else if (A == "Wed")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")).Click();
               }
            else if (A == "Thu")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[6]/div[1]/div/input")).Click();
               }

            else if (A == "Fri")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[7]/div[1]/div/input")).Click();
               }
            else if (A == "Sat")
            {
                driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")).Click();
               }
            else
            {
                throw new ElementNotVisibleException("select correct day");
            }
        }
        #endregion
        #region elementpresent
        public static bool isElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        #endregion
        #region Excel 
        public class ExcelLib
        {
            static List<Datacollection> dataCol = new List<Datacollection>();

            public class Datacollection
            {
                public int rowNumber { get; set; }
                public string colName { get; set; }
                public string colValue { get; set; }
            }


            public static void ClearData()
            {
                dataCol.Clear();
            }


            private static DataTable ExcelToDataTable(string fileName, string SheetName)
            {
                // Open file and return as Stream
                using (System.IO.FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                    {
                        excelReader.IsFirstRowAsColumnNames = true;

                        //Return as dataset
                        DataSet result = excelReader.AsDataSet();
                        //Get all the tables
                        DataTableCollection table = result.Tables;

                        // store it in data table
                        DataTable resultTable = table[SheetName];

                        //excelReader.Dispose();
                        //excelReader.Close();
                        // return
                        return resultTable;
                    }
                }
            }

            public static string ReadData(int rowNumber, string columnName)
            {
                try
                {
                    //Retriving Data using LINQ to reduce much of iterations

                    rowNumber = rowNumber - 1;
                    string data = (from colData in dataCol
                                   where colData.colName == columnName && colData.rowNumber == rowNumber
                                   select colData.colValue).SingleOrDefault();

                    //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;


                    return data.ToString();
                }

                catch (Exception e)
                {
                    
                    Console.WriteLine("Exception occurred in ExcelLib Class ReadData Method!" + Environment.NewLine + e.Message.ToString());
                    return null;
                }
            }

            public static void PopulateInCollection(string fileName, string SheetName)
            {
                ExcelLib.ClearData();
                DataTable table = ExcelToDataTable(fileName, SheetName);

                //Iterate through the rows and columns of the Table
                for (int row = 1; row <= table.Rows.Count; row++)
                {
                    for (int col = 0; col < table.Columns.Count; col++)
                    {
                        Datacollection dtTable = new Datacollection()
                        {
                            rowNumber = row,
                            colName = table.Columns[col].ColumnName,
                            colValue = table.Rows[row - 1][col].ToString()
                        };


                        //Add all the details for each row
                        dataCol.Add(dtTable);

                    }
                }

            }
        }

        #endregion

        #region screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (Base.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }
        #endregion


    }



}

