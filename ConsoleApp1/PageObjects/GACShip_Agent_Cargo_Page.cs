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
    class GACShip_Agent_Cargo_Page
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShip_Agent_Cargo_Page()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//***************************CARGO_PAGE_MAIN_HEADER****************************************************************************************************************

        public String CargoPageHeader = "//div[@class='row heading']//h3[contains(.,'Cargo')]//following-sibling::span";
        public String CargoPageHeaderAsString = "//div[@class='row heading']//h3[contains(.,'Cargo')]//following-sibling::span";
        public String DocumentUploadViewButton = "//button[@data-original-title='Document Upload/View']";
        public String EditButton = "//button[@ng-click='vm.lockOrUnlockJob()']";
        public String ButtonToUnlock = "//button[@ng-click='vm.lockOrUnlockJob()']/i[@class='fa fa-lock ']";
        public String ButtonToLock = "//button[@ng-click='vm.lockOrUnlockJob()']/i[@class='fa fa-unlock ']";
        public String SaveButton = "//button/i[@class='fa fa-save ']";

//***************************CARGO_GRID_COLUMN_HEADER**************************************************************************************************************

        public String TerminalColumnHeader = "//th/a[contains(.,'Terminal')]";
        public String BerthColumnHeader = "//th/a[contains(.,'Berth')]";
        public String CargoTypeColumnHeader = "//th/a[contains(.,'Cargo type')]";
        public String CargoDescriptionColumnHeader = "//th/a[contains(.,'Cargo description')]";
        public String CallPurposeColumnHeader = "//th/a[contains(.,'Call purpose')]";
        public String QtyUOMColumnHeader = "//th/a[contains(.,'Qty. UoM')]";
        public String VolumeUOMColumnHeader = "//th/a[contains(.,'Volume UoM')]";
        public String NominatedQtyColumnHeader = "//th/a[contains(.,'Nominated Qty')]";
        public String NominatedVolumeColumnHeader = "//th[@data-title='Nominated volume']/a";
        public String BoLQtyColumnHeader = "//th/a[contains(.,'BoL Qty')]";
        public String BoLVolumeColumnHeader = "//th/a[contains(.,'BoL volume')]";
        public String BoLDateColumnHeader = "//th/a[contains(.,'BoL date')]";
        public String ShipFiguresQtyColumnHeader = "//th/a[contains(.,'Ship figures Qty')]";
        public String ShipFiguresVolumeColumnHeader = "//th/a[contains(.,'Ship figures volume')]";
        public String ShipFiguresRoBColumnHeader = "//th/a[contains(.,'Ship figures RoB')]";

//***************************Others*********************************************************************************************************************************

        public String AddNewRow = "//button/i[@class='fa fa-plus']";
        public String DeleteRow = "//button/i[@class='fa fa-trash']";

 //*****************************************************************************************************************************************************************
    }
}
