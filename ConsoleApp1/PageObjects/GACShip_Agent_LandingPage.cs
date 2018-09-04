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
    class GACShip_Agent_LandingPage
    {

        //ctor double tab will bring constructor

        public GACShip_Agent_LandingPage()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//**************************************HEADER************************************************************************************************************************

        public String WelcomeNote = "//h3[contains(.,'Welcome to GACship!')]/following-sibling::span[contains(text(),'Please see all your remaining task below')]";
        public String TableHeaderActionNeededLinkButton = "//a[@class='k-link'][contains(.,'Action needed')]";
        public String TableHeaderJobCount = "//a[@class='k-link'][contains(.,'Action needed')]";

//**************************************LEFTSIDEMENU*******************************************************************************************************************

        public String MenuGACLogo = "//li[@class='logo']";
        public String MenuGACShipText = "//a[@href='#/home']/span[contains(text(),'GACship')]";
        public String MenuSearchTextField = "//input[@name='jobnumber']";
        public String MenuSearchIcon = "//button[@id='btnQuickSearch']";
        public String MenuButtonActionNeeded = "//div[@id='aExpandSubmenuList']/div[contains(.,'Action Needed')]";
        public String MenuButtonSearch = "//div[@id='aExpandSubmenuList']/div[contains(.,'Search')]";
        public String MenuButtonBankRemit = "//div[@id='aExpandSubmenuList']/div[contains(.,'Bank Remit')]";
        public String MenuButtonRecentJobs = "//div[@id='aExpandSubmenuList']/div[contains(.,'Recent jobs')]";
        public String MenuButtonJobStatus = "//div[@id='aExpandSubmenuList']/div[contains(.,'Job Status')]";
        public String MenuButtonAcknowledge = "//div[@id='aExpandSubmenuList']/div[contains(.,'Acknowledge')]";
        public String MenuButtonPDA = "//div[@id='aExpandSubmenuList']/div[contains(.,'PDA')]";
        public String MenuButtonSPDA = "//div[@id='aExpandSubmenuList']/div[contains(.,'SPDA')]";
        public String MenuButtonCargo = "//div[@id='aExpandSubmenuList']/div[contains(.,'Cargo')]";
        public String MenuButtonSOFJobsButton = "//div[@class='menu-text'][contains(.,'SOF')]";
        public String MenuButtonSOF = "//div[@id='aExpandSubmenuList']/div[contains(.,'SOF')]";
        public String MenuButtonFDAJobsButton = "//div[@class='menu-text'][contains(.,'FDA')]";
        public String MenuButtonCargoJobsButton = "//div[@class='clickable menu-link active-menu-item']/div[contains(text(),'Cargo')]";

//**************************************MAINTABLE*********************************************************************************************************************

        public String ActionNeededTable = "//div[@class='jobSearchResults margin-top-kendo sm-margin-bottom']";
        public String ActionNeededTableAcknowledgemntRequired = "//div[contains(.,'Acknowledgement Required')]";
        public String ActionNeededTableProformaRequired = "//div[contains(.,'Proforma Required')]";
        public String ActionNeededTableSOFRequired = "//div[contains(.,'SOF Required')]";
        public String ActionNeededTableFinalDARequired = "//div[contains(.,'Final DA Required')]";

//**************************************MAINTABLE_ACKNOWLEDGEMENT_REQUIRED********************************************************************************************

        public String AcknowledgementRequiredHeader = "//div[contains(.,'Acknowledgement Required')]/following-sibling::div[@class='action-needed-right-side ']";
        public String AcknowledgementRequiredJobCount = "//div[contains(.,'Acknowledgement Required')]/following-sibling::div[@class='action-needed-right-side ']";
        public String AcknowledgementRequiredJobNumber = "//span[contains(text(),'Job Number')]/ancestor::tbody//div[contains(text(),'Acknowledgement Required')]";
        public String AcknowledgementRequiredVessel = "//span[contains(text(),'Vessel')]/ancestor::tbody//div[contains(text(),'Acknowledgement Required')]";
        public String AcknowledgementRequiredPort = "//span[contains(text(),'Port')]/ancestor::tbody//div[contains(text(),'Acknowledgement Required')]";
        public String AcknowledgementRequiredETA = "//span[contains(text(),'ETA')]/ancestor::tbody//div[contains(text(),'Acknowledgement Required')]";
        public String AcknowledgementRequiredPrincipal = "//span[contains(text(),'Principal')]/ancestor::tbody//div[contains(text(),'Acknowledgement Required')]";
        public String AcknowledgementRequiredStatus = "//span[contains(text(),'Status')]/ancestor::tbody//div[contains(text(),'Acknowledgement Required')]";

//**************************************MAINTABLE_PROFORMA_REQUIRED***************************************************************************************************

        public String ProformaRequiredHeader = "//div[contains(.,'Proforma Required')]/following-sibling::div[@class='action-needed-right-side ']";
        public String ProformaRequiredJobCount = "//div[contains(.,'Proforma Required')]/following-sibling::div[@class='action-needed-right-side ']";
        public String ProformaRequiredJobNumber = "//span[contains(text(),'Job Number')]/ancestor::tbody//div[contains(text(),'Proforma Required')]";
        public String ProformaRequiredVessel = "//span[contains(text(),'Vessel')]/ancestor::tbody//div[contains(text(),'Proforma Required')]";
        public String ProformaRequiredPort = "//span[contains(text(),'Port')]/ancestor::tbody//div[contains(text(),'Proforma Required')]";
        public String ProformaRequiredETA = "//span[contains(text(),'ETA')]/ancestor::tbody//div[contains(text(),'Proforma Required')]";
        public String ProformaRequiredPrincipal = "//span[contains(text(),'Principal')]/ancestor::tbody//div[contains(text(),'Proforma Required')]";
        public String ProformaRequiredStatus = "//span[contains(text(),'Status')]/ancestor::tbody//div[contains(text(),'Proforma Required')]";

//**************************************MAINTABLE_SOF_REQUIRED*********************************************************************************************************

        public String SOFRequiredHeader = "//div[contains(.,'SOF Required')]/following-sibling::div[@class='action-needed-right-side ']";
        public String SOFRequiredJobCount = "//div[contains(.,'SOF Required')]/following-sibling::div[@class='action-needed-right-side ']";
        public String SOFRequiredJobNumber = "//span[contains(text(),'Job Number')]/ancestor::tbody//div[contains(text(),'SOF Required')]";
        public String SOFRequiredVessel = "//span[contains(text(),'Vessel')]/ancestor::tbody//div[contains(text(),'SOF Required')]";
        public String SOFRequiredPort = "//span[contains(text(),'Port')]/ancestor::tbody//div[contains(text(),'SOF Required')]";
        public String SOFRequiredETA = "//span[contains(text(),'ETA')]/ancestor::tbody//div[contains(text(),'SOF Required')]";
        public String SOFRequiredPrincipal = "//span[contains(text(),'Principal')]/ancestor::tbody//div[contains(text(),'SOF Required')]";
        public String SOFRequiredStatus = "//span[contains(text(),'Status')]/ancestor::tbody//div[contains(text(),'SOF Required')]";

 //**************************************MAINTABLE_DFA_REQUIRED************************************************************************************************************

        public String FinalDARequiredHeader = "//div[contains(.,'Final DA Required')]/following-sibling::div[@class='action-needed-right-side ']";
        public String FinalDARequiredJobCount = "//div[contains(.,'Final DA Required')]/following-sibling::div[@class='action-needed-right-side ']";
        public String FDARequiredJobNumber = "//span[contains(text(),'Job Number')]/ancestor::tbody//div[contains(text(),'Final DA Required')]";
        public String FDARequiredVessel = "//span[contains(text(),'Vessel')]/ancestor::tbody//div[contains(text(),'Final DA Required')]";
        public String FDARequiredPort = "//span[contains(text(),'Port')]/ancestor::tbody//div[contains(text(),'Final DA Required')]";
        public String FDARequiredETA = "//span[contains(text(),'ETA')]/ancestor::tbody//div[contains(text(),'Final DA Required')]";
        public String FDARequiredPrincipal = "//span[contains(text(),'Principal')]/ancestor::tbody//div[contains(text(),'Final DA Required')]";
        public String FDARequiredStatus = "//span[contains(text(),'Status')]/ancestor::tbody//div[contains(text(),'Final DA Required')]";

//**************************************MAINTABLE_EXPAND_BUTTONS************************************************************************************************************

        public String ExpandAcknowldegementRequired = "//div[contains(text(),'Acknowledgement Required')]/ancestor::td/p/a[@class='k-icon k-i-expand']";
        public String ExpandProformaRequired = "//div[contains(text(),'Proforma Required')]/ancestor::td/p/a[@class='k-icon k-i-expand']";
        public String ExpandSOFRequired = "//div[contains(text(),'SOF Required')]/ancestor::td/p/a[@class='k-icon k-i-expand']";
        public String ExpandFinalDARequired = "//div[contains(text(),'Final DA Required')]/ancestor::td/p/a[@class='k-icon k-i-expand']";
        public String NominatedByHub = "//span[contains(.,'Nominated by Hub')]";

//**************************************MAINTABLE_EXPAND_BUTTONS************************************************************************************************************

        public String FirstAcknowledgementRequiredJob = "//div[contains(text(),'Acknowledgement Required')]/ancestor::tr/following-sibling::tr[2]//a[@class='clickable']";
        public String FirstProformaRequiredJob = "//div[contains(text(),'Proforma Required')]/ancestor::tr/following-sibling::tr[2]//a[@class='clickable']";
        public String FirstSOFRequiredJob = "//div[contains(text(),'SOF Required')]/ancestor::tr/following-sibling::tr[2]//a[@class='clickable']";
        public String FirstFinalDARequiredJob = "//div[contains(text(),'Final DA Required')]/ancestor::tr/following-sibling::tr[2]//a[@class='clickable']";

//***************************************************************************************************************************************************************************

    }
}
