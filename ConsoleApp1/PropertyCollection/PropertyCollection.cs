using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainTest
{
    //Strongly Typed Parameters
    public enum PropertyName
    {
        Id,
        Name,
        Value,
        ClassName,
        LinkText,
        Xpath,
    }
    class PropertyCollection
    {
        //Auto Implemented Property
        public static IWebDriver Driver { get; set; }
        public static ExtentReports ExtentReports { get; set; }
        public static ExtentTest ExtentTest { get; set; }
        public static ExtentHtmlReporter HTMLReporter { get; set; }
        public static ExtentTest ChildTest { get; set; }

    }
}

