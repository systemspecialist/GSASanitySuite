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
    class GACShipLandingPage
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShipLandingPage()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }
 

        [FindsBy(How = How.XPath, Using = "//h3[contains(.,'Welcome to GACship!')]")]
        public IWebElement WelcomeNote { get; set; }


        [FindsBy(How = How.XPath, Using = "//li[@class='logo']")]
        public IWebElement GACLogo { get; set; }

        [FindsBy(How = How.Name, Using = "jobnumber")]
        public IWebElement SearchTextField { get; set; }

        [FindsBy(How = How.Id, Using = "btnQuickSearch")]
        public IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='aExpandSubmenuList']/div[contains(.,'Action Needed')]")]
        public IWebElement MenuButtonActionNeeded { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='aExpandSubmenuList']/div[contains(.,'Search')]")]
        public IWebElement MenuButtonSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='aExpandSubmenuList']/div[contains(.,'Bank Remit')]")]
        public IWebElement MenuButtonBankRemit { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='aExpandSubmenuList']/div[contains(.,'Recent jobs')]")]
        public IWebElement MenuButtonRecentJobs { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='k-link'][contains(.,'Action needed')]")]
        public IWebElement MainTableActionNeededLinkButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='jobSearchResults margin-top-kendo sm-margin-bottom']")]
        public IWebElement ActionNeededTable { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(.,'Acknowledgement Required')]/following-sibling::div[@class='action-needed-right-side ']")]
        public IWebElement CountOfAcknowledgementRequired { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Nominated by Hub')]")]
        public IWebElement NominatedByHub { get; set; }
        
    }
}
