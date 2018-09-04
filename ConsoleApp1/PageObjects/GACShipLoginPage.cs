using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainTest;
using UserActions;
using ExcelUtilities;
using Assertion;
using ReportingUtility;
using NUnit.Framework;

namespace PageObjects
{
    class GACShipLoginPage
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShipLoginPage()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }
        //FindsBy Attribute
        [FindsBy(How = How.Id, Using = "Username")]
        public IWebElement UserName { get; set; }

        //[FindsBy(How = How.Id, Using = ExcelLibrary.ReadDataTest("UserName","PropertyValues")]
        //public IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement PassWord { get; set; }

        [FindsBy(How = How.Id, Using = "btnSignIn")]
        public IWebElement LoginButton { get; set; }

        //Login Using Attributes
        public PurchaseOrderPageObjects GACtrackLogin(string strUserName, string strPassword)
        {
            UserName.SendKeys(strUserName);
            PassWord.SendKeys(strPassword);
            LoginButton.Click();
            Console.WriteLine("GACtrack Login completed successfully");

            //Return an Instance of Purchase Order page object
            return new PurchaseOrderPageObjects();
        }

    }
}
