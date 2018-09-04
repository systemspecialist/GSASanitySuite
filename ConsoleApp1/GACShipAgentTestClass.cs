using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserActions;
using ExcelUtilities;
using Assertion;
using ReportingUtility;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;

namespace MainTest
{
    [TestFixture]
    class GACtrackTestClass
    {

        [OneTimeSetUp]
        public void StartReports()
        {

            //string reportPath = System.Configuration.ConfigurationManager.AppSettings["ReportPath"] + "\\GACtrackTestReport.html";
            string reportPath = GetActions.GetFileName("ReportPath", ".html");
            PropertyCollection.HTMLReporter = new ExtentHtmlReporter(reportPath);
            PropertyCollection.HTMLReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            PropertyCollection.HTMLReporter.Configuration().ReportName = "Automated Sanity Report";
            PropertyCollection.HTMLReporter.Configuration().DocumentTitle = "GACShip Agent Sanity Testing Report";

            PropertyCollection.ExtentReports = new ExtentReports();
            PropertyCollection.ExtentReports.AddSystemInfo("Host Name", "SGIT-MASH-NB.group.gac");
            PropertyCollection.ExtentReports.AddSystemInfo("Environment", "QA");
            PropertyCollection.ExtentReports.AddSystemInfo("UserName", "Majeeth Shaik");
            PropertyCollection.ExtentReports.AttachReporter(PropertyCollection.HTMLReporter);
        }

        static void Main(string[] args)
        {
            
        }
        
        [SetUp]
        public void Initialize()
        {
            
        }

       
        [Test]
        public void GACSHIP_Agent_Sanity_LaunchApplication()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.VerifyLoginPageObjects();
        }


        [Test]
        public void GACSHIP_Agent_Sanity_LogIn()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.VerifyLandingPageObjects();
        }


        [Test]
        public void GACSHIP_Agent_Sanity_VerifyAcknowledgementRequiredPageObjects()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickExpandAcknowledgementRequiredButton();
            GACShip.TestSteps.ClickFirstAcknowledgementRequiredJob();
            GACShip.TestSteps.VerifyAcknowldegementLandingPageObjects();
        }


        [Test]
        public void GACSHIP_Agent_Sanity_VerifyProformaRequiredPageObjects()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickExpandProformaRequiredButton();
            GACShip.TestSteps.ClickFirstProformaRequiredJob();
            GACShip.TestSteps.VerifyPDALandingPageObject();
        }

        [Test]
        public void GACSHIP_Agent_Sanity_VerifySOFRequiredPageObjects()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickExpandSOFRequiredButton();
            GACShip.TestSteps.ClickFirstSOFRequiredJob();
            GACShip.TestSteps.VerifySOFLandingPageObject();
        }

        [Test]
        public void GACSHIP_Agent_Sanity_VerifyFDARequiredPageObjects()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickExpandFDARequiredButton();
            GACShip.TestSteps.ClickFirstFDARequiredJob();
            GACShip.TestSteps.VerifyFDALandingPageObject();
        }

        [Test]
        public void AcceptAcknowledgmentJob()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.SearchAcknowledgementRequiredJob();
            GACShip.TestSteps.VerifyAcknowldegementLandingPageObjects();
            GACShip.TestSteps.AcceptJobAcknowledgement();
        }

        [Test]
        public void GACSHIP_Agent_Sanity_VerifyCargoTabPageObjects()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickExpandSOFRequiredButton();
            GACShip.TestSteps.ClickFirstSOFRequiredJob();
            GACShip.TestSteps.ClickCargoTabSideBarMenu();
            GACShip.TestSteps.VerifyCargoPageObjects();
        }

        [Test]
        public void GACSHIP_Agent_Sanity_VerifyJobCounts_LandingPage()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickExpandAcknowledgementRequiredButton();
            GACShip.TestSteps.VerifyAcknowledgementRequiredJobCount();
            GACShip.TestSteps.ClickExpandProformaRequiredButton();
            GACShip.TestSteps.VerifyProformaRequiredJobCount();
            GACShip.TestSteps.ClickExpandSOFRequiredButton();
            GACShip.TestSteps.VerifySOFRequiredJobCount();
            GACShip.TestSteps.ClickExpandFDARequiredButton();
            GACShip.TestSteps.VerifyFinalDARequiredJobCount();
        }

        [Test]
        public void GACSHIP_Agent_Sanity_Search_AcknowledgementRequired_Jobs()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickExpandAcknowledgementRequiredButton();
            GACShip.TestSteps.SearchAndVerifyAcknowledgementRequiredJob();
        }

        [Test]
        public void GACSHIP_Agent_Sanity_Search_PDARequired_Jobs()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickExpandProformaRequiredButton();
            GACShip.TestSteps.SearchAndVerifyPDARequiredJob();
        }

        [Test]
        public void GACSHIP_Agent_Sanity_Search_SOFRequired_Jobs()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickExpandSOFRequiredButton();
            GACShip.TestSteps.SearchAndVerifySOFRequiredJob();
        }


        [Test]
        public void GACSHIP_Agent_Sanity_Search_FDARequired_Jobs()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickExpandFDARequiredButton();
            GACShip.TestSteps.SearchAndVerifyFDARequiredJob();
        }

        [Test]
        public void GACSHIP_Agent_Sanity_VerifyBankRemitPageObjects()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickBankRemitTabSideBarMenu();
            GACShip.TestSteps.VerifyBankRemitPageObjects();
            System.Threading.Thread.Sleep(5000);
        }

        [Test]
        public void GACSHIP_Agent_Sanity_VerifySearchPageObjects()
        {
            GACShip.TestSteps.LaunchApplication();
            GACShip.TestSteps.GACShipLoginToApplication();
            GACShip.TestSteps.ClickSearchTabSideBarMenu();
            GACShip.TestSteps.VerifySearchPageObjects();
            System.Threading.Thread.Sleep(5000);
        }


        [TearDown]
        public void GetResult()
        {
            PropertyCollection.Driver.Close();
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>"+TestContext.CurrentContext.Result.StackTrace+"</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                PropertyCollection.ExtentTest.Log(Status.Fail, status + errorMessage);
            }
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {

            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());
            SeleniumReporting.WriteResults(true, "Browser Close");
            PropertyCollection.ExtentReports.Flush();
            //PropertyCollection.Driver.Quit();
            PropertyCollection.Driver.Close();

        }


    }
}
