using ExcelUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainTest;
using System.Drawing.Imaging;
using UserActions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using Assertion;
using ReportingUtility;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace Assertion
{
    public class InitialAssertion
    {
        public static bool IfElementIsVisible(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static Boolean ifElementIsAvailable(IWebElement element)
        {
            bool success = false;
            try
            {
                // I've also used "if (data != null)" which hasn't worked either
                if (!element.Equals(null))
                {
                    Console.WriteLine("dsds");
                    return element.Displayed;
                    //SeleniumReporting.WriteResults(true, "Extended Type Text");

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return success;
        }

        public static Boolean ifElementIsPresent(IWebDriver driver, By by)
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


        public static Boolean ifElementIsPresentandVisible(string element)
        {

            try
            {
                //driver.FindElement(by);

                return PropertyCollection.Driver.FindElement(By.XPath(element)).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        /*  public static bool checkCountMatch(string element, string element2)
          {
              if (element == element2)
              {
                  return true;
              }
              else
              {
                  SeleniumReporting.WriteResults(false, "Verify Job Count Matches Row Count!  Unmatched Values Found!    ");
                  throw new Exception("Values Do Not Match!");
              }
          }
          */

        public static void WaitForElementLoad(By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(PropertyCollection.Driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }

            else
            {
                SeleniumReporting.WriteResults(false, "Element not found!");
                throw new Exception("Element not found!");
            }

        }

        public static void elementExist(By by)
        {
  
        }
    }


}
