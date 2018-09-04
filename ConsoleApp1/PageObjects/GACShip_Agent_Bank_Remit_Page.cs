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
    class GACShip_Agent_Bank_Remit_Page
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShip_Agent_Bank_Remit_Page()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//******BANK_REMIT_PAGE_MAIN_HEADER************************************************************************************************************************************

        public String BankRemitHeader = "//h3[contains(.,'Bank Remit')]";
        public String PaymentDateFrom = "//span/input[@id='PaymentDateFrom']";
        public String PaymentDateTo = "//span/input[@id='PaymentDateTo']";
        public String JobNumber = "//div/input[@name='JobNumber']";
        public String AdviceRefNumber = "//div/input[@name='AdviceRefNumber']";

//******BANK_REMIT_PAGE_BUTTONS************************************************************************************************************************************

        public String RefreshButton = "//button/span[contains(.,'Refresh')]";
        public String SearchButton = "//button/span[contains(.,'Search')]";

//******BANK_REMIT_MAIN_TABLE************************************************************************************************************************************

        public String NameColumn_MT = "//th[contains(.,'Name')]";
        public String KnownAsColumn_MT = "//th[contains(.,'Known As')]";
        public String HSBCReferenceColumn_MT = "//th[contains(.,'HSBC Reference')]";
        public String PaymentDateColumn_MT = "//th[contains(.,'Payment Date')]";
        public String CurrenyColumn_MT = "//div[@ng-show='vm.grid.isInitialized']//th[contains(.,'Currency')]";
        public String DebitAmountColumn_MT = "//th[contains(.,'Debit Amount')]";
        public String CreatedOnColumn_MT = "//th[contains(.,'Created On')]";

//******BANK_REMIT_BOTTOM_TABLE************************************************************************************************************************************

        public String JobNumberColumn_BT = "//th[contains(.,'Job Number')]";
        public String VoyageNumberColumn_BT = "//th[contains(.,'Voyage Number')]";
        public String VesselColumn_BT = "//th[contains(.,'Vessel')]";
        public String IMONumberColumn_BT = "//th[contains(.,'IMO Number')]";
        public String PortColumn_BT = "//th[contains(.,'Port')]";
        public String PortAgentColumn_BT = "//th[contains(.,'Port Agent')]";
        public String CurrencyColumn_BT = "//div[@class='grid-extra-margin-bottom']//th[contains(.,'Currency')]";
        public String AmountColumn_BT = "//th[contains(.,'Amount')]";
        public String ETAColumn_BT = "//th[contains(.,'ETA')]";
        public String ATAColumn_BT = "//th[contains(.,'ATA')]";
        public String ATDColumn_BT = "//th[contains(.,'ATD')]";
        public String PrincipalColumn_BT = "//th[contains(.,'Principal')]";
        public String JobTypeColumn_BT = "//th[contains(.,'JobType')]";
        public String HUBPICColumn_BT = "//th[contains(.,'HUB PIC')]";

//******BANK_REMIT_DISCLAIMER************************************************************************************************************************************

        public String Disclaimer_BT = "//div[@ng-if='vm.data.Disclaimer']//div[contains(.,'Disclaimer')]";
        
//***************************************************************************************************************************************************************
    }
}
