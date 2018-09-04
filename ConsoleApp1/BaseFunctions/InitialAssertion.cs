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
        public static bool IsAvailable(IWebElement element)
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

        public static Boolean ifElementIsPresent(IWebElement element)
        {
            bool success = false;
            try
            {
                // I've also used "if (data != null)" which hasn't worked either
                if (!element.Equals(null))
                {
                    return element.Displayed;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return success;
        }

        }
     }
