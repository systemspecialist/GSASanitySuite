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
    class GACShipPDAPage
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShipPDAPage()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//***********************PDA_PAGE_MAIN_HEADER******************************************************************************************************************************************

        public String PDAPageHeader = "//h3[contains(.,'PDA')]//following-sibling::job-summary//span[contains(.,'Acknowledged by PA')]";
        public String PDAPageJobNumber = "//div[@ng-show='!vm.isLoading']/span";
        public String PDAPageSubmitButton = "//button[@class='btn anchor-btn']/span[contains(.,'Submit')]";
        public String PDAPageSaveButton = "//button[@data-original-title='Save']";
        public String PDAPageExportToExcelButton = "//button[@data-original-title='Export to Excel']";
        public String PDALockButton = "//button[@ng-click='vm.lockOrUnlockJob()']";
        public String PDAJobEditButton = "//i[@class='fa fa-lock ']";
        public String PDAJobNotEditableButton = "//i[@class='fa fa-unlock ']";

//***********************PDA_PAGE_EXPECTED_DATES****************************************************************************************************************************************

        public String PDAPageExpectedDates = "//div[@class='panel-heading'][contains(.,'Expected dates')]";
        public String PDAPageExpectedDatesExpand = "//div[@class='panel-heading'][contains(.,'Expected dates')]/i[@class='pull-right glyphicon glyphicon-chevron-down']";
        public String PDAPageExpectedDatesCollapse = "//div[@class='panel-heading'][contains(.,'Expected dates')]/i[@class='pull-right glyphicon glyphicon-chevron-up']";
        public String PDAPageExpectedDatesETA = "//input[@id='Eta']";
        public String PDAPageExpectedDatesETD = "//input[@id='Etd']";
        public String PDAPageExpectedDatesETB = "//input[@id='Etb']";

//***********************PDA_PAGE_CHECK_BOX_BUTTONS*************************************************************************************************************************************

        public String PDAPageCheckAllButton = "//input[@id='check-all']";
        public String PDAPageFirstCheckBoxPDAJobs = "(//tbody[@role='rowgroup']//td/input[@class='checkbox'])[1]";

//***********************PDA_PAGE_MAIN_HEADER*******************************************************************************************************************************************

        public String PDAPageVersionDescription = "//th[@data-title='Description']";
        public String PDAPageVersionProvider = "//th[@data-title='Provider']";
        public String PDAPageVersionPaidBy = "//th[@data-title='Paid by']";
        public String PDAPageVersionCurrency = "//th[@data-title='Currency']";
        public String PDAPageVersionQuantity = "//th[@data-title='Quantity']";
        public String PDAPageVersionUSDUnitPrice = "//th[contains(.,'USD Unit Price')]";
        public String PDAPageVersionUSDAmount = "//th[contains(.,'USD amount')]";

//************************PDA_PAGE_MAIN_HEADER************************************************************************************************************************************

        public String PDAPageDisclaimerModalCheckbox = "//div[@class='checkbox agree-checkbox']//input[@type='checkbox']";
        public String PDAPageDisclaimerModalSubmitButton = "//div[@class='row footer']/button[contains(.,'Submit')]";

//************************ADDITIONAL_ROW*******************************************************************************************************************************************

        public String PDAPageAddNewRowButton = "//button[@data-original-title='Add New Row']";
        public String PDAPageAddedNewRowDescription = "//td[3]//div[@class='k-dropdown-wrap form-control']/input";
        public String PDAPageAddedNewRowDescriptionTextField = "//input[@name='PrncpServCode_input']";
        public String PDAPageSelectAnchorageDuesFromDropdown = "//ul[@id='PrncpServCode_listbox']/li[1]";

//************************VALIDATION_MESSAGES****************************************************************************************************************************************

        public String PDASuccessfullySubmittedMessage = "//span[contains(.,'PDA successfully submitted!')]";
        public string ProformaPageHeader = "//h3[contains(.,'PDA')]//following-sibling::job-summary//span[contains(.,'Acknowledged by PA')]";

//*****************************************************************************************************************************************************************

    }
}
