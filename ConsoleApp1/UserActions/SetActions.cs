using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainTest;
using Assertion;
using NUnit.Framework;
using ReportingUtility;

namespace UserActions
{
    public static class SetActions
    {

        public static void FillInTextField(string Text, string element)
        {
            PropertyCollection.Driver.FindElement(By.XPath(element)).SendKeys(Text);
        }

        public static void ClickButton(string element, string ButtonName)
        {
            if (InitialAssertion.ifElementIsPresentandVisible(element) == true)
            {
                PropertyCollection.Driver.FindElement(By.XPath(element)).Click();
                SeleniumReporting.clickButton(true, ButtonName);
            }
            else
            {
                SeleniumReporting.clickButton(false, ButtonName);
            }
        }

        //**************************************************************
    }
}
