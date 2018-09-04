using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using MainTest;
using UserActions;
using ExcelUtilities;
using Assertion;
using ReportingUtility;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Xml;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;


namespace GACShip
{
    class TestSteps
    {


        public TestSteps()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//*******************************SANITY_STEPS*************************************************//

        public static void LaunchApplication()
        {

            PropertyCollection.ExtentTest = PropertyCollection.ExtentReports.CreateTest(TestContext.CurrentContext.Test.Name);
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            Excel excel = new Excel(@"C:\Users\edqu01\Documents\GAC Automation\GACShip Agent Automation - August-31\ConsoleApp1\TestData\GACShipTestData.xlsx", "LogIn");
            System.Threading.Thread.Sleep(2000);
            PropertyCollection.Driver = new ChromeDriver();
            PropertyCollection.Driver.Navigate().GoToUrl(excel.ReadDatabyColumnName("GACShip", "GACShipURL"));
            PropertyCollection.Driver.Manage().Window.Maximize();

            try
            {
                SeleniumReporting.WriteResults(true, "Browser Launch and Navigate to '" + excel.ReadDatabyColumnName("GACShip", "GACShipURL") + "'");
                excel.Close();
            }
            catch (NoSuchElementException)
            {
                SeleniumReporting.WriteResults(false, "Browser Launch and Navigate to '" + ExcelLibrary.ReadDataTest("GTUrl", "UserData") + "'");
                excel.Close();
            }


        }

        public static void VerifyLoginPageObjects()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LoginPage loginPage = new GACShip_Agent_LoginPage();
            InitialAssertion.WaitForElementLoad(By.XPath(loginPage.LoginPageLogoAndText), 30);


            //GACShip Logo Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.GACShipLogo))
            {
                SeleniumReporting.ElementPresentVerification(true, "GACSHip Logo");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "GACSHip Logo");

            //GACShip Text Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.GACShipText))
            {
                SeleniumReporting.ElementPresentVerification(true, "GACSHip Text");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "GACSHip Text");

            //Sign In Text Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.SignInText))
            {
                SeleniumReporting.ElementPresentVerification(true, "Sign In Text");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Sign In Text");

            //Global Hub Service Text Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.GlobalHubServiceText))
            {
                SeleniumReporting.ElementPresentVerification(true, "Global Hub Service Text");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Global Hub Service Text");

            //UserName Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.Username))
            {
                SeleniumReporting.ElementPresentVerification(true, "UserName");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "UserName");

            //PassWord Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.Password))
            {
                SeleniumReporting.ElementPresentVerification(true, "PassWord");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PassWord");

            //Terms Of Use Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.TermsOfUse))
            {
                SeleniumReporting.ElementPresentVerification(true, "Terms Of Use");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Terms Of Use");

            //Login Button Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.LogInButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Login Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Login Button");

            //Register Button Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.RegisterButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Register Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Register Button");

            //Quick Links Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.QuickLinks))
            {
                SeleniumReporting.ElementPresentVerification(true, "QuickLinks");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "QuickLinks");

            //GACLink Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.GACLink))
            {
                SeleniumReporting.ElementPresentVerification(true, "GACLink");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "GACLink");

            //Support Link Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.SupportLink))
            {
                SeleniumReporting.ElementPresentVerification(true, "Support Link");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Support Link");

            //Forgot Password Link Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.ForgotPasswordLink))
            {
                SeleniumReporting.ElementPresentVerification(true, "Forgot Password Link");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Forgot Password Link");

            //Paragraph Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.Paragraph))
            {
                SeleniumReporting.ElementPresentVerification(true, "Paragraph");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Paragraph");

            //Our Service Include Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.OurServiceInclude))
            {
                SeleniumReporting.ElementPresentVerification(true, "Our Service Include");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Our Service Include");

            //HUBAGENCY Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.HUBAGENCY))
            {
                SeleniumReporting.ElementPresentVerification(true, "HUBAGENCY");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "HUBAGENCY");

            //DAMANAGEMENT Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.DAMANAGEMENT))
            {
                SeleniumReporting.ElementPresentVerification(true, "DAMANAGEMENT");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "DAMANAGEMENT");

            //HUSBANDRY Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.HUSBANDRY))
            {
                SeleniumReporting.ElementPresentVerification(true, "HUSBANDRY");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "HUSBANDRY");

            //PORT ON DEMAND Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.PORTONDEMAND))
            {
                SeleniumReporting.ElementPresentVerification(true, "PORTONDEMAND");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PORTONDEMAND");

            //CENTRAL SERVICES Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(loginPage.CENTRALSERVICES))
            {
                SeleniumReporting.ElementPresentVerification(true, "CENTRALSERVICES");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "CENTRALSERVICES");

        }

        public static void GACShipLoginToApplication()
        {
            GACShip_Agent_LoginPage landingpage = new GACShip_Agent_LoginPage();
            landingpage.GACShipLoginToApplication();
            System.Threading.Thread.Sleep(5000);
        }

        public static void VerifyLandingPageObjects()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();

            //GACShipLogo Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuGACLogo))
            {
                SeleniumReporting.ElementPresentVerification(true, "GACSHip Logo");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "GACSHip Logo");

            //GACShipText Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuGACShipText))
            {
                SeleniumReporting.ElementPresentVerification(true, "GACSHip Text");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "GACSHip Text");

            //WelcomeNote Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.WelcomeNote))
            {
                SeleniumReporting.ElementPresentVerification(true, "Welcome Note");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Welcome Note");

            //MenuSearchTextField Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuSearchTextField))
            {
                SeleniumReporting.ElementPresentVerification(true, "Search Text Field");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Menu Search Text Field");

            //MenuSearchIcon Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuSearchIcon))
            {
                SeleniumReporting.ElementPresentVerification(true, "Menu Search Icon");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Menu Search Icon");

            //MenuButtonActionNeeded Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonActionNeeded))
            {
                SeleniumReporting.ElementPresentVerification(true, "Menu Button Action Needed");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Menu Button Action Needed");

            //MenuButtonSearch Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonSearch))
            {
                SeleniumReporting.ElementPresentVerification(true, "Menu Button Search");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Menu Button Search");

            //MenuButtonBankRemit Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonBankRemit))
            {
                SeleniumReporting.ElementPresentVerification(true, "Menu Button Bank Remit");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Menu Button Bank Remit");

            //TableHeaderActionNeededLinkButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.TableHeaderActionNeededLinkButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Table Header Action Needed Link Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Table Header Action Needed Link Button");

            //TableHeaderJobCount Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.TableHeaderJobCount))
            {
                SeleniumReporting.ElementPresentVerification(true, "Table Header Job Count");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Verify Table Header Job Count");

            //ActionNeededTableAcknowledgemntRequired Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ActionNeededTableAcknowledgemntRequired))
            {
                SeleniumReporting.ElementPresentVerification(true, "Action Needed TableAcknowledgemnt Required");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Action Needed Table Acknowledgemnt Required");

            //ActionNeededTableProformaRequired Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ActionNeededTableProformaRequired))
            {
                SeleniumReporting.ElementPresentVerification(true, "Action Needed Table Proforma Required");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Action Needed Table Proforma Required");

            //ActionNeededTableSOFRequired Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ActionNeededTableSOFRequired))
            {
                SeleniumReporting.ElementPresentVerification(true, "Action Needed Table SOF Required");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Action Needed Table SOF Required ");

            //ActionNeededTableFinalDARequired Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ActionNeededTableFinalDARequired))
            {
                SeleniumReporting.ElementPresentVerification(true, "Action Needed Table Final DA Required");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Action Needed Table Final DA Required ");

            //ExpandAcknowldegementRequired Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ExpandAcknowldegementRequired))
            {
                SeleniumReporting.ElementPresentVerification(true, "Acknowldegement Required Expand Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Acknowldegement Required Expand Button");

            //ExpandProformaRequired Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ExpandProformaRequired))
            {
                SeleniumReporting.ElementPresentVerification(true, "Proforma Required Expand Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Proforma Required Expand Button");

            //ExpandSOFRequired Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ExpandSOFRequired))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Required Expand Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Required Expand Button");


            //ExpandFinalDARequired Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ExpandFinalDARequired))
            {
                SeleniumReporting.ElementPresentVerification(true, "Final DA Required Expand Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Final DA Required Expand Button");

            //AcknowledgementRequiredHeader Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcknowledgementRequiredHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Acknowledgement Required Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Acknowledgement Required Header");

            //ProformaRequiredHeader Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ProformaRequiredHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Proforma Required Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Proforma Required Header");

            //SOFRequiredHeader Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFRequiredHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Required Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Required Header");

            //FinalDARequiredHeader Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.FinalDARequiredHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Final DA Required Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Final DA Required Header");


            //landingpage.ExpandAcknowldegementRequired.Click();
            SetActions.ClickButton(landingpage.ExpandAcknowldegementRequired, "Expand Acknowledment Required");
            //AcknowledgementRequiredJobNumber Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcknowledgementRequiredJobNumber))
            {
                SeleniumReporting.ElementPresentVerification(true, "Acknowledgement Required Job Number");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Acknowledgement Required Job Number");

            //AcknowledgementRequiredVessel Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcknowledgementRequiredVessel))
            {
                SeleniumReporting.ElementPresentVerification(true, "Acknowledgement Required Vessel");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Acknowledgement Required Vessel");

            //AcknowledgementRequiredPort Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcknowledgementRequiredPort))
            {
                SeleniumReporting.ElementPresentVerification(true, "Acknowledgement Required Port");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Acknowledgement Required Port");


            //AcknowledgementRequiredETA Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcknowledgementRequiredETA))
            {
                SeleniumReporting.ElementPresentVerification(true, "Acknowledgement Required ETA");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Acknowledgement Required ETA");

            //AcknowledgementRequiredPrincipal Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcknowledgementRequiredPrincipal))
            {
                SeleniumReporting.ElementPresentVerification(true, "Acknowledgement Required Principal");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Acknowledgement Required Principal");


            //AcknowledgementRequiredStatus Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcknowledgementRequiredStatus))
            {
                SeleniumReporting.ElementPresentVerification(true, "Acknowledgement Required Status");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Acknowledgement Required Status");


            //landingpage.ExpandProformaRequired.Click();
            SetActions.ClickButton(landingpage.ExpandProformaRequired, "Expand Proforma Required");
            //ProformaRequiredJobNumber Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ProformaRequiredJobNumber))
            {
                SeleniumReporting.ElementPresentVerification(true, "Proforma Required Job Number");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Proforma Required Job Number");

            //ProformaRequiredVessel Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ProformaRequiredVessel))
            {
                SeleniumReporting.ElementPresentVerification(true, "Proforma Required Vessel");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Proforma Required Vessel");

            //ProformaRequiredPort Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ProformaRequiredPort))
            {
                SeleniumReporting.ElementPresentVerification(true, "Proforma Required Port");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Proforma Required Port");

            //ProformaRequiredETA Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ProformaRequiredETA))
            {
                SeleniumReporting.ElementPresentVerification(true, "Proforma Required ETA");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Verify Proforma Required ETA");

            //ProformaRequiredPrincipal Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ProformaRequiredPrincipal))
            {
                SeleniumReporting.ElementPresentVerification(true, "Proforma Required Principal");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Verify Proforma Required Principal");

            //ProformaRequiredStatus Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ProformaRequiredStatus))
            {
                SeleniumReporting.ElementPresentVerification(true, "Proforma Required Status");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Proforma Required Status");


            //landingpage.ExpandSOFRequired.Click();
            SetActions.ClickButton(landingpage.ExpandSOFRequired, "Expand SOF Required");
            //SOFRequiredJobNumber Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFRequiredJobNumber))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Required Job Number");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Required Job Number");


            //SOFRequiredVessel Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFRequiredVessel))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Required Vessel");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Required Vessel");

            //SOFRequiredPort Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFRequiredPort))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Required Port");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Required Port");

            //SOFRequiredETA Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFRequiredETA))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Required ETA");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Required ETA");

            //SOFRequiredPrincipal Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFRequiredPrincipal))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Required Principal");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Required Principal");

            //SOFRequiredStatus Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFRequiredStatus))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Required Status");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Required Status");


            //landingpage.ExpandFinalDARequired.Click();
            SetActions.ClickButton(landingpage.ExpandFinalDARequired, "Expand Final DA Required");
            //FDARequiredJobNumber Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.FDARequiredJobNumber))
            {
                SeleniumReporting.ElementPresentVerification(true, "FDA Required Job Number");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "FDA Required Job Number");

            //FDARequiredVessel Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.FDARequiredVessel))
            {
                SeleniumReporting.ElementPresentVerification(true, "FDA Required Vessel");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "FDA Required Vessel");

            //FDARequiredPort Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.FDARequiredPort))
            {
                SeleniumReporting.ElementPresentVerification(true, "FDA Required Port");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "FDA Required Port");

            //FDARequiredETA Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.FDARequiredETA))
            {
                SeleniumReporting.ElementPresentVerification(true, "FDA Required ETA");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "FDA Required ETA");

            //FDARequiredPrincipal Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.FDARequiredPrincipal))
            {
                SeleniumReporting.ElementPresentVerification(true, "FDA Required Principal");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "FDA Required Principal");

            //FDARequiredStatus Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.FDARequiredStatus))
            {
                SeleniumReporting.ElementPresentVerification(true, "FDA Required Status");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "FDA Required Status");

        }

        public static void ClickExpandAcknowledgementRequiredButton()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(landingpage.ExpandAcknowldegementRequired, "Expand");
        }

        public static void ClickExpandProformaRequiredButton()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            //landingpage.ExpandProformaRequired.ClickButton("Expand");
            SetActions.ClickButton(landingpage.ExpandProformaRequired, "Expand");
        }

        public static void ClickExpandSOFRequiredButton()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            //landingpage.ExpandSOFRequired.ClickButton("Expand");
            SetActions.ClickButton(landingpage.ExpandSOFRequired, "Expand");
        }

        public static void ClickExpandFDARequiredButton()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            //landingpage.ExpandFinalDARequired.ClickButton("Expand");
            SetActions.ClickButton(landingpage.ExpandFinalDARequired, "Expand");
        }

        public static void VerifyAcknowledgementRequiredJobCount()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();


            //string JobCount = landingPage.AcknowledgementRequiredJobCount.GetAttribute("innerText");
            String JobCount = GetActions.GetInnerText(landingPage.AcknowledgementRequiredJobCount);


            //Verify Job Count in the Acknowledgement Required
            if (InitialAssertion.ifElementIsPresentandVisible(landingPage.AcknowledgementRequiredJobCount))
            {
                SeleniumReporting.WriteResults(true, "Acknowledgement Required Job Count :  " + JobCount + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify Acknowledgement Required Job Count Existence!  ");

            int Rows = 0;
            string Status = "//span[contains(.,'Nominated by Hub')]";
            Rows = PropertyCollection.Driver.FindElements(By.XPath(Status)).Count();

            //Verify Row Count in the Acknowledgement Required
            if (InitialAssertion.ifElementIsPresentandVisible(landingPage.AcknowledgementRequiredJobCount))
            {
                SeleniumReporting.WriteResults(true, "Acknowledgement Required Row Count :  " + Rows + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify Acknowledgement Required Row Count Existence!  ");

            //Verify Job Count Matches Row Count in the Acknowledgement Required
            string RowCount = Rows.ToString();
            if (JobCount == RowCount)
            {
                SeleniumReporting.WriteResults(true, "Acknowledgement Required Job Count Matches Row Count   " + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify Job Count Matches Row Count!  Unmatched Values Found!    ");

        }

        public static void VerifyProformaRequiredJobCount()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();


            //string JobCount = landingPage.ProformaRequiredJobCount.GetAttribute("innerText");
            String JobCount = GetActions.GetInnerText(landingPage.ProformaRequiredJobCount);


            //Verify Job Count in the Proforma Required
            if (InitialAssertion.ifElementIsPresentandVisible(landingPage.ProformaRequiredJobCount))
            {
                SeleniumReporting.WriteResults(true, "Proforma Required Job Count :  " + JobCount + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify Proforma Required Job Count Existence!  ");

            int Rows = 0;
            string Status = "//span[contains(.,'Acknowledged by PA')]";
            Rows = PropertyCollection.Driver.FindElements(By.XPath(Status)).Count();

        

            //Verify Row Count in the Proforma Required
            if (InitialAssertion.ifElementIsPresentandVisible(landingPage.ProformaRequiredJobCount))
            {
                SeleniumReporting.WriteResults(true, "Proforma Required Row Count :  " + Rows + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify Proforma Required Row Count Existence!  ");


            //Verify Job Count Matches Row Count in the Proforma Required
            string RowCount = Rows.ToString();
            Console.WriteLine(RowCount);
            Console.WriteLine(JobCount);
            if (JobCount == RowCount)
            {
                SeleniumReporting.WriteResults(true, "Proforma Required Job Count Matches Row Count   " + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify Job Count Matches Row Count!  Unmatched Values Found!    ");

        }

        public static void VerifySOFRequiredJobCount()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();

            String JobCount = GetActions.GetInnerText(landingPage.SOFRequiredJobCount);

            //Verify Job Count in the Proforma Required
            if (InitialAssertion.ifElementIsPresentandVisible(landingPage.SOFRequiredJobCount))
            {
                SeleniumReporting.WriteResults(true, "SOF Required Job Count :  " + JobCount + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify SOF Required Job Count Existence!  ");


            int Rows = 0;
            string Status = "//td/span[contains(.,'Proforma Submitted')]/preceding::tr[@class='k-alt action-grid-first-row']/preceding-sibling::tr//td/div[contains(.,'SOF Required')]";
            Rows = PropertyCollection.Driver.FindElements(By.XPath(Status)).Count();

            //Verify Row Count in the Proforma Required
            if (InitialAssertion.ifElementIsPresentandVisible(landingPage.SOFRequiredJobCount))
            {
                SeleniumReporting.WriteResults(true, "SOF Required Row Count :  " + Rows + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify SOF Required Row Count Existence!  ");

            //Verify Job Count Matches Row Count in the Proforma Required
            string RowCount = Rows.ToString();
            if (JobCount == RowCount)
            {
                SeleniumReporting.ElementMatchingVerification(true, "Row Count", "Job Count");

            }
            else
                SeleniumReporting.ElementMatchingVerification(false, "Row Count", "Job Count");

        }

        public static void VerifyFinalDARequiredJobCount()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();

            String JobCount = GetActions.GetInnerText(landingPage.FinalDARequiredJobCount);

            //Verify Job Count in the Proforma Required
            if (InitialAssertion.ifElementIsPresentandVisible(landingPage.FinalDARequiredJobCount))
            {
                SeleniumReporting.WriteResults(true, "Final DA Required Job Count :  " + JobCount + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify Final DA Required Job Count Existence!  ");

            int Rows = 0;
            string Status = "//td/span[contains(.,'Proforma Approved')]/preceding::tr[@class='k-alt action-grid-first-row']/preceding-sibling::tr//td/div[contains(.,'Final DA Required')]";
            Rows = PropertyCollection.Driver.FindElements(By.XPath(Status)).Count();

            //Verify Row Count in the Proforma Required
            if (InitialAssertion.ifElementIsPresentandVisible(landingPage.FinalDARequiredJobCount))
            {
                SeleniumReporting.WriteResults(true, "Final DA Required Row Count :  " + Rows + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify Final DA Required Row Count Existence!  ");

            //Verify Job Count Matches Row Count in the Proforma Required
            string RowCount = Rows.ToString();
            if (JobCount == RowCount)
            {
                SeleniumReporting.WriteResults(true, "Final DA Required Job Count Matches Row Count   " + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify Job Count Matches Row Count!  Unmatched Values Found!    ");
            //throw new Exception("Values Do Not Match!");

        }

        public static void ClickCargoTabSideBarMenu()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(landingpage.MenuButtonCargo,"Cargo");
        }

        public static void ClickBankRemitTabSideBarMenu()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(landingpage.MenuButtonBankRemit, "Bank Remit Tab");
        }

        public static void ClickSearchTabSideBarMenu()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(landingpage.MenuButtonSearch, "Search");
        }

//*******************************ACKNOWLEDGEMENT_REQUIRED*************************************************//

        public static void ClickFirstAcknowledgementRequiredJob()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(landingpage.FirstAcknowledgementRequiredJob, "First Acknowledge Job");
            System.Threading.Thread.Sleep(3000);
        }

        public static void SearchAcknowledgementRequiredJob()
        {
            Excel excel = new Excel(@"C:\Users\edqu01\Documents\GAC Automation\ConsoleApp1\ConsoleApp1\TestData\GACShipTestData.xlsx", "TestData");
            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();
            SetActions.FillInTextField(landingPage.MenuSearchTextField, excel.ReadDatabyColumnName("GACShip", "AcknowledgementRequiredJob"));
            SetActions.ClickButton(landingPage.MenuSearchIcon, "Search");


            PropertyCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            bool existFlag;
            string Xpath = excel.ReadDatabyColumnName("GACShip", "AcknowledgementRequiredJob");
            existFlag = InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath("//h3[contains(.,'Acknowledge')]//following-sibling::span[contains(.,'Nominated by Hub')][contains(.,Xpath)]"));
            Assert.AreEqual(true, existFlag);
            excel.Close();
        }

        public static void SearchAndVerifyAcknowledgementRequiredJob()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();
            string FirstAcknowledgementRequiredJobNumber = GetActions.GetInnerText(landingPage.FirstAcknowledgementRequiredJob);
            SeleniumReporting.WriteMessageOnTheReport("Fetching First Acknowledgement Required Job from the Table.");
            SeleniumReporting.WriteMessageOnTheReport("Fetched Job Number : " + FirstAcknowledgementRequiredJobNumber);

            SetActions.FillInTextField(FirstAcknowledgementRequiredJobNumber, landingPage.MenuSearchTextField);
            SeleniumReporting.WriteMessageOnTheReport("Input '" + FirstAcknowledgementRequiredJobNumber + "' in the Search Text Field");
            SetActions.ClickButton(landingPage.MenuSearchIcon, "Search");
            InitialAssertion.WaitForElementLoad(By.XPath("//div[@class='row heading']//h3[contains(.,'Acknowledge')]//following-sibling::span[contains(.,'Nominated by Hub')]"), 10);
            SeleniumReporting.WriteMessageOnTheReport("Succesfully diverted to PDA Page!");

            GACShip_Agent_Acknowledgement_Page acknowledgementPage = new GACShip_Agent_Acknowledgement_Page();
            String header = GetActions.GetInnerText(acknowledgementPage.AcknowledgementPageJobNumber);
            string SearchedAcknowledgementRequiredJobNumber = header.Substring(0, header.IndexOf(' ', header.IndexOf(' ') - 1));


            SeleniumReporting.WriteMessageOnTheReport("Retrieved Job Number : " + SearchedAcknowledgementRequiredJobNumber);

            //Checks if Searched Job Matches Retrieved Job
            if (FirstAcknowledgementRequiredJobNumber == SearchedAcknowledgementRequiredJobNumber)
            {
                SeleniumReporting.ElementMatchingVerification(true, "'First Acknowledgement Required Job Number'", "'Retrieved Job Number'");
            }
            else
                SeleniumReporting.ElementMatchingVerification(false, "'First Acknowledgement Required Job Number'", "'Retrieved Job Number'");

        }

        public static void VerifyAcknowldegementLandingPageObjects()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_Acknowledgement_Page landingpage = new GACShip_Agent_Acknowledgement_Page();
            InitialAssertion.WaitForElementLoad(By.XPath(landingpage.AcknowledgementPageHeader), 30);


            //AcknowledgementPageHeader Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcknowledgePageHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Acknowledge Page Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Acknowledge Page Header");


            //HeaderETA Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderETA))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header ETA");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header ETA");


            //HeaderETD Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderETD))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header ETD");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header ETD");


            //HeaderVesselName Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderVesselName))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header Vessel Name");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header Vessel Name");


            //HeaderIMONumber Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderIMONumber))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header IMO Number");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header IMO Number");


            //HeaderAcknowledgedOn Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderAcknowledgedOn))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header Acknowledged On");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header Acknowledged On");


            //HeaderHubInstruction Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderHubInstruction))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header Hub Instruction");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header Hub Instruction");


            //HeaderDocuments Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderDocuments))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header Documents");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header Documents");


            //HeaderDocumentsFileName Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderDocumentsFileName))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header Documents");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header Documents");


            //HeaderDocumentsUploadedBy Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderDocumentsUploadedBy))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header Documents Uploaded By");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header Documents Uploaded By");


            //HeaderDocumentsSize Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderDocumentsSize))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header Documents Size");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header Documents Size");


            //HeaderAcceptDeclinedRemarks Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HeaderAcceptDeclinedRemarks))
            {
                SeleniumReporting.ElementPresentVerification(true, "Header Accept Declined Remarks");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Header Accept Declined Remarks");


            //AcceptDeclinedRemarksTextField Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcceptDeclinedRemarksTextField))
            {
                SeleniumReporting.ElementPresentVerification(true, "Accept Declined Remarks Text Field");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Accept Declined Remarks Text Field");


            //AgentReferenceTextField Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AgentReferenceTextField))
            {
                SeleniumReporting.ElementPresentVerification(true, "Agent Reference Text Field");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Agent Reference Text Field");


            //AcknowledgementNote Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcknowledgementNote))
            {
                SeleniumReporting.ElementPresentVerification(true, "Acknowledgement Note");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Acknowledgement Note");


            //AcceptButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AcceptButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Accept Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Accept Button");


            //DeclineButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.DeclineButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Decline Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Decline Button");


            //PrintButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PrintButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Print Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Print Button");

        }

        public static void AcceptJobAcknowledgement()
        {
            GACShip_Agent_Acknowledgement_Page acknowledgementPage = new GACShip_Agent_Acknowledgement_Page();
            SetActions.FillInTextField("This is just an automated test.",acknowledgementPage.AcceptDeclinedRemarksTextField);
            SetActions.FillInTextField("This is just an automated test.", acknowledgementPage.AgentReferenceTextField);
            SetActions.ClickButton(acknowledgementPage.AcknowledgementNote, "Acknowledgement Note");
            SetActions.ClickButton(acknowledgementPage.AcceptButton, "Accept Button");

            PropertyCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            InitialAssertion.ifElementIsPresentandVisible(acknowledgementPage.AcknowldegementPageModalConfimrationButton);
            SetActions.ClickButton(acknowledgementPage.AcknowldegementPageModalConfimrationButton, "Confirmation Button");

            GACShipPDAPage PDAPage = new GACShipPDAPage();
            PropertyCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //GetActions.VerifyIfElementIsPresent(PropertyCollection.Driver, PropertyName.Xpath, PDAPage.PDAPageHeader);
                if (InitialAssertion.ifElementIsPresentandVisible(PDAPage.PDAPageHeader))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "PDA Page Header");
                    }
                else
                    {
                        SeleniumReporting.ElementPresentVerification(false, "PDA Page Header");
                        throw new Exception("SOF Job Number Not Found!");
                    }


        }

        public static void GetText()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();

            String JobCount = GetActions.GetInnerText(landingPage.SOFRequiredJobCount);

            //Verify Job Count in the Proforma Required
            if (InitialAssertion.ifElementIsPresentandVisible(landingPage.SOFRequiredJobCount))
            {
                SeleniumReporting.WriteResults(true, "SOF Required Job Count :  " + JobCount + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify SOF Required Job Count Existence!  ");


            int Rows = 0;
            string Status = "//td/span[contains(.,'Proforma Submitted')]/preceding::tr[@class='k-alt action-grid-first-row']/preceding-sibling::tr//td/div[contains(.,'SOF Required')]";
            Rows = PropertyCollection.Driver.FindElements(By.XPath(Status)).Count();

            //Verify Row Count in the Proforma Required
            if (InitialAssertion.ifElementIsPresentandVisible(landingPage.SOFRequiredJobCount))
            {
                SeleniumReporting.WriteResults(true, "SOF Required Row Count :  " + Rows + " ------ ");
            }
            else
                SeleniumReporting.WriteResults(false, "Verify SOF Required Row Count Existence!  ");


        }

        public static void VerifyAcknowldegmentRequiredJobCount()
        {

        }

//***************************************************PDA_JOBS*******************************************************************//

        public static void ClickFirstProformaRequiredJob()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(landingpage.FirstProformaRequiredJob, "First Proforma Required Job");
            System.Threading.Thread.Sleep(3000);
        }

        public static void SearchPDAJob()
        {
            Excel excel = new Excel(@"C:\Users\edqu01\Documents\GAC Automation\GACShip Agent GIT Repository\ConsoleApp1\TestData\GACShipTestData.xlsx", "TestData");
            GACShip_Agent_LandingPage newpage = new GACShip_Agent_LandingPage();
            SetActions.FillInTextField(excel.ReadDatabyColumnName("GACShip", "PDAJob"), newpage.MenuSearchTextField);
            SetActions.ClickButton(newpage.MenuSearchIcon, "Search");

            PropertyCollection.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            bool existFlag;
            string Xpath = excel.ReadDatabyColumnName("GACShip", "PDAJob");
            existFlag = InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath("//h3[contains(.,'PDA')]//following-sibling::job-summary//span[contains(.,'Acknowledged by PA')][contains(.,Xpath)]"));
            Console.WriteLine(Xpath);
            Console.WriteLine(existFlag);
            Assert.AreEqual(true, existFlag);
            excel.Close();
        }

        public static void SearchAndVerifyPDARequiredJob()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();
            string FirstPDARequiredJobNumber = GetActions.GetInnerText(landingPage.FirstProformaRequiredJob);
            SeleniumReporting.WriteMessageOnTheReport("Fetching First PDA Required Job from the Table.");
            SeleniumReporting.WriteMessageOnTheReport("Feteched Job Number : " + FirstPDARequiredJobNumber);

            SetActions.FillInTextField(FirstPDARequiredJobNumber, landingPage.MenuSearchTextField);
            SeleniumReporting.WriteMessageOnTheReport("Input '" + FirstPDARequiredJobNumber + "' in the Search Text Field");
            SetActions.ClickButton(landingPage.MenuSearchIcon, "Search");
            InitialAssertion.WaitForElementLoad(By.XPath("//h3[contains(.,'PDA')]//following-sibling::job-summary//span[contains(.,'Acknowledged by PA')]"), 30);
            SeleniumReporting.WriteMessageOnTheReport("Succesfully diverted to PDA Page!");

            GACShipPDAPage PDAPage = new GACShipPDAPage();
            String header = GetActions.GetInnerText(PDAPage.PDAPageJobNumber);
            string SearchedPDARequiredJobNumber = header.Substring(0, header.IndexOf(' ', header.IndexOf(' ') - 1));


            SeleniumReporting.WriteMessageOnTheReport("Retrieved Job Number : " + SearchedPDARequiredJobNumber);

            //Checks if Searched Job Matches Retrieved Job
            if (FirstPDARequiredJobNumber == SearchedPDARequiredJobNumber)
            {
                SeleniumReporting.ElementMatchingVerification(true, "'First PDA Required Job Number'", "'Retrieved Job Number'");
            }
            else
                SeleniumReporting.ElementMatchingVerification(false, "'First PDA Required Job Number'", "'Retrieved Job Number'");

        }

        public static void VerifyPDALandingPageObject()
        {
            GACShipPDAPage landingpage = new GACShipPDAPage();
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            InitialAssertion.WaitForElementLoad(By.XPath(landingpage.ProformaPageHeader), 30);


            //PDAPageHeader Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Header");

            //PDALockButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDALockButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Lock Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Lock Button");


            //PDAPageSubmitButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageSubmitButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Submit Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Submit Button");


            //PDAPageExportToExcelButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageExportToExcelButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Export To Excel Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Export To Excel Button");


            //PDAPageSaveButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageSaveButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Save Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Save Button");


            //PDAPageExpectedDates Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageExpectedDates))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Expected Dates");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Expected Dates");


            //PDAPageVersionDescription Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageVersionDescription))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Version Description");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Version Description");


            //PDAPageVersionProvider Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageVersionProvider))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Version Provider");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Version Provider");


            //PDAPageVersionPaidBy Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageVersionPaidBy))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Version Paid By");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Version Paid By");


            //PDAPageVersionCurrency Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageVersionCurrency))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Version Currency");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Version Currency");


            //PDAPageVersionQuantity Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageVersionQuantity))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Version Quantity");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Version Quantity");


            //PDAPageVersionUSDUnitPrice Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageVersionUSDUnitPrice))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Version USD Unit Price");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "PDA Page Version USD Unit Price");


            //PDAPageVersionUSDAmount Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDAPageVersionUSDAmount))
            {
                SeleniumReporting.ElementPresentVerification(true, "PDA Page Version USD Amount");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Verify PDA Page Version USD Amount");


        }

        public static void ClickEditPDAJobButton()
        {
            GACShipPDAPage newpage = new GACShipPDAPage();
            SetActions.ClickButton(newpage.PDAJobEditButton, "Edit Button");
            System.Threading.Thread.Sleep(8000);
        }

        public static void ClickCheckAllPDAJobButton()
        {
            GACShipPDAPage newpage = new GACShipPDAPage();
            SetActions.ClickButton(newpage.PDAPageCheckAllButton, "Check All Button");
            System.Threading.Thread.Sleep(8000);
        }

        public static void ClickFirstCheckBoxPDAJobButton()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_FDAPage newpage = new GACShip_Agent_FDAPage();
            SetActions.ClickButton(newpage.FDAPageFirstCheckBoxFDAJobs, "First FDA Checkbox");
            System.Threading.Thread.Sleep(5000);
        }

        public static void AddNewRowToPDAJob()
        {
            GACShipPDAPage newpage = new GACShipPDAPage();
            SetActions.ClickButton(newpage.PDAPageAddNewRowButton, "Add New Row Button");
            System.Threading.Thread.Sleep(3000);
            SetActions.ClickButton(newpage.PDAPageAddedNewRowDescription, "Add New Row Description");
            System.Threading.Thread.Sleep(2000);
            SetActions.FillInTextField(" ", newpage.PDAPageAddedNewRowDescriptionTextField);
            System.Threading.Thread.Sleep(2000);
            SetActions.ClickButton(newpage.PDAPageSelectAnchorageDuesFromDropdown, "Anchorage Dues");
            System.Threading.Thread.Sleep(8000);
        }

        public static void ClickSubmitPDAJobButton()
        {
            GACShipPDAPage newpage = new GACShipPDAPage();
            SetActions.ClickButton(newpage.PDAPageSubmitButton, "Submit Button");
            System.Threading.Thread.Sleep(5000);

            if (InitialAssertion.ifElementIsPresentandVisible(newpage.PDAPageDisclaimerModalCheckbox))
            {
                SetActions.ClickButton(newpage.PDAPageDisclaimerModalCheckbox, "Disclaimer Modal Checkbox");
                SetActions.ClickButton(newpage.PDAPageDisclaimerModalSubmitButton, "Disclaimer Modal Submit Button");
                System.Threading.Thread.Sleep(5000);
            }
            else
                return;
        }

        public static void verifyPDASuccesfullySubmittedMEssage()
        {
            GACShipPDAPage landingpage = new GACShipPDAPage();
                if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PDASuccessfullySubmittedMessage))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Succesfully Submitted Confirmation Message");
                    }
                else
                    {
                        SeleniumReporting.ElementPresentVerification(false, "Succesfully Submitted Confirmation Message");
                        throw new Exception("SOF Job Number Not Found!");

                    }
            System.Threading.Thread.Sleep(2000);
        }
//***************************************************SOF_JOBS*******************************************************************//

        public static void ClickFirstSOFRequiredJob()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(landingpage.FirstSOFRequiredJob, "First SOF Required Job");
            System.Threading.Thread.Sleep(6000);
        }

        public static void SearchSOFJob()
        {
            Excel excel = new Excel(@"C:\Users\edqu01\Documents\GAC Automation\GACShip Agent GIT Repository\ConsoleApp1\TestData\GACShipTestData.xlsx", "TestData");
            GACShip_Agent_LandingPage newpage = new GACShip_Agent_LandingPage();
            SetActions.FillInTextField(excel.ReadDatabyColumnName("GACShip", "SOFJob"), newpage.MenuSearchTextField);
            SetActions.ClickButton(newpage.MenuSearchIcon, "Search");

            System.Threading.Thread.Sleep(9000);

            bool existFlag;
            string Xpath = excel.ReadDatabyColumnName("GACShip", "AcknowledgementRequiredJob");
            existFlag = InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath("//h3[contains(.,'SOF')]//following-sibling::span[contains(.,'Proforma Submitted')][contains(.,Xpath)]"));
            Assert.AreEqual(true, existFlag);
            excel.Close();
        }

        public static void SearchAndVerifySOFRequiredJob()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();
            string FirstSOFRequiredJobNumber = GetActions.GetInnerText(landingPage.FirstSOFRequiredJob);
            SeleniumReporting.WriteMessageOnTheReport("Fetching First SOF Required Job from the Table.");
            SeleniumReporting.WriteMessageOnTheReport("Feteched Job Number : " + FirstSOFRequiredJobNumber);

            SetActions.FillInTextField(FirstSOFRequiredJobNumber, landingPage.MenuSearchTextField);
            SeleniumReporting.WriteMessageOnTheReport("Input '" + FirstSOFRequiredJobNumber + "' in the Search Text Field");
            SetActions.ClickButton(landingPage.MenuSearchIcon, "Search");
            InitialAssertion.WaitForElementLoad(By.XPath("//h3[contains(.,'SOF')]//following-sibling::span[contains(.,'SOF Missing')]"), 10);
            SeleniumReporting.WriteMessageOnTheReport("Succesfully diverted to SOF Page!");

            GACShip_Agent_SOFPage SOFPage = new GACShip_Agent_SOFPage();
            if (InitialAssertion.ifElementIsPresentandVisible(SOFPage.SOFPageJobNumber))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Job Number");
            }
            else
            {
                SeleniumReporting.ElementPresentVerification(false, "SOF Job Number");
                throw new Exception("SOF Job Number Not Found!");
            }
            String header = GetActions.GetInnerText(SOFPage.SOFPageJobNumber);

            string SearchedSOFRequiredJobNumber = header.Substring(0, header.IndexOf(' ', header.IndexOf(' ') - 1));


            SeleniumReporting.WriteMessageOnTheReport("Retrieved Job Number : " + SearchedSOFRequiredJobNumber);

            //Checks if Searched Job Matches Retrieved Job
            if (FirstSOFRequiredJobNumber == SearchedSOFRequiredJobNumber)
            {
                SeleniumReporting.ElementMatchingVerification(true, "'First SOF Required Job Number'", "'Retrieved Job Number'");
            }
            else
                SeleniumReporting.ElementMatchingVerification(false, "'First SOF Required Job Number'", "'Retrieved Job Number'");

        }

        public static void VerifySOFLandingPageObject()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_SOFPage landingpage = new GACShip_Agent_SOFPage();
            InitialAssertion.WaitForElementLoad(By.XPath(landingpage.SOFRequiredPageHeader), 30);

            //SOFPageHeader Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFPageHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Page Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Page Header");

            //SOFTimingPlaceHolder Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFTimingPlaceHolder))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Timing Place Holder");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Timing Place Holder");

            //LockButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.LockButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Lock Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Lock Button");

            //DownloadSOFReportButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.DownloadSOFReportButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Download SOF Report Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Verify Download SOF Report Button");

            //DocumentUploadViewButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.DocumentUploadViewButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Document Upload View Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Document Upload View Button");

            //SaveButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SaveButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Save Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Save Button");

            //SubmitButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SubmitButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Submit Button ");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Submit Button");

            //ETAOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ETAOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "ETA Of SOF Job ");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "ETA Of SOF Job");

            //ETDOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ETDOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "ETD Of SOFJob");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "ETD Of SOF Job ");


            //ATAOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ATAOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "ATA Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "ATA Of SOF Job");


            //ATDOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ATDOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "ATD Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "ATD Of SOF Job");

            //NoticeOfReadinessOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.NoticeOfReadinessOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Notice Of Readiness Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Notice Of Readiness Of SOF Job");

            //CommencedStartedOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.CommencedStartedOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Commenced Started Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Commenced Started Of SOF Job");


            //AnchoredStartedOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AnchoredStartedOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Anchored Started Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Anchored Started Of SOF Job");


            //CompletedStartedOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.CompletedStartedOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Completed Started Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Completed Started Of SOF Job");


            //AllFastStartedOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AllFastStartedOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "All Fast Started Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "All Fast Started Of SOF Job");


            //HSSEIncidentHeaderOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HSSEIncidentHeaderOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "HSSE Incident Header Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "HSSE Incident Header Of SOF Job");


            //HSSEYesRadioButtonOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HSSEYesRadioButtonOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "HSSE Yes Radio Button Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "HSSE Yes Radio Button Of SOF Job");

            //HSSENoRadioButtonOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.HSSENoRadioButtonOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "HSSE No Radio Button Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "HSSE No Radio Button Of SOF Job");


            //CustomerComplaintHeaderOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.CustomerComplaintHeaderOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Customer Complaint Header Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Customer Complaint Header Of SOF Job");


            //CustomerCompliantYesRadioButtonOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.CustomerCompliantYesRadioButtonOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Customer Compliant Yes Radio Button Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Customer Compliant Yes Radio Button Of SOF Job");


            //CustomerCompliantNoRadioButtonOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.CustomerCompliantNoRadioButtonOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Customer Compliant No Radio Button Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Verify Customer Compliant No Radio Button Of SOF Job");


            //OtherFeedbackHeaderOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.OtherFeedbackHeaderOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Other Feedback Header Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Verify Other Feedback Header Of SOF Job");


            //OtherFeedbackYesRadioButtonOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.OtherFeedbackYesRadioButtonOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Other Feedback Yes Radio Button Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Verify Other Feedback Yes Radio Button Of SOF Job");

            //OtherFeedbackNoRadioButtonOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.OtherFeedbackNoRadioButtonOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Other Feedback No Radio Button Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Other Feedback No Radio Button Of SOF Job");

            //ArrivalRemarksTextAreaOfSOFJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ArrivalRemarksTextAreaOfSOFJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "Arrival Remarks Text Area Of SOF Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Arrival Remarks Text Area Of SOF Job");

            //SOFEventsAndDetailsTabButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFEventsAndDetailsTabButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Events And Details Tab Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Events And Details Tab Button");


            //SOFEventsAndDetailsDescription Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFEventsAndDetailsDescription))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Events And Details Description");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Events And Details Description");


            //SOFEventsAndDetailsEventDate Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFEventsAndDetailsEventDate))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Events And Details Event Date");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Events And Details Event Date");


            //SOFEventsAndDetailsUnit Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFEventsAndDetailsUnit))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Events And Details Unit");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Events And Details Unit");


            //SOFEventsAndDetailsQuantity Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFEventsAndDetailsQuantity))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Events And Details Quantity");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Events And Details Quantity ");


            //SOFEventsAndDetailsCargo Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFEventsAndDetailsCargo))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Events And Details Cargo");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Events And Details Cargo");


            //SOFEventsAndDetailsRemarks Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SOFEventsAndDetailsRemarks))
            {
                SeleniumReporting.ElementPresentVerification(true, "SOF Events And Details Remarks");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "SOF Events And Details Remarks");

            //PageCheckAllButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.PageCheckAllButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Page Check All Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Page Check All Button");


            //AddNewRowButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.AddNewRowButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Add New Row Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Add New Row Button");



            SetActions.ClickButton(landingpage.ArrivalDetailsTabButton, "Arrival Details Tab");
            System.Threading.Thread.Sleep(1500);

            //ArrivalDetailsDescription Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ArrivalDetailsDescription))
            {
                SeleniumReporting.ElementPresentVerification(true, "Arrival Details Description");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Arrival Details Description");

            //ArrivalDetailsUnit Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ArrivalDetailsUnit))
            {
                SeleniumReporting.ElementPresentVerification(true, "Arrival Details Unit");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Arrival Details Unit");


            //ArrivalDetailsQuantity Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ArrivalDetailsQuantity))
            {
                SeleniumReporting.ElementPresentVerification(true, "Arrival Details Quantity");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Arrival Details Quantity");


            //ArrivalDetailsPurpose Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ArrivalDetailsPurpose))
            {
                SeleniumReporting.ElementPresentVerification(true, "Arrival Details Purpose");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Arrival Details Purpose");


            //ArrivalDetailsRemarks Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ArrivalDetailsRemarks))
            {
                SeleniumReporting.ElementPresentVerification(true, "Arrival Details Remarks");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Arrival Details Remarks");


            //landingpage.DepartureDetailsTabButton.Click();
            SetActions.ClickButton(landingpage.DepartureDetailsTabButton, "Departure Details Tab");

            //DepartureDetailsDescription Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.DepartureDetailsDescription))
            {
                SeleniumReporting.ElementPresentVerification(true, "Departure Details Description");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Departure Details Description");


            //DepartureDetailsUnit Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.DepartureDetailsUnit))
            {
                SeleniumReporting.ElementPresentVerification(true, "Departure Details Unit");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Departure Details Unit");


            //DepartureDetailsQuantity Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.DepartureDetailsQuantity))
            {
                SeleniumReporting.ElementPresentVerification(true, "Departure Details Quantity");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Departure Details Quantity");


            //DepartureDetailsPurpose Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.DepartureDetailsPurpose))
            {
                SeleniumReporting.ElementPresentVerification(true, "Departure Details Purpose");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Departure Details Purpose");


            //DepartureDetailsRemarks Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.DepartureDetailsRemarks))
            {
                SeleniumReporting.ElementPresentVerification(true, "Departure Details Remarks");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Departure Details Remarks");

            //landingpage.JobEditButton.Click();
            // System.Threading.Thread.Sleep(5000);
            //landingpage.JobUnlockButton.Click();
        }

        public static void ClickEditSOFJobButton()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.JobEditButton, "Edit Button");
            System.Threading.Thread.Sleep(8000);
        }

        public static void ClickSaveJobButton()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.SaveButton,"Save Button");
            System.Threading.Thread.Sleep(5000);
        }

        public static void ClickSOFJobButton()
        {
            GACShip_Agent_LandingPage newpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(newpage.MenuButtonSOFJobsButton, "SOF - Side Menu Buttons");
        }

        public static void ClickFDAJobButton()
        {
            GACShip_Agent_LandingPage newpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(newpage.MenuButtonFDAJobsButton, "FDA - Side Menu Buttons");
        }

        public static void ClickLockFDAJobButton()
        {
            GACShip_Agent_FDAPage newpage = new GACShip_Agent_FDAPage();
            SetActions.ClickButton(newpage.FDAJobNotEditableButton, "Edit Button");
        }

        public static void AddNewRowToSOFJob()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.AddNewRowButton, "Add New Ro Button");
        }

        public static void ClickArrivalDetailsTabSOFPage()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.ArrivalDetailsTabButton, "Arrival Details Tab");
            System.Threading.Thread.Sleep(2000);
        }

        public static void AddNewRowToArrivalDetailsTab()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.AddNewRowArrivalDetailsTab, "Add New Row");
            System.Threading.Thread.Sleep(2000);
        }

        public static void PopulateArrivalDetailsTab()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            System.Threading.Thread.Sleep(5000);
            SetActions.ClickButton(newpage.ArrivalDetailsDescriptionTextField, "Description TextField");
            SetActions.ClickButton(newpage.ArrivalDetailsDescriptionDropdown, "Description Dropdown");
            System.Threading.Thread.Sleep(5000);
            SetActions.ClickButton(newpage.ArrivalDetailsDescriptionDropdownSelectIPOOnArrival, "IPO On Arrival");
            System.Threading.Thread.Sleep(5000);
            SetActions.ClickButton(newpage.UnitDropdownArrivalDetails, "Unit Dropdown");

            System.Threading.Thread.Sleep(5000);
            SetActions.ClickButton(newpage.SelectKiloTonnesInArrivalDetailsUnitDropdown, "KiloTonnes");
            SetActions.FillInTextField("1", newpage.ArrivalDetailsQuantityTextField);
            SetActions.ClickButton(newpage.PurposeDropdownArrivalDetails, "Purpose Dropdown");
            System.Threading.Thread.Sleep(5000);
            SetActions.ClickButton(newpage.ArrivalDetailsPurposeDropdownSelectROBInSOF, "ROB in SOF");
            SetActions.FillInTextField("This is an Automated Test!", newpage.ArrivalDetailsRemarksTextField);
            System.Threading.Thread.Sleep(3000);
        }

        public static void ClickFirstCheckBoxSOFJobButton()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.SOFPageFirstCheckBoxSOFJobs, "First Check Box");
            System.Threading.Thread.Sleep(5000);
        }

        public static void clickSubmitSOFJob()
            {
                GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
                SetActions.ClickButton(newpage.SaveButton,"Save Button");
                System.Threading.Thread.Sleep(2000);
            }

        public static void PopulateSOFEventsAndDetailsTab()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.DescriptionDropdownSOFEventsAndDetails, "Description Dropdown");
            System.Threading.Thread.Sleep(2000);
            SetActions.ClickButton(newpage.SelectCommencedUllagingInSOFEventDropdown, "Select  Commenced Ullaging");
            System.Threading.Thread.Sleep(2000);
            String dateToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            SetActions.FillInTextField(dateToday, newpage.SOFEventDate);
            SetActions.ClickButton(newpage.UnitDropdownSOFEventsAndDetails, "Unit Dropdown");
            System.Threading.Thread.Sleep(1000);
            SetActions.ClickButton(newpage.SelectDateInSOFUnitDropdown, "Select Date");
            SetActions.FillInTextField("1", newpage.SOFEventQuantity);
            SetActions.ClickButton(newpage.CargoDropdownSOFEventsAndDetails, "Cargo Dropdown");
            System.Threading.Thread.Sleep(1000);
            SetActions.ClickButton(newpage.SelectGeneralInSOFCargoDropdown, "Select General");
            SetActions.FillInTextField("This is an Automated Test!", newpage.SOFEventRemarks);
            System.Threading.Thread.Sleep(3000);
        }

        public static void EnterDatesforSOFJobs()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            string dateToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string dateTomorrow = DateTime.Now.AddDays(+0.5).ToString("dd/MM/yyyy HH:mm");
            string dateYesterday = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy HH:mm");

            SetActions.FillInTextField(dateToday, newpage.ETAOfSOFJob);
            SetActions.FillInTextField(dateTomorrow, newpage.ETDOfSOFJob);
            SetActions.FillInTextField(dateToday, newpage.ATAOfSOFJob);
            SetActions.FillInTextField(dateTomorrow, newpage.ATDOfSOFJob);
            SetActions.ClickButton(newpage.NoticeOfReadinessOfSOFJob, dateTomorrow);
            SetActions.ClickButton(newpage.CommencedStartedOfSOFJob, dateToday);
            SetActions.ClickButton(newpage.AnchoredStartedOfSOFJob, dateTomorrow);
            SetActions.ClickButton(newpage.CompletedStartedOfSOFJob, dateToday);
            SetActions.ClickButton(newpage.AllFastStartedOfSOFJob, dateToday);
        }

        public static void clickYESHSSEIncident()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.HSSEYesRadioButtonOfSOFJob, "Yes Radio Button");
        }

        public static void clickNOHSSEIncident()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.HSSENoRadioButtonOfSOFJob, "No Radio Button");
        }

        public static void clickYESCustomerComplaint()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.CustomerCompliantYesRadioButtonOfSOFJob, "Yes Radio Button");
        }

        public static void clickNOCustomerComplaint()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.CustomerCompliantNoRadioButtonOfSOFJob, "No Radio Button");
        }

        public static void clickYESOtherFeedback()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.OtherFeedbackYesRadioButtonOfSOFJob, "Yes Radio Button");
        }

        public static void clickNoOtherFeedback()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.ClickButton(newpage.OtherFeedbackNoRadioButtonOfSOFJob, "No Radio Button");
        }

        public static void EnterArrivalRemarks()
        {
            GACShip_Agent_SOFPage newpage = new GACShip_Agent_SOFPage();
            SetActions.FillInTextField("This is an Automated Test!", newpage.ArrivalRemarksTextAreaOfSOFJob);
        }

        public static void verifySOFSuccesfullySubmittedMEssage()
        {
            GACShip_Agent_SOFPage SOFPage = new GACShip_Agent_SOFPage();
            //Succesfully Submitted Confirmation Message Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(SOFPage.SOFSuccessfullySubmittedMessage))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Succesfully Submitted Confirmation Message");
                        }
                else
                        {
                            SeleniumReporting.ElementPresentVerification(false, "Succesfully Submitted Confirmation Message");
                            throw new Exception("SOF Job Number Not Found!");
                        }
            System.Threading.Thread.Sleep(2000);
        }

//***************************************************FDA_JOBS*******************************************************************//

        public static void ClickFirstFDARequiredJob()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(landingpage.FirstFinalDARequiredJob, "First FDA Required Job");
            System.Threading.Thread.Sleep(3000);
        }

        public static void SearchFDAJob()
        {
            Excel excel = new Excel(@"C:\Users\edqu01\Documents\GAC Automation\GACShip Agent GIT Repository\ConsoleApp1\TestData\GACShipTestData.xlsx", "TestData");

            GACShip_Agent_LandingPage newpage = new GACShip_Agent_LandingPage();
            SetActions.FillInTextField(excel.ReadDatabyColumnName("GACShip", "FDAJob"), newpage.MenuSearchTextField);
            SetActions.ClickButton(newpage.MenuSearchIcon, "Search");
            System.Threading.Thread.Sleep(9000);

            bool existFlag;
            string Xpath = excel.ReadDatabyColumnName("GACShip", "FDAJob");
            existFlag = InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath("//h3[contains(.,'FDA')]//following-sibling::job-summary//span[contains(.,'Proforma Submitted')][contains(.,Xpath)]"));
            Console.WriteLine(Xpath);
            Console.WriteLine(existFlag);
            Assert.AreEqual(true, existFlag);
            excel.Close();
        }

        public static void VerifyFDALandingPageObject()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_FDAPage landingpage = new GACShip_Agent_FDAPage();
            InitialAssertion.WaitForElementLoad(By.XPath(landingpage.FDARequiredHeader), 60);

            //FDAPageHeader Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.FDAPageHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "FDA Page Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "FDA Page Header");

            //LockButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.LockButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Lock Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Lock Button");


            //SubmitButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SubmitButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Submit Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Submit Button");


            //ViewTypeHeader Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ViewTypeHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "View Type Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "View Type Header");


            //ViewTypeDropdown Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ViewTypeDropdown))
            {
                SeleniumReporting.ElementPresentVerification(true, "View Type Dropdown");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "View Type Dropdown");


            SetActions.ClickButton(landingpage.ViewTypeDropdown, "View Type Dropdown");
            System.Threading.Thread.Sleep(1000);

            //ViewTypeDropdownSelectViewPDA Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ViewTypeDropdownSelectViewPDA))
            {
                SeleniumReporting.ElementPresentVerification(true, "View Type Dropdown Select ViewP DA");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "View Type Dropdown Select View PDA");

            //ViewTypeDropdownSelectViewWithoutPDA Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ViewTypeDropdownSelectViewWithoutPDA))
            {
                SeleniumReporting.ElementPresentVerification(true, "View Type Dropdown Select View Without PDA");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "View Type Dropdown Select View Without PDA");


            //ColumnHeader Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Header");

            //ColumnHeaderDropdown Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnHeaderDropdown))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Header Dropdown");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Header Dropdown");


            //landingpage.ColumnHeaderDropdown.Click();
            SetActions.ClickButton(landingpage.ColumnHeaderDropdown, "Column Picker Dropdown");

            System.Threading.Thread.Sleep(1000);

            //ColumnDropdownDescription Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownDescription))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Description");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Description");


            //ColumnDropdownPaidTo Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownPaidTo))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Paid To");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Paid To");

            //ColumnDropdownPaidBy Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownPaidBy))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Paid By");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Paid By");


            //ColumnDropdownCurrency Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownCurrency))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Currency");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Currency");


            //ColumnDropdownFXRate Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownFXRate))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown FX Rate");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown FX Rate");


            //ColumnDropdownQuantity Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownQuantity))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Quantity");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Quantity");


            //ColumnDropdownUnitPrice Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownUnitPrice))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Unit Price");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Unit Price");


            //ColumnDropdownAmount Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownAmount))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Amount");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Amount");


            //ColumnDropdownUSDUnitPrice Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownUSDUnitPrice))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown USD Unit Price");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown USD Unit Price");


            //ColumnDropdownUSDAmount Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownUSDAmount))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown USD Amount");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown USD Amount ");


            //ColumnDropdownVATType Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownVATType))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown VAT Type");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown VAT Type");


            //ColumnDropdownVATRate Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownVATRate))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown VAT Rate");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown VAT Rate");


            //ColumnDropdownVATAmountUSD Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownVATAmountUSD))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown VAT Amount USD");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown VAT Amount USD");


            //ColumnDropdownVATAmountWithVATUSD Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownVATAmountWithVATUSD))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown VAT Amount With VAT USD");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown VAT Amount With VAT USD");


            //ColumnDropdownRebillable Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownRebillable))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Rebillable");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Rebillable");


            //ColumnDropdownRemarks Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownRemarks))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Remarks");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Remarks");


            //ColumnDropdownIncidentNoPONo Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownIncidentNoPONo))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Incident No PO No");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Incident No PO No");


            //ColumnDropdownInvoiceNo Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownInvoiceNo))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Invoice No");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Invoice No");


            //ColumnDropdownVoucherNo Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownVoucherNo))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Voucher No");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Voucher No");


            //ColumnDropdownProject Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownProject))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Project");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Project");


            //ColumnDropdownRequestedBy Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownRequestedBy))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Requested By");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Requested By");


            //ColumnDropdownVendorDetail Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownVendorDetail))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Vendor Detail");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Vendor Detail");


            //ColumnDropdownCreatedBy Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ColumnDropdownCreatedBy))
            {
                SeleniumReporting.ElementPresentVerification(true, "Column Dropdown Created By");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Column Dropdown Created By");


            //FDAPageCheckAllButton Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.FDAPageCheckAllButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "FDA Page Check All Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Verify FDA Page Check All Button");



            SetActions.ClickButton(landingpage.FDADatesDropdown, "FDA Dates Dropdown");
            //ETAOfFDAJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ETAOfFDAJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "ETA Of FDA Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "ETA Of FDA Job");


            //ETDOfFDAJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ETDOfFDAJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "ETD Of FDA Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "ETD Of FDA Job");

            //ATAOfFDAJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ATAOfFDAJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "ATA Of FDA Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "ATA Of FDA Job");


            //ATDOfFDAJob Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.ATDOfFDAJob))
            {
                SeleniumReporting.ElementPresentVerification(true, "ATD Of FDA Job");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "ATD Of FDA Job");

        }

        public static void SearchAndVerifyFDARequiredJob()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();
            string FirstFDARequiredJobNumber = GetActions.GetInnerText(landingPage.FirstFinalDARequiredJob);
            SeleniumReporting.WriteMessageOnTheReport("Fetching First FDA Required Job from the Table.");
            SeleniumReporting.WriteMessageOnTheReport("Feteched Job Number : " + FirstFDARequiredJobNumber);


            SetActions.FillInTextField(FirstFDARequiredJobNumber, landingPage.MenuSearchTextField);
            SeleniumReporting.WriteMessageOnTheReport("Input '" + FirstFDARequiredJobNumber + "' in the Search Text Field");
            SetActions.ClickButton(landingPage.MenuSearchIcon, "Search");
            InitialAssertion.WaitForElementLoad(By.XPath("//h3[contains(.,'FDA')]//following-sibling::job-summary//span[contains(.,'Proforma Submitted')]"), 30);
            SeleniumReporting.WriteMessageOnTheReport("Succesfully diverted to FDA Page!");

            GACShip_Agent_FDAPage FDAPage = new GACShip_Agent_FDAPage();
            String header = GetActions.GetInnerText(FDAPage.FDAPageJobNumber);
            string SearchedFDARequiredJobNumber = header.Substring(0, header.IndexOf(' ', header.IndexOf(' ') - 1));


            SeleniumReporting.WriteMessageOnTheReport("Retrieved Job Number : " + SearchedFDARequiredJobNumber);

            //Checks if Searched Job Matches Retrieved Job
            if (FirstFDARequiredJobNumber == SearchedFDARequiredJobNumber)
            {
                SeleniumReporting.ElementMatchingVerification(true, "'First FDA Required Job Number'", "'Retrieved Job Number'");
            }
            else
                SeleniumReporting.ElementMatchingVerification(false, "'First FDA Required Job Number'", "'Retrieved Job Number'");

        }

        public static void ClickEditFDAJobButton()
        {
            GACShip_Agent_FDAPage newpage = new GACShip_Agent_FDAPage();
            SetActions.ClickButton(newpage.FDAJobEditButton, "Edit Button");
            System.Threading.Thread.Sleep(5000);
        }

        public static void ClickCheckAllFDAJobButton()
        {
            GACShip_Agent_FDAPage newpage = new GACShip_Agent_FDAPage();
            SetActions.ClickButton(newpage.FDAPageCheckAllButton, "Tick All Checkbox");
            System.Threading.Thread.Sleep(8000);
        }

        public static void ClickFirstCheckBoxFDAJobButton()
        {
            GACShip_Agent_FDAPage newpage = new GACShip_Agent_FDAPage();
            SetActions.ClickButton(newpage.FDAPageFirstCheckBoxFDAJobs, "First FDA Checkbox");
            System.Threading.Thread.Sleep(5000);
        }

        public static void EnterDatesforFDAJobs()
        {
            GACShip_Agent_FDAPage newpage = new GACShip_Agent_FDAPage();
            SetActions.ClickButton(newpage.FDADatesDropdown, "Dates Dropdown");
            string dateToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            string dateTomorrow = DateTime.Now.AddDays(+1).ToString("dd/MM/yyyy HH:mm");
            string dateYesterday = DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy HH:mm");
            string dateOneWeekFromNow = DateTime.Now.AddDays(+10).ToString("dd/MM/yyyy HH:mm");

            SetActions.FillInTextField(dateToday, newpage.ETBOfFDAJob);
            System.Threading.Thread.Sleep(1000);
            SetActions.FillInTextField(dateYesterday, newpage.ATAOfFDAJob);
            System.Threading.Thread.Sleep(1000);
            SetActions.FillInTextField(dateTomorrow, newpage.ATDOfFDAJob);
            System.Threading.Thread.Sleep(1000);
            SetActions.FillInTextField(dateToday, newpage.ATBOfFDAJob);
            System.Threading.Thread.Sleep(1000);
            SetActions.FillInTextField(dateYesterday, newpage.ETAOfFDAJob);
            System.Threading.Thread.Sleep(1000);
            SetActions.FillInTextField(dateTomorrow, newpage.ETDOfFDAJob);
            System.Threading.Thread.Sleep(1000);
        }

        public static void EnterRemarksForFDAJobs()
        {
            GACShip_Agent_FDAPage newpage = new GACShip_Agent_FDAPage();
            SetActions.ClickButton(newpage.FDAPageToggleOnFirstRemarks, "Toggle on First Remarks");
            SetActions.FillInTextField("This is an automated test!", newpage.FDAPageFirstRebillableRemarks);
            SetActions.FillInTextField("This is an automated test!", newpage.FDAPageFirstAgentRemarks);
            System.Threading.Thread.Sleep(5000);
        }

        public static void ClickSubmitFDAJobButton()
        {
            GACShip_Agent_FDAPage newpage = new GACShip_Agent_FDAPage();
            SetActions.ClickButton(newpage.SubmitButton, "Submit Button");
            System.Threading.Thread.Sleep(8000);
            SetActions.ClickButton(newpage.FDAPageDisclaimerModalCheckbox, "Disclaimer Checkbox");
            SetActions.ClickButton(newpage.FDAPageDisclaimerModalSubmitButton, "Disclaimer Submit Button");
            System.Threading.Thread.Sleep(5000);
        }

        public static void clickMainMenuSOFJobButton()
        {
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
            SetActions.ClickButton(landingpage.MenuButtonSOFJobsButton, "SOF - Side Menu Buttons");
            System.Threading.Thread.Sleep(2000);
        }

        public static void verifyFDASuccesfullySubmittedMEssage()
        {
            GACShip_Agent_FDAPage landingpage = new GACShip_Agent_FDAPage();
            //Succesfully Submitted Message Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(landingpage.FDASuccessfullySubmittedMessage))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Succesfully Submitted Confrimation Message");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Succesfully Submitted Confrimation Message");
            System.Threading.Thread.Sleep(2000);
        }

//***************************************************Cargo_Page*******************************************************************//
        public static void VerifyCargoPageObjects()

        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_Cargo_Page landingpage = new GACShip_Agent_Cargo_Page();
            InitialAssertion.WaitForElementLoad(By.XPath(landingpage.CargoPageHeaderAsString), 60);

            //Cargo Page Header Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.CargoPageHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Cargo Page Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Cargo Page Header");

            //Document Upload View Button Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.DocumentUploadViewButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Document Upload View Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Document Upload View Button");

            //Edit Button Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.EditButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Edit Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Edit Button");


            //Save Button Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.SaveButton))
            {
                SeleniumReporting.ElementPresentVerification(true, "Save Button");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Save Button");

            //Terminal Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.TerminalColumnHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Terminal Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Terminal Column Header");

            //Berth Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.BerthColumnHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Berth Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Berth Column Header");

            //Cargo Type Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.CargoTypeColumnHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Cargo Type Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Cargo Type Column Header");

            //Cargo Description Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.CargoDescriptionColumnHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Cargo Description Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Cargo Description Column Header");

            //Call Purpose Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.CallPurposeColumnHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Call Purpose Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Call Purpose Column Header");

            //Qty UoM Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.QtyUOMColumnHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Qty UOM Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Qty UOM Column Header");

            //Volume UoM Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.VolumeUOMColumnHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Volume UOM Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Volume UOM Column Header");

            //Nominated Qty Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresentandVisible(landingpage.NominatedQtyColumnHeader))
            {
                SeleniumReporting.ElementPresentVerification(true, "Nominated Qty Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Nominated Qty Column Header");

            //Nominated Volume Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.NominatedVolumeColumnHeader)))
            {
                SeleniumReporting.ElementPresentVerification(true, "Nominated Volume Column Header");
            }
             else
                SeleniumReporting.ElementPresentVerification(false, "Nominated Volume Column Header");

             //BoL Qty Column Header Existence Verification
              if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.BoLQtyColumnHeader)))
              {
                 SeleniumReporting.ElementPresentVerification(true, "BoL Qty Column Header");
               }
              else
                  SeleniumReporting.ElementPresentVerification(false, "BoL Qty Column Header");

             //BoL Volume Column Header Existence Verification
             if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.BoLVolumeColumnHeader)))
             {
                  SeleniumReporting.ElementPresentVerification(true, "BoL Volume Column Header");
             }
             else
                  SeleniumReporting.ElementPresentVerification(false, "BoL Volume Column Header");

            //BoL Date Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.BoLDateColumnHeader)))
            {
                SeleniumReporting.ElementPresentVerification(true, "BoL Date Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "BoL Date Column Header");

            //Ship Figures Qty Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.ShipFiguresQtyColumnHeader)))
            {
                SeleniumReporting.ElementPresentVerification(true, "Ship Figures Qty Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Ship Figures Qty Column Header");

            //Ship Figures Volume Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.ShipFiguresVolumeColumnHeader)))
            {
                SeleniumReporting.ElementPresentVerification(true, "Ship Figures Volume Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Ship Figures Volume Column Header");

            //Ship Figures RoB Column Header Existence Verification
            if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.ShipFiguresRoBColumnHeader)))
            {
                SeleniumReporting.ElementPresentVerification(true, "Ship Figures RoB Column Header");
            }
            else
                SeleniumReporting.ElementPresentVerification(false, "Ship Figures RoB Column Header");
        }

//***************************************************Bank_Remit_Page*******************************************************************//
        public static void VerifyBankRemitPageObjects()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_Bank_Remit_Page landingpage = new GACShip_Agent_Bank_Remit_Page();
            InitialAssertion.WaitForElementLoad(By.XPath(landingpage.BankRemitHeader), 60);

            //Bank Remit Page Header Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.BankRemitHeader)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Bank Remit Page Header");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Bank Remit Page Header");

            //Payment Date From Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.PaymentDateFrom)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Payment Date From");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Payment Date From");

            //Payment Date To Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.PaymentDateTo)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Payment Date To");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Payment Date To");


            //Advise Ref No Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.AdviceRefNumber)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Advice Ref No");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Advice Ref No");


            //Refresh Button Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.RefreshButton)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Refresh Button");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Refresh Button");


            //Search Button Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.SearchButton)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Search Button");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Search Button");

            //Name Column in Main Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.NameColumn_MT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Name Columnn in Main Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Name Column in Main Table'");

            //Known As in Main Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.KnownAsColumn_MT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Known As Columnn in Main Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Known As Column in Main Table'");

            //HSBC Reference in Main Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.HSBCReferenceColumn_MT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'HSBC Reference Columnn in Main Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'HSBC Reference Column in Main Table'");

            //Payment Date in Main Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.PaymentDateColumn_MT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Payment Date Columnn in Main Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Payment Date Column in Main Table'");

            //Currency in Main Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.CurrenyColumn_MT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Currency Columnn in Main Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Currency Column in Main Table'");

            //Debit Amount in Main Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.DebitAmountColumn_MT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Debit Amount Columnn in Main Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Debit Amount Column in Main Table'");

            //Created On in Main Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.CreatedOnColumn_MT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Created On Column in Main Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Created On Column in Main Table'");

            //Job Number in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.JobNumberColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Job Number Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Job Number Column in Bottom Table'");

            //Voyage Number in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.VoyageNumberColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Voyage Number Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Voyage Number Column in Bottom Table'");

            //Vessel in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.VesselColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Vessel Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Vessel Column in Bottom Table'");

            //IMO Number in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.IMONumberColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'IMO Number Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'IMO Number Column in Bottom Table'");

            //Port Agent in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.PortAgentColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Port Agent Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Port Agent Column in Bottom Table'");

            //Currency in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.CurrencyColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Currency Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Currency Column in Bottom Table'");

            //Amount in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.AmountColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Amount Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Amount Column in Bottom Table'");

            //ETA in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.ETAColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'ETA Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'ETA Column in Bottom Table'");

            //ATA in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.ETAColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'ATA Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'ATA Column in Bottom Table'");

            //ATD in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.ATDColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'ATD Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'ATD Column in Bottom Table'");

            //Principal in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.PrincipalColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Principal Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Principal Column in Bottom Table'");

            //Job Type in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.JobTypeColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Job Type Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Job Type Column in Bottom Table'");

            //HUB PIC in Bottom Table Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.HUBPICColumn_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'HUB PIC Column in Bottom Table'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'HUB PIC Column in Bottom Table'");

            /*//Disclaimer Existence Verification
                    if (InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath(landingpage.Disclaimer_BT)))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "'Disclaimer'");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "'Disclaimer'");*/
        }

//***************************************************Search_Page*******************************************************************//

        public static void VerifySearchPageObjects()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_Search_Page searchPage = new GACShip_Agent_Search_Page();
            InitialAssertion.WaitForElementLoad(By.XPath(searchPage.SearchPageHeader), 60);


                    //Search Page Header Existence Verification
                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.SearchPageHeader))
                            {
                                SeleniumReporting.ElementPresentVerification(true, "Search Page Header");
                            }
                        else
                                SeleniumReporting.ElementPresentVerification(false, "Search Page Header");


                    //Search Page SubText Existence Verification
                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.SearchPageSubText))
                            {
                                SeleniumReporting.ElementPresentVerification(true, "Search Page SubText");
                            }
                        else
                                SeleniumReporting.ElementPresentVerification(false, "Search Page SubText ");


                    //Job Number Filter Existence Verification
                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.JobNumberFilter))
                            {
                                SeleniumReporting.ElementPresentVerification(true, "Job Number Filter");
                            }
                        else
                                SeleniumReporting.ElementPresentVerification(false, "Job Number Filter");

                    //Vessel Filter Existence Verification
                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.VesselFilter))
                            {
                                SeleniumReporting.ElementPresentVerification(true, "Vessel Filter");
                            }
                        else
                                SeleniumReporting.ElementPresentVerification(false, "Vessel Filter");

                    //Port Filter Existence Verification
                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.PortFilter))
                            {
                                SeleniumReporting.ElementPresentVerification(true, "Port Filter");
                            }
                        else
                                SeleniumReporting.ElementPresentVerification(false, "Port Filter");

                    //Principal Filter Existence Verification
                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.PrincipalFilter))
                            {
                                SeleniumReporting.ElementPresentVerification(true, "Principal Filter");
                            }
                        else
                                SeleniumReporting.ElementPresentVerification(false, "Principal Filter");

                    //Principal Filter Existence Verification
                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.JobStatusFilter))
                            {
                                SeleniumReporting.ElementPresentVerification(true, "Job Status Filter");
                            }
                        else
                                SeleniumReporting.ElementPresentVerification(false, "Job Status Filter");

                    //Principal Filter Existence Verification
                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.JobStatusDropdown))
                            {
                                SeleniumReporting.ElementPresentVerification(true, "Job Status DropDown");
                            }
                        else
                                SeleniumReporting.ElementPresentVerification(false, "Job Status DropDown");


            SetActions.ClickButton(searchPage.JobStatusDropdown, "Job Status Dropdown");
            InitialAssertion.WaitForElementLoad(By.XPath(searchPage.AllJobs_JobStatus_Dropdown), 60);

                                         //***********JOB STATUS DROPDOWN OPTIONS****************************************************************             
                                                    //Active Jobs Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.JobStatusDropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Active Jobs DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Active Jobs DropDown Option");


                                                    //All Jobs Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.AllJobs_JobStatus_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "All Jobs DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "All Jobs DropDown Option");


                                                    //Quotation Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.Quotation_JobStatus_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Quotation DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Quotation DropDown Option");

                                                    //Nominated By Hub Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.NomindatedByHub_JobStatus_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Nominated By Hub DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Nominated By Hub DropDown Option");


                                                    //Acknowledged by PA Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.AcknowledgedByPA_JobStatus_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Acknowledged by PA DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Acknowledged by PA DropDown Option");

                                                    //Proforma Submitted Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ProformaSubmitted_JobStatus_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Proforma Submitted DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Proforma Submitted DropDown Option");

                                                    //Proforma Approved Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ProformaApproved_JobStatus_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Proforma Approved DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Proforma Approved DropDown Option");


                                                    //Final D/A Submitted Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.FinalDASubmitted_JobStatus_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Final D/A Submitted DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Final D/A Submitted DropDown Option");


                                                    //Final D/A Approved Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ProformaApproved_JobStatus_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Final D/A Approved DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Final D/A Approved DropDown Option");


                                                    //Job Cancelled Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.JobCancelled_JobStatus_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Job Cancelled DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Job Cancelled DropDown Option");


                                                    //Job Closed Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.JobClosed_JobStatus_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Job Closed DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Job Closed DropDown Option");

                                          //********************************************************************************************************************


                    //GDC Funded Filter Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.FundedByGDCInputFilter))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "GDC Funded Filter");
                    }
                    else
                        SeleniumReporting.ElementPresentVerification(false, "GDC Funded Filter");

                    //Funded By GDC Dropdown Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.FundedByGDCDropdown))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Funded by GDC DropDown");
                    }
                    else
                        SeleniumReporting.ElementPresentVerification(false, "Funded by GDC DropDown");


            SetActions.ClickButton(searchPage.FundedByGDCDropdown, "Funded by GDC");
            InitialAssertion.WaitForElementLoad(By.XPath(searchPage.All_FundedByGDC_Dropdown), 60);

                                        //***********JOB STATUS DROPDOWN OPTIONS**********************************************************************             
                                                    //All Funded by GDC Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.All_FundedByGDC_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "All Funded by GDC DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "All Funded by GDC DropDown Option");


                                                    //Yes Funded by GDC Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.Yes_FundedByGDC_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Yes Funded by GDC DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Yes Funded by GDC DropDown Option");

                                                    //No Funded by GDC Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.No_FundedByGDC_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "No Funded by GDC DropDown Option");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "No Funded by GDC DropDown Option");
                                        //*************************************************************************************************************


                    //Arrival From Filter Existence Verification
                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromInputFilter))
                            {
                                SeleniumReporting.ElementPresentVerification(true, "Arrived From Filter");
                            }
                        else
                                SeleniumReporting.ElementPresentVerification(false, "Arrived From Filter");


                    //Arrival From Date Dropdown Existence Verification
                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromDateDropdown))
                            {
                                SeleniumReporting.ElementPresentVerification(true, "Arrival From Date DropDown");
                            }
                        else
                                SeleniumReporting.ElementPresentVerification(false, "Arrival From Date DropDown");


            SetActions.ClickButton(searchPage.ArrivalFromDateDropdown, "Arrival From Date");
            InitialAssertion.WaitForElementLoad(By.XPath(searchPage.ArrivalFromCalendar), 60);

                                        //***********JOB STATUS DROPDOWN OPTIONS**********************************************************************             
                                                    //Arrival From Calendar Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromCalendar))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "Arrival From Calendar");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "Arrival From Calendar");
                                        //*************************************************************************************************************

            SetActions.ClickButton(searchPage.ArrivalFromTimeDropdown, "Arrival From Time");
            InitialAssertion.WaitForElementLoad(By.XPath(searchPage.ArrivalFromTime_1200AM_Dropdown), 60);

                                        //***********JOB STATUS DROPDOWN OPTIONS**********************************************************************             
                                                    //Arrival From 12:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_1200AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "12:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "12:00 AM Time - Arrival From");


                                                    //Arrival From 12:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_1230AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "12:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "12:30 AM Time - Arrival From");


                                                    //Arrival From 1:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_1AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "1:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "1:00 AM Time - Arrival From");


                                                    //Arrival From 1:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_130AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "1:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "1:30 AM Time - Arrival From");


                                                    //Arrival From 2:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_2AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "2:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "2:00 AM Time - Arrival From");


                                                    //Arrival From 2:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_230AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "2:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "2:30 AM Time - Arrival From");


                                                    //Arrival From 3:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_3AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "3:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "3:00 AM Time - Arrival From");


                                                    //Arrival From 3:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_330AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "3:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "3:30 AM Time - Arrival From");


                                                    //Arrival From 4:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_4AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "4:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "4:00 AM Time - Arrival From");


                                                    //Arrival From 4:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_430AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "4:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "4:30 AM Time - Arrival From");


                                                    //Arrival From 5:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_5AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "5:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "5:00 AM Time - Arrival From");


                                                    //Arrival From 5:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_530AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "5:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "5:30 AM Time - Arrival From");


                                                    //Arrival From 6:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_6AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "6:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "6:00 AM Time - Arrival From");


                                                    //Arrival From 6:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_630AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "6:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "6:30 AM Time - Arrival From");


                                                    //Arrival From 7:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_7AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "7:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "7:00 AM Time - Arrival From");


                                                    //Arrival From 7:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_730AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "7:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "7:30 AM Time - Arrival From");


                                                    //Arrival From 8:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_8AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "8:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "8:00 AM Time - Arrival From");


                                                    //Arrival From 8:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_830AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "8:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "8:30 AM Time - Arrival From");


                                                    //Arrival From 9:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_9AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "9:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "9:00 AM Time - Arrival From");


                                                    //Arrival From 9:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_930AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "9:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "9:30 AM Time - Arrival From");


                                                    //Arrival From 10:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_10AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "10:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "10:00 AM Time - Arrival From");


                                                    //Arrival From 10:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_1030AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "10:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "10:30 AM Time - Arrival From");


                                                    //Arrival From 11:00 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_11AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "11:00 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "11:00 AM Time - Arrival From");


                                                    //Arrival From 11:30 AM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_1130AM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "11:30 AM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "11:30 AM Time - Arrival From");


                                                    //Arrival From 12:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_12PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "12:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "12:00 PM Time - Arrival From");


                                                    //Arrival From 12:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_1230PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "12:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "12:30 PM Time - Arrival From");


                                                    //Arrival From 1:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_1PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "1:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                            SeleniumReporting.ElementPresentVerification(false, "1:00 PM Time - Arrival From");


                                                    //Arrival From 1:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_130PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "1:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "1:30 PM Time - Arrival From");


                                                    //Arrival From 2:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_2PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "2:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "2:00 PM Time - Arrival From");


                                                    //Arrival From 2:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_230PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "2:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "2:30 PM Time - Arrival From");


                                                    //Arrival From 3:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_3PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "3:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "3:00 PM Time - Arrival From");


                                                        //Arrival From 3:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_330PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "3:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "3:30 PM Time - Arrival From");


                                                    //Arrival From 4:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_4PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "4:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "4:00 PM Time - Arrival From");


                                                    //Arrival From 4:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_430PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "4:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "4:30 PM Time - Arrival From");


                                                    //Arrival From 5:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_5PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "5:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "5:00 PM Time - Arrival From");


                                                    //Arrival From 5:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_530PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "5:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "5:30 PM Time - Arrival From");


                                                    //Arrival From 6:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_6PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "6:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "6:00 PM Time - Arrival From");


                                                    //Arrival From 6:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_630PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "6:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "6:30 PM Time - Arrival From");


                                                    //Arrival From 7:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_7PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "7:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "7:00 PM Time - Arrival From");


                                                    //Arrival From 7:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_730PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "7:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "7:30 PM Time - Arrival From");


                                                    //Arrival From 8:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_8PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "8:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "8:00 PM Time - Arrival From");


                                                    //Arrival From 8:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_830PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "8:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "8:30 PM Time - Arrival From");


                                                    //Arrival From 9:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_9PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "9:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "9:00 PM Time - Arrival From");


                                                    //Arrival From 9:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_930PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "9:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "9:30 PM Time - Arrival From");


                                                    //Arrival From 10:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_10PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "10:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "10:00 PM Time - Arrival From");


                                                    //Arrival From 10:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_1030PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "10:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "10:30 PM Time - Arrival From");


                                                    //Arrival From 11:00 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_11PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "11:00 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "11:00 PM Time - Arrival From");


                                                    //Arrival From 11:30 PM Dropdown Option Existence Verification
                                                        if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalFromTime_1130PM_Dropdown))
                                                            {
                                                                SeleniumReporting.ElementPresentVerification(true, "11:30 PM Time - Arrival From");
                                                            }
                                                        else
                                                                SeleniumReporting.ElementPresentVerification(false, "11:30 PM Time - Arrival From");
                                        //*************************************************************************************************************

                //Arrival To Filter Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToInputFilter))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Arrived To Filter");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Arrived To Filter");


                //Arrival To Date Dropdown Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToDateDropdown))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Arrival To Date DropDown");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Arrival To Date DropDown");


            SetActions.ClickButton(searchPage.ArrivalToDateDropdown, "Arrival To Date");
            InitialAssertion.WaitForElementLoad(By.XPath(searchPage.ArrivalToCalendar), 60);

                                                        //***********JOB STATUS DROPDOWN OPTIONS**********************************************************************             
                                                                //Arrival To Calendar Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToCalendar))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "Arrival To Calendar");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "Arrival To Calendar");
                                                        //*************************************************************************************************************

            SetActions.ClickButton(searchPage.ArrivalToTimeDropdown, "Arrival To Time");
            InitialAssertion.WaitForElementLoad(By.XPath(searchPage.ArrivalToTime_1200AM_Dropdown), 60);

                                                        //***********JOB STATUS DROPDOWN OPTIONS**********************************************************************             
                                                                //Arrival To 12:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_1200AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "12:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "12:00 AM Time - Arrival To");


                                                                //Arrival To 12:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_1230AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "12:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "12:30 AM Time - Arrival To");


                                                                //Arrival To 1:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_1AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "1:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "1:00 AM Time - Arrival To");


                                                                //Arrival To 1:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_130AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "1:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "1:30 AM Time - Arrival To");


                                                                //Arrival To 2:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_2AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "2:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "2:00 AM Time - Arrival To");


                                                                //Arrival To 2:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_230AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "2:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "2:30 AM Time - Arrival To");


                                                                //Arrival To 3:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_3AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "3:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "3:00 AM Time - Arrival To");


                                                                //Arrival To 3:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_330AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "3:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "3:30 AM Time - Arrival To");


                                                                //Arrival To 4:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_4AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "4:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "4:00 AM Time - Arrival To");


                                                                //Arrival To 4:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_430AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "4:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "4:30 AM Time - Arrival To");


                                                                //Arrival To 5:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_5AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "5:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "5:00 AM Time - Arrival To");


                                                                //Arrival To 5:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_530AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "5:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "5:30 AM Time - Arrival To");


                                                                //Arrival To 6:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_6AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "6:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "6:00 AM Time - Arrival To");


                                                                //Arrival To 6:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_630AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "6:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "6:30 AM Time - Arrival To");


                                                                //Arrival To 7:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_7AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "7:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "7:00 AM Time - Arrival To");


                                                                //Arrival To 7:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_730AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "7:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "7:30 AM Time - Arrival To");


                                                                //Arrival To 8:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_8AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "8:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "8:00 AM Time - Arrival To");


                                                                //Arrival To 8:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_830AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "8:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "8:30 AM Time - Arrival To");


                                                                //Arrival To 9:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_9AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "9:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "9:00 AM Time - Arrival To");


                                                                //Arrival To 9:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_930AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "9:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "9:30 AM Time - Arrival To");


                                                                //Arrival To 10:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_10AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "10:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "10:00 AM Time - Arrival To");


                                                                //Arrival To 10:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_1030AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "10:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "10:30 AM Time - Arrival To");


                                                                //Arrival To 11:00 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_11AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "11:00 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "11:00 AM Time - Arrival To");


                                                                //Arrival To 11:30 AM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_1130AM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "11:30 AM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "11:30 AM Time - Arrival To");


                                                                //Arrival To 12:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_12PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "12:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "12:00 PM Time - Arrival To");


                                                                //Arrival To 12:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_1230PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "12:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "12:30 PM Time - Arrival To");


                                                                //Arrival To 1:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_1PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "1:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "1:00 PM Time - Arrival To");


                                                                //Arrival To 1:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_130PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "1:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "1:30 PM Time - Arrival To");


                                                                //Arrival To 2:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_2PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "2:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "2:00 PM Time - Arrival To");


                                                                //Arrival To 2:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_230PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "2:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "2:30 PM Time - Arrival To");


                                                                //Arrival To 3:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_3PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "3:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "3:00 PM Time - Arrival To");


                                                                //Arrival To 3:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_330PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "3:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "3:30 PM Time - Arrival To");


                                                                //Arrival To 4:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_4PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "4:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "4:00 PM Time - Arrival To");


                                                                //Arrival To 4:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_430PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "4:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "4:30 PM Time - Arrival To");


                                                                //Arrival To 5:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_5PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "5:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "5:00 PM Time - Arrival To");


                                                                //Arrival To 5:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_530PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "5:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "5:30 PM Time - Arrival To");


                                                                //Arrival To 6:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_6PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "6:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "6:00 PM Time - Arrival To");


                                                                //Arrival To 6:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_630PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "6:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "6:30 PM Time - Arrival To");


                                                                //Arrival To 7:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_7PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "7:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "7:00 PM Time - Arrival To");


                                                                //Arrival To 7:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_730PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "7:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "7:30 PM Time - Arrival To");


                                                                //Arrival To 8:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_8PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "8:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "8:00 PM Time - Arrival To");


                                                                //Arrival To 8:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_830PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "8:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "8:30 PM Time - Arrival To");


                                                                //Arrival To 9:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_9PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "9:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "9:00 PM Time - Arrival To");


                                                                //Arrival To 9:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_930PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "9:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "9:30 PM Time - Arrival To");


                                                                //Arrival To 10:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_10PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "10:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "10:00 PM Time - Arrival To");


                                                                //Arrival To 10:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_1030PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "10:30 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "10:30 PM Time - Arrival To");


                                                                //Arrival To 11:00 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_11PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "11:00 PM Time - Arrival To");
                                                                        }
                                                                    else
                                                                            SeleniumReporting.ElementPresentVerification(false, "11:00 PM Time - Arrival To");


                                                                //Arrival To 11:30 PM Dropdown Option Existence Verification
                                                                    if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ArrivalToTime_1130PM_Dropdown))
                                                                        {
                                                                            SeleniumReporting.ElementPresentVerification(true, "11:30 PM Time - Arrival To");
                                                                        }
                                                                    else
    
                                                                        SeleniumReporting.ElementPresentVerification(false, "11:30 PM Time - Arrival To");
                                                        //***********************************************************************************************************

            //Refresh Button Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.RefreshButton))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Refresh Button");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Refresh Button");


            //Search Button Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.SearchButton))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Search Button");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Search Button");


            //Job Number Column Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.JobNumberColumn))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Job Number Column");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Job Number Column");


            //Call Type Column Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.CallTypeColumn))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Call Type Column");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Call Type Column");


            //Agent Reference Column Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.AgentReferenceColumn))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Agent Reference Column");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Agent Reference Column");


            //Vessel Column Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.VesselColumn))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Vessel Column");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Vessel Column");


            //Port Column Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.PortColumn))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Port Column");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Port Column");

            //Voyage No. Column Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.VoyageNoColumn))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Voyage No Column");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Voyage No Column");

            //Status Column Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.StatusColumn))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Status Column");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Status Column");

            //Action Needed Column Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ActionNeededColumn))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "Action Needed Column");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "Action Needed Column");


            //SOF Status Column Existence Verification
                if (InitialAssertion.ifElementIsPresentandVisible(searchPage.SOFStatusColumn))
                    {
                        SeleniumReporting.ElementPresentVerification(true, "SOF Status Column");
                    }
                else
                        SeleniumReporting.ElementPresentVerification(false, "SOF Status Column");


            SetActions.ClickButton(searchPage.ColumnDropdown, "Column Filter Dropdown");
            InitialAssertion.WaitForElementLoad(By.XPath(searchPage.JobNumberCheckbox), 60);

                                            
                                                            //*****COLUMN CHECKBOX******************************************************

                                                                    //Job Number Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.JobNumberCheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "Job Number Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "Job Number Checkbox");


                                                                    //Call Type Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.CallTypeCheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "Call Type Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "Call Type Checkbox");


                                                                    //Agent Reference Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.AgentReferenceCheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "Agent Reference Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "Agent Reference Checkbox");


                                                                    //Vessel Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.VesselCheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "Vessel Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "Vessel Checkbox");


                                                                    //Port Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.PortCheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "Port Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "Port Checkbox");


                                                                    //ETA Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ETACheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "ETA Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "ETA Checkbox");


                                                                    //Voyage No. Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.VoyageNoCheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "Voyage No Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "Voyage No Checkbox");


                                                                    //Status Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.StatusCheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "Status Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "Status Checkbox");


                                                                    //Action Needed Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.StatusCheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "Status Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "Status Checkbox");


                                                                    //SOF Status Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.SOFStatusCheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "SOF Status Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "SOF Status Checkbox");


                                                                    //ACK Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.ACKCheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "ACK Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "ACK Checkbox");


                                                                    //PDA Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.PDACheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "PDA Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "PDA Checkbox");


                                                                    //FDA Checbox Existence Verification
                                                                            if (InitialAssertion.ifElementIsPresentandVisible(searchPage.FDACheckbox))
                                                                                {
                                                                                    SeleniumReporting.ElementPresentVerification(true, "FDA Checkbox");
                                                                                }
                                                                            else
                                                                                    SeleniumReporting.ElementPresentVerification(false, "FDA Checkbox");
        }

//*******************************END_TO_END_TESTING*************************************************//

            public static void SearchForEndToEndJob()
        {
            Excel excel = new Excel(@"C:\Users\edqu01\Documents\GAC Automation\GACShip Agent GIT Repository\ConsoleApp1\TestData\GACShipTestData.xlsx", "TestData");
            GACShip_Agent_LandingPage newpage = new GACShip_Agent_LandingPage();
            SetActions.FillInTextField(excel.ReadDatabyColumnName("GACShip", "EndToEndJob"), newpage.MenuSearchTextField);
            SetActions.ClickButton(newpage.MenuSearchIcon, "Search");
            System.Threading.Thread.Sleep(3000);

            bool existFlag;
            string Xpath = excel.ReadDatabyColumnName("GACShip", "EndToEndJob");
            existFlag = InitialAssertion.ifElementIsPresent(PropertyCollection.Driver, By.XPath("//h3[contains(.,'Acknowledge')]//following-sibling::span[contains(.,'Nominated by Hub')][contains(.,Xpath)]"));
            Assert.AreEqual(true, existFlag);
            excel.Close();
        }

        public static void VerifySideMenuButtons()
        {
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            GACShip_Agent_LandingPage landingpage = new GACShip_Agent_LandingPage();
        
            //Action Needed - Side Menu Buttons Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonActionNeeded))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Action Needed - Side Menu Buttons");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Action Needed - Side Menu Buttons");

            //Search - Side Menu Buttons Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonSearch))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Search - Side Menu Buttons");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Search - Side Menu Buttons");

            //Bank Remit - Side Menu Buttons Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonBankRemit))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Bank Remit - Side Menu Buttons");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Bank Remit - Side Menu Buttons");

            //Recent Jobs - Side Menu Buttons Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonRecentJobs))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Recent Jobs - Side Menu Buttons");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Recent Jobs - Side Menu Buttons");

            //Acknowledge - Side Menu Buttons Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonAcknowledge))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Acknowledge - Side Menu Buttons");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Acknowledge - Side Menu Buttons");

            //PDA - Side Menu Buttons Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonPDA))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "PDA - Side Menu Buttons");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "PDA - Side Menu Buttons");

            //SPDA - Side Menu Buttons Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonSPDA))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "SPDA - Side Menu Buttons");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "SPDA - Side Menu Buttons");

            //SOF - Side Menu Buttons Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonSOF))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "SOF - Side Menu Buttons");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "SOF - Side Menu Buttons");

            //Cargo - Side Menu Buttons Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonCargo))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "Cargo - Side Menu Buttons");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "Cargo - Side Menu Buttons");

            //FDA - Side Menu Buttons Existence Verification
                    if (InitialAssertion.ifElementIsPresentandVisible(landingpage.MenuButtonFDAJobsButton))
                        {
                            SeleniumReporting.ElementPresentVerification(true, "FDA - Side Menu Buttons");
                        }
                    else
                            SeleniumReporting.ElementPresentVerification(false, "FDA - Side Menu Buttons");
        }
    }
}
