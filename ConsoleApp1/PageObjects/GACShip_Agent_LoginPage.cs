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
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;

namespace PageObjects
{
    class GACShip_Agent_LoginPage
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShip_Agent_LoginPage()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//******KEY_BUTTONS**************************************************************************************************************************************

        public String Username = "//input[@id='Username']";
        public String Password = "//input[@id='Password']";
        public String LogInButton = "//input[@id='btnSignIn']";
        public String RegisterButton = "//input[@value='Register']";

 //******LOGO_AND_TEXT*************************************************************************************************************************************

        public String GACShipText = "//h3[contains(.,'GACship')]";
        public String GACShipLogo = "//h3/img[@class='logo-img']";

//******BIG_HEADERS*************************************************************************************************************************************

        public String SignInText = "//h1[contains(.,'Sign In')]";
        public String GlobalHubServiceText = "//h1[contains(.,'Global Hub Services')]";

//******LEGENDS_AND_LINKS*************************************************************************************************************************************

        public String TermsOfUse = "//h4[contains(text(),'By clicking Sign In, you agree to the')]/a[@href=''][contains(.,'Terms of use')]";
        public String QuickLinks = "//h4[contains(text(),'Quick Links')]";
        public String GACLink = "//h4/a[@href='http://www.gac.com'][contains(.,'GAC')]";
        public String SupportLink = "//h4/a[@href=''][contains(.,'Support')]";
        public String ForgotPasswordLink = "//h4/a[@href='/TestAzure/Gac.Ship.GS5.Web/Account/#forgotpassword'][contains(.,'Forgot Password')]";

//******INSIDE_TABLE*****************************************************************************************************************************************        

        public String Paragraph = "//div[@class='company-info col-lg-6']/p[contains(text(),'Global Hub Services provides a full range')]/following-sibling::p[contains(text(),'We’ll give you access to one vetted and')]";
        public String OurServiceInclude = "//h3[contains(.,'Our services include:')]";
        public String HUBAGENCY = "//div/img[@src='/TestAzure/Gac.Ship.GS5.Web/Content/images/hub-agency.png']/ancestor::div[@class='services']//h5[contains(.,'HUB AGENCY')]/following-sibling::p[contains(text(),'Proven concept of providing ship agency')]";
        public String DAMANAGEMENT ="//div/img[@src='/TestAzure/Gac.Ship.GS5.Web/Content/images/da-managment.png']/ancestor::div[@class='services']//h5[contains(.,'DA MANAGEMENT')]/following-sibling::p[contains(text(),'Managing all the port call disbursement')]";
        public String HUSBANDRY = "//div/img[@src='/TestAzure/Gac.Ship.GS5.Web/Content/images/husbandry.png']/ancestor::div[@class='services']//h5[contains(.,'HUSBANDRY')]/following-sibling::p[contains(text(),'Delivering services to keep your vessels')]";
        public String PORTONDEMAND = "//div/img[@src='/TestAzure/Gac.Ship.GS5.Web/Content/images/on-demand.png']/ancestor::div[@class='services']//h5[contains(.,'PORT ON DEMAND')]/following-sibling::p[contains(text(),'One trusted global agency network')]";
        public String CENTRALSERVICES = "//div/img[@src='/TestAzure/Gac.Ship.GS5.Web/Content/images/back-office.png']/ancestor::div[@class='services']//h5[contains(.,'CENTRAL SERVICES')]/following-sibling::p[contains(text(),'Our streamlined office support services')]";
        public String LandingPageHeader = "//h3[contains(.,'Welcome to GACship!')]/following-sibling::span[contains(text(),'Please see all your remaining task below')]";
        public String LoginPageLogoAndText = "//h3[contains(.,'GACship')]/img[@src='/TestAzure/Gac.Ship.GS5.Web/Content/images/GAC_white.png']";

//******INNER_METHODS*****************************************************************************************************************************************        

        public GACShip_Agent_LandingPage GACShipLoginToApplication()
        {
            GACShip_Agent_LoginPage loginPage = new GACShip_Agent_LoginPage();
            Excel excel = new Excel(@"C:\Users\edqu01\Documents\GAC Automation\GACShip Agent Automation - August-31\ConsoleApp1\TestData\GACShipTestData.xlsx", "LogIn");
            PropertyCollection.ChildTest = PropertyCollection.ExtentTest.CreateNode(GetActions.GetMyMethodName());

            //Checks first if element is present then type in the Username
                    if (InitialAssertion.ifElementIsPresentandVisible(loginPage.Username) == true)
                            {
                                SetActions.FillInTextField((excel.ReadDatabyColumnName("GACShip", "UserName")), loginPage.Username);
                                SeleniumReporting.ElementPresentVerification(true, "UserName Text Field");
                                SeleniumReporting.WriteMessageOnTheReport("Username was typed in the text field.");
                            }
                    else
                            {
                                SeleniumReporting.ElementPresentVerification(false, "UserName Text Field");
                            }

            //Checks first if element is present then type in the Password
                    if (InitialAssertion.ifElementIsPresentandVisible(loginPage.Password) == true)
                            {
                                SetActions.FillInTextField((excel.ReadDatabyColumnName("GACShip", "Password")), loginPage.Password);
                                SeleniumReporting.ElementPresentVerification(true, "PassWord Text Field");
                                SeleniumReporting.WriteMessageOnTheReport("Password was typed in the text field.");
                            }
                    else
                            {
                                SeleniumReporting.ElementPresentVerification(false, "PassWord Text Field");
                            }

            SetActions.ClickButton(loginPage.LogInButton, "LogIn");
            excel.Close();

            GACShip_Agent_LandingPage landingPage = new GACShip_Agent_LandingPage();
            InitialAssertion.WaitForElementLoad(By.XPath(LandingPageHeader), 30);

            return new GACShip_Agent_LandingPage();

//************************************************************************************************************************************************************************        

        }

    }
}
