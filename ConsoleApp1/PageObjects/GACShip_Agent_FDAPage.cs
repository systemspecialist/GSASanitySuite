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
    class GACShip_Agent_FDAPage
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShip_Agent_FDAPage()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//**************************PDA_PAGE_MAIN_HEADER************************************************************************************************************************************

        public String FDAPageHeader = "//h3[contains(.,'FDA')]//following-sibling::job-summary//span[contains(.,'Proforma Submitted')]";
        public String FDAPageJobNumber = "//div[@ng-show='!vm.isLoading']/span";
        public String FDADatesPlaceHolder = "//div[contains(text(),'FDA Dates')]";
        public String LockButton = "//button[@ng-click='vm.lockOrUnlockJob()']";
        public String DownloadSOFReportButton = "//i[@class='fa fa-download ']";
        public String SaveButton = "//button/i[@class='fa fa-save']";
        public String SubmitButton = "//button[@class='btn anchor-btn']/span[contains(.,'Submit')]";

//*******************PDA_PAGE_VIEWTYPE_AND_COLUMN_DROPDOWN***********************************************************************************************************************

        public String ViewTypeHeader = "//label[contains(text(),'View Type')]";
        public String ViewTypeDropdown = "//label[contains(text(),'View Type')]/following-sibling::span/span";
        public String ViewTypeDropdownSelectViewPDA = "//li[contains(text(),'View PDA')]";
        public String ViewTypeDropdownSelectViewWithoutPDA = "//li[contains(text(),'View without PDA')]";
        public String ColumnHeader = "//div[contains(text(),'Columns')]";
        public String ColumnHeaderDropdown = "//div[contains(text(),'Columns')]/span";
        public String ColumnDropdownDescription = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Description')]";
        public String ColumnDropdownPaidTo = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Paid To')]";
        public String ColumnDropdownPaidBy = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Paid By')]";
        public String ColumnDropdownCurrency = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Currency')]";
        public String ColumnDropdownFXRate = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'FX. Rate')]";
        public String ColumnDropdownQuantity = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Quantity')]";
        public String ColumnDropdownUnitPrice = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Unit Price')]";
        public String ColumnDropdownAmount = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Amount')]";
        public String ColumnDropdownUSDUnitPrice = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'USD Unit Price')]";
        public String ColumnDropdownUSDAmount = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'USD amount')]";
        public String ColumnDropdownVATType = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'VAT Type')]";
        public String ColumnDropdownVATRate = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'VAT Rate')]";
        public String ColumnDropdownVATAmountUSD = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'VAT Amount (USD)')]";
        public String ColumnDropdownVATAmountWithVATUSD = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Total Amount with VAT (USD)')]";
        public String ColumnDropdownRebillable = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Rebillable')]";
        public String ColumnDropdownRemarks = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Remarks')]";
        public String ColumnDropdownIncidentNoPONo = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Indent No./PO No.')]";
        public String ColumnDropdownInvoiceNo = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Invoice No.')]";
        public String ColumnDropdownVoucherNo = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Voucher No.')]";
        public String ColumnDropdownProject = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Project')]";
        public String ColumnDropdownRequestedBy = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Requested By')]";
        public String ColumnDropdownVendorDetail = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Vendor Detail')]";
        public String ColumnDropdownCreatedBy = "//li[@ng-repeat='column in vm.grid.metadata.columns']//span[contains(text(),'Created By')]";

//********************EDIT_DETAILS*************************************************************************************************************************************************

        public String FDAPageCheckAllButton = "//input[@id='check-all']";
        public String FDAPageFirstCheckBoxFDAJobs = "(//tbody[@role='rowgroup']//td/input[@class='checkbox'])[1]";
        public String FDAJobEditButton = "//i[@class='fa fa-lock ']";
        public String FDAJobNotEditableButton = "//i[@class='fa fa-unlock ']";

//********************FDA_DATES_BUTTON*********************************************************************************************************************************************

        public String FDADateMissingModalConfirmButton = "//div[@class='modal-content']//button[@class='btn btn-submit pull-right']";
        public String FDADatesDropdown = "//div[@class='panel-heading']/i";
        public String ETAOfFDAJob = "//input[@id='Eta']";
        public String ETDOfFDAJob = "//input[@id='Etd']";
        public String ETBOfFDAJob = "//input[@id='Etb']";
        public String ATAOfFDAJob = "//input[@id='Ata']";
        public String ATDOfFDAJob = "//input[@id='Atd']";
        public String ATBOfFDAJob = "//input[@id='Atb']";
        public String FDAPageToggleOnFirstRemarks = "//tbody[@role='rowgroup']//a[@class='remarks-toggle fa fa-caret-right']";
        public String FDAPageFirstRebillableRemarks = "//label[@for='RebillableRemarks']/following-sibling::input";
        public String FDAPageFirstAgentRemarks = "//label[@for='AgentRemarks']/following-sibling::input";
        public String FDAPageDisclaimerModalCheckbox = "//div[@class='checkbox agree-checkbox']//input[@type='checkbox']";
        public String FDAPageDisclaimerModalSubmitButton = "//div[@class='row footer']/button[contains(.,'Submit')]";
        public String FDASuccessfullySubmittedMessage = "//span[contains(.,'FDA successfully submitted!')]";
        public String FDARequiredHeader = "//h3[contains(.,'FDA')]//following-sibling::job-summary//span[contains(.,'Proforma Submitted')]";

//*******************************************************************************************************************************************************************

    }
}
