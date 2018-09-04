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
    class GACShip_Agent_SOFPage
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShip_Agent_SOFPage()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//***************************SOF_PAGE_MAIN_HEADER************************************************************************************************************************************

        public String SOFPageHeader = "//div[@class='row heading']//h3[contains(.,'SOF')]//following-sibling::span[contains(text(),'SOF Missing')]";
        public String SOFPageJobNumber = "//div[@class='col-sm-12 col-xs-12']/span";
        public String SOFTimingPlaceHolder = "//div[contains(text(),'SOF Timings')]";
        public String LockButton = "//button[@ng-click='vm.lockOrUnlockJob()']";
        public String DownloadSOFReportButton = "//i[@class='fa fa-download']";
        public String DocumentUploadViewButton = "//button[@data-original-title='Document Upload/View']";
        public String SaveButton = "//button/i[@class='fa fa-save']";
        public String SubmitButton = "//button[@class='btn anchor-btn']/span[contains(.,'Submit')]";

//***************************EDIT_DETAILS**********************************************************************************************************************************************

        public String PageCheckAllButton = "//input[@id='check-all']//ancestor::div[@class='tab-content']/div[1]";
        public String PageFirstCheckBoxFDAJobs = "(//tbody[@role='rowgroup']//td/input[@class='checkbox'])[1]";
        public String JobEditButton = "//i[@class='fa fa-lock ']";
        public String JobUnlockButton = "//i[@class='fa fa-unlock ']";

//***************************SOF_DATES_BUTTON*******************************************************************************************************************************************

        public String SOFDateMissingModalConfirmButton = "//div[@class='modal-content']//button[@class='btn btn-submit pull-right']";
        public String SOFDatesDropdown = "//div[@class='panel-heading']/i";
        public String ETAOfSOFJob = "//input[@id='Eta']";
        public String ETDOfSOFJob = "//input[@id='Etd']";
        public String ETBOfSOFJob = "//input[@id='Etb']";
        public String ATAOfSOFJob = "//input[@id='Ata']";
        public String ATDOfSOFJob = "//input[@id='Atd']";
        public String ATBOfSOFJob = "//input[@id='Atb']";
        public String NoticeOfReadinessOfSOFJob = "//input[@id='NoticeOfReadiness.Started']";
        public String CommencedStartedOfSOFJob = "//input[@id='Commenced.Started']";
        public String AnchoredStartedOfSOFJob = "//input[@id='Anchored.Started']";
        public String CompletedStartedOfSOFJob = "//input[@id='Completed.Started']";
        public String AllFastStartedOfSOFJob = "//input[@id='AllFast.Started']";

//****************************SOF_RADIO_BUTTON************************************************************************************************************************************

        public String HSSEIncidentHeaderOfSOFJob = "//label[@class='control-label'][contains(.,'HSSE Incident')]";
        public String HSSEYesRadioButtonOfSOFJob = "//label[@class='radio-inline']/input[@name='hsse'][@value='true']";
        public String HSSENoRadioButtonOfSOFJob = "//label[@class='radio-inline']/input[@name='hsse'][@value='false']";
        public String CustomerComplaintHeaderOfSOFJob = "//label[@class='control-label'][contains(.,'Customer Complaint')]";
        public String CustomerCompliantYesRadioButtonOfSOFJob = "//label[@class='radio-inline']/input[@name='CustomerComplaint'][@value='true']";
        public String CustomerCompliantNoRadioButtonOfSOFJob = "//label[@class='radio-inline']/input[@name='CustomerComplaint'][@value='false']";
        public String OtherFeedbackHeaderOfSOFJob = "//label[@class='control-label'][contains(.,'Other Feedback')]";
        public String OtherFeedbackYesRadioButtonOfSOFJob = "//label[@class='radio-inline']/input[@name='OtherFeedback'][@value='true']";
        public String OtherFeedbackNoRadioButtonOfSOFJob = "//label[@class='radio-inline']/input[@name='OtherFeedback'][@value='false']";

//*****************************SOF_ARRIVAL_REMARKS************************************************************************************************************************************

        public String ArrivalRemarksHeaderOfSOFJob = "//label[@class='control-label'][contains(.,'Arrival Remarks')]";
        public String ArrivalRemarksTextAreaOfSOFJob = "//label[@class='control-label'][contains(.,'Arrival Remarks')]//following-sibling::textarea";

//*****************************SOF_EVENTS_AND_DETAILS_TAB************************************************************************************************************************************

        public String AddNewRowButton = "//button[@class='btn btn-default']/i[@class='fa fa-plus']";
        public String SOFEventsAndDetailsTabButton = "//a[contains(.,'SOF events and details')]";

        //******Description*******//

        public String SOFEventsAndDetailsDescription = "//div[@class='tab-content']/div[1]//th[@data-title='Description']";
        public String DescriptionDropdownSOFEventsAndDetails = "//td[2]//span[@class='k-icon k-i-arrow-s']";
        public String SelectCommencedUllagingInSOFEventDropdown = "//li[contains(.,'Commenced Ullaging')]";

        //******Event Date*******//

        public String SOFEventsAndDetailsEventDate = "//div[@class='tab-content']/div[1]//th[@data-title='Event Date']";
        public String SOFEventDate = "//input[@id='Started']";

        //******Unit*******//

        public String SOFEventsAndDetailsUnit = "//div[@class='tab-content']/div[1]//th[@data-title='Unit']";
        public String SelectDateInSOFUnitDropdown = "//li[contains(.,'Date')]";
        public String UnitDropdownSOFEventsAndDetails = "//td[4]//span[@class='k-icon k-i-arrow-s']";

        //******Quantity*******//

        public String SOFEventsAndDetailsQuantity = "//div[@class='tab-content']/div[1]//th[@data-title='Quantity']";
        public String SOFEventQuantity = "//div[@k-ng-delay='vm.eventsGrid']//input[@name='Quantity']";

        //******Cargo*******//

        public String SOFEventsAndDetailsCargo = "//div[@class='tab-content']/div[1]//th[@data-title='Cargo']";
        public String CargoDropdownSOFEventsAndDetails = "//td[6]//span[@class='k-icon k-i-arrow-s']";
        public String SelectGeneralInSOFCargoDropdown = "//li[contains(.,'GENERAL')]";

        //******Remarks*******//

        public String SOFEventsAndDetailsRemarks = "//div[@class='tab-content']/div[1]//th[@data-title='Remarks']";
        public String SOFPageToggleOnFirstRemarks = "//tbody[@role='rowgroup']//a[@class='remarks-toggle fa fa-caret-right']";
        public String SOFPageFirstRebillableRemarks = "//label[@for='RebillableRemarks']/following-sibling::input";
        public String SOFPageFirstAgentRemarks = "//label[@for='AgentRemarks']/following-sibling::input";
        public String SOFEventRemarks = "//div[@k-ng-delay='vm.eventsGrid']//input[@name='Remarks']";

        //******DISCLAIMER_MODAL************************************************************************************************************************************

        public String SOFPageDisclaimerModalCheckbox = "//div[@class='checkbox agree-checkbox']//input[@type='checkbox']";
        public String SOFPageDisclaimerModalSubmitButton = "//div[@class='row footer']/button[contains(.,'Submit')]";
        public String SOFPageFirstCheckBoxSOFJobs = "(//tbody[@role='rowgroup']//td/input[@class='checkbox'])[1]";

        //******ARRIVAL_DETAILS_TAB************************************************************************************************************************************

        public String ArrivalDetailsTabButton = "//a[contains(.,'Arrival details')]";
        public String AddNewRowArrivalDetailsTab = "//div[@class='tab-content']/div[2]//button[@class='btn btn-default gs-btn-icon']/i[@class='fa fa-plus']";

        //******Description*******//

        public String ArrivalDetailsDescription = "//div[@class='tab-content']/div[2]//th[@data-title='Description']";
        public String ArrivalDetailsDescriptionDropdown = "//td[2]//span[@class='k-icon k-i-arrow-s']";
        public String ArrivalDetailsDescriptionTextField = "//td[2]//span[@unselectable='on']/input";
        public String ArrivalDetailsDescriptionDropdownSelectIPOOnArrival = "//li[contains(.,'IFO on arrival')]";

        //******Unit*******//

        public String ArrivalDetailsUnit = "//div[@class='tab-content']/div[2]//th[@data-title='Unit']";
        public String UnitDropdownArrivalDetails = "//td[3]//span[@class='k-icon k-i-arrow-s']";
        public String SelectKiloTonnesInArrivalDetailsUnitDropdown = "//li[contains(.,'Date')]";

        //******Quantity*******//

        public String ArrivalDetailsQuantity = "//div[@class='tab-content']/div[2]//th[@data-title='Quantity']";
        public String Nuve = "//div[@class='tab-content']/div[2]//th[@data-title='Quantity']";
        public String ArrivalDetailsQuantityTextField = "//div[@k-ng-delay='vm.arrivalGrid']//input[@name='Quantity']";

        //******Purpose*******//

        public String ArrivalDetailsPurpose = "//div[@class='tab-content']/div[2]//th[@data-title='Purpose']";
        public String PurposeDropdownArrivalDetails = "//td[5]//span[@class='k-icon k-i-arrow-s']";
        public String ArrivalDetailsPurposeDropdownSelectROBInSOF = "//li[contains(.,'ROB')]";

        //******Remarks*******//

        public String ArrivalDetailsRemarks = "//div[@class='tab-content']/div[2]//th[@data-title='Remarks']";
        public String ArrivalDetailsRemarksTextField ="//div[@k-ng-delay='vm.arrivalGrid']//input[@name='Remarks']";

        //******DEPARTURE_DETAILS_TAB************************************************************************************************************************************

        public String DepartureDetailsTabButton = "//a[contains(.,'Departure Details')]";
        public String AddNewRowDepartureDetailsTab = "//div[@class='tab-content']/div[3]//button[@class='btn btn-default gs-btn-icon']/i[@class='fa fa-plus']";

        //******Description*******//

        public String DepartureDetailsDescription = "//div[@class='tab-content']/div[3]//th[@data-title='Description']";
        public String DepartureDetailsDescriptionDropdown = "//td[3]//span[@class='k-icon k-i-arrow-s']";
        public String DepartureDetailsDescriptionTextField = "//td[3]//span[@unselectable='on']/input";
        public String DepartureDetailsDescriptionDropdownSelectIPOOnDeparture = "//li[contains(.,'IFO on departure')]";

        //******Unit*******//

        public String DepartureDetailsUnit = "//div[@class='tab-content']/div[3]//th[@data-title='Unit']";
        public String ArrivalDetailsUnitDropdown = "//td[3]//span[@class='k-icon k-i-arrow-s']";
        public String SelectKiloTonnesInDepartureDetailsUnitDropdown = "//li[contains(.,'Date')]";

        //******Quantity*******//

        public String DepartureDetailsQuantity = "//div[@class='tab-content']/div[3]//th[@data-title='Quantity']";
        public String DepartureDetailsQuantityTextField = "//div[@k-ng-delay='vm.departureGrid']//input[@name='Quantity']";

        //******Purpose*******//

        public String DepartureDetailsPurpose = "//div[@class='tab-content']/div[3]//th[@data-title='Purpose']";
        public String DepartureDetailsPurposeDropdown = "//td[5]//span[@class='k-icon k-i-arrow-s']";
        public String DepartureDetailsxPurposeDropdownDepartureDetails = "//li[contains(.,'ROB')]";

        //******Remarks*******//

        public String DepartureDetailsRemarks = "//div[@class='tab-content']/div[3]//th[@data-title='Remarks']";
        public String DepartureDetailsRemarksTextField = "//div[@k-ng-delay='vm.departureGrid']//input[@name='Remarks']";

        //******VALIDATION_MESSAGES************************************************************************************************************************************

        public String SOFSuccessfullySubmittedMessage = "//span[contains(.,'SOF successfully submitted!')]";
        public String SOFRequiredPageHeader = "//div[@class='row heading']//h3[contains(.,'SOF')]//following-sibling::span[contains(text(),'SOF Missing')]";

//**************************************************************************************************************************************************************
    }
}
