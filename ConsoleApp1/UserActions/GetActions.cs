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
using ReportingUtility;
using System.Diagnostics;

namespace UserActions
{
    public static class GetActions
    {
        


        public static bool VerifyIfElementIsPresent(IWebDriver driver, PropertyName propertyName, IWebElement element)
        {
            if (InitialAssertion.ifElementIsAvailable(element) == true)
            {
                SeleniumReporting.WriteResults(true, "Type Text");
                return true;
            }
            else
            {
                SeleniumReporting.WriteResults(false, "TypeText");
                return false;
            }
        }

        //To Get Text from a Text box
        public static string GetText(PropertyName elementProperty, string element)
        {
            if (elementProperty == PropertyName.Id)            
                return PropertyCollection.Driver.FindElement(By.Id(element)).GetAttribute("value");           
            if (elementProperty == PropertyName.Name)           
                return PropertyCollection.Driver.FindElement(By.Name(element)).GetAttribute("value");            
            else            
                return String.Empty;            
        }
        //To Get Text from a DropDown List
        public static string GetTextDDL( PropertyName elementProperty, string element)
        {
            if (elementProperty == PropertyName.Id)
                return new SelectElement(PropertyCollection.Driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementProperty == PropertyName.Name)
                return new SelectElement(PropertyCollection.Driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else
                return String.Empty;
        }

        //**************Custom Library Methods*****************
        //To Get Text from a Text box
        public static string GetTxt(IWebElement element)
        {
                return element.GetAttribute("value");
        }
        //To Get selected Text from a DropDownList
        public static string GetTxtDDL(IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }
        //************************************************************

        //**************Extended Library method*****************
        //To Get Text from a Text box
        public static string ExtendedGetTxt(this IWebElement element)
        {
            if (InitialAssertion.IfElementIsVisible(element) == true)
            {
                return element.GetAttribute("value");
                //SeleniumReporting.WriteResults(true, element.GetAttribute("value"));
                //return true;
            }
            else
            {
                return String.Empty;
            }

        }
        //To Get selected Text from a DropDownList
        public static string ExtendedGetTxtDDL(this IWebElement element)
        {
            if (InitialAssertion.IfElementIsVisible(element) == true)
            {
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
            }
            else
            {
                return String.Empty;
            }

        }
        //To Get Text from a Text box
        public static bool ExtendedCompareTxt(this IWebElement element,string SearchString)
        {
            if (ExtendedGetTxt(element).Contains(SearchString)==true)
            {
                //Console.WriteLine("Text available in the UI : " + ExtendedGetTxt(element));
                SeleniumReporting.WriteResults(true,"Compare Text : '"+SearchString+"' with '"+ ExtendedGetTxt(element) + "'");
                return true;
            }
            else
            {
                SeleniumReporting.WriteResults(false, "Compare Text : '" + SearchString + "' with '" + ExtendedGetTxt(element) + "'");
                return false;   
            }

        }
        //To Compare value from a cell with the searchstring
        public static bool ExtendedCellTextCopare(this IWebElement element, string SearchString, int RowNumber, string ColumnName)
        {
            string UIValue = TableDataUtility.ReadCellData(RowNumber, ColumnName);
            if (InitialAssertion.IfElementIsVisible(element)==true && UIValue ==SearchString)
            {
                //Console.WriteLine("Text available in the UI : " + ExtendedGetTxt(element));
                SeleniumReporting.WriteResults(true, "Compare Text : '" + SearchString + "' with '" + UIValue + "'");
                return true;
            }
            else
            {
                SeleniumReporting.WriteResults(false, "Compare Text : '" + SearchString + "' with '" + UIValue + "'");
                return false;
            }

        }
        public static string GetMyMethodName()
        {
            var strackTrace = new StackTrace(new StackFrame(1));
            return strackTrace.GetFrame(0).GetMethod().Name;

        }

        public static string GetInnerText(string path)
        {
            return PropertyCollection.Driver.FindElement(By.XPath(path)).GetAttribute("innerText");
        }

        //To Get the current date and time as file name
        public static string GetFileName(string AppConfigPath,string FileExtension)
        {
            return System.Configuration.ConfigurationManager.AppSettings[AppConfigPath] + DateTime.Now.ToString("yyyy-dd-MM--HH-mm-ss") + FileExtension;
        }

        //************************************************************


     
    }
}
