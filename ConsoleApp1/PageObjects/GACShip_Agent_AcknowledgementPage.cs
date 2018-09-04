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
    class GACShip_Agent_Acknowledgement_Page
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShip_Agent_Acknowledgement_Page()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//**********************ACKNOWLEDGEMENT_PAGE_MAIN_HEADER******************************************************************************************************************

        public String AcknowledgePageHeader = "//div[@class='row heading']//h3[contains(.,'Acknowledge')]//following-sibling::span[contains(.,'Nominated by Hub')]";
        public String AcknowledgementPageJobNumber = "//span[@ng-show='vm.model']";
        public String HeaderETA = "//div[@class='ack-header-data no-padding-left']//label[contains(.,'ETA')]//following-sibling::span";
        public String HeaderETD = "//div[@class='ack-header-data no-padding-left']//label[contains(.,'ETD')]//following-sibling::span";
        public String HeaderVesselName = "//div[@class='ack-header-data no-padding-left']//label[contains(.,'Vessel Name')]//following-sibling::span";
        public String HeaderIMONumber = "//div[@class='ack-header-data no-padding-left']//label[contains(.,'IMO Number')]//following-sibling::span";
        public String HeaderAcknowledgedOn = "//div[@class='ack-header-data no-padding-left']//label[contains(.,'Acknowledged On')]//following-sibling::span";

//*********************HUB_INSTRUCTION*************************************************************************************************************************************

        public String HeaderHubInstruction = "//h3[@class='ack-hub-instr-title'][contains(.,'Hub Instruction')]";

//*********************DOCUMENTS********************************************************************************************************************************************

        public String HeaderDocuments = "//div[@class='ack-documents'][contains(.,'Documents')]";
        public String HeaderDocumentsFileName = "//th[@data-field='AttachmentFileName']/a[contains(.,'File Name')]";
        public String HeaderDocumentsUploadedBy = "//th[@data-field='CreatedByName']/a[contains(.,'Uploaded by')]";
        public String HeaderDocumentsSize = "//th[@data-field='AttachmentFileSize']/a[contains(.,'Size (kb)')]";
        public String DocumentsNoRecordsAvailable = "//div[@class='k-grid-norecords-template'][contains(.,'No records available')]";

//*********************ACCEPT_DECLINE_REMARKS*******************************************************************************************************************************************

        public String HeaderAcceptDeclinedRemarks = "//div[@class='ack-remarks form-group']/label[contains(.,'Accept/Decline Remarks')]";
        public String AcceptDeclinedRemarksTextField = "//label[contains(.,'Accept/Decline Remarks')]//following-sibling::input";
        public String HeaderAgentReference = "//div[@class='ack-agent-ref form-group']/label[contains(.,'Agent reference')]";
        public String AgentReferenceTextField = "//div[@class='ack-agent-ref form-group']/label[contains(.,'Agent reference')]//following-sibling::input";
        public String AcknowledgementNote = "//label[contains(.,'We comply at all times with applicable supra-national, national and local laws and regulations including, but not limited to, relevant regulations governing anti-money laundering, corrupt practices and specifically sanctioned activity.')]/input[@id='ackComply'][@type='checkbox']";
        public String AcceptButton = "//button[@class='btn btn-submit pull-right']/span[contains(.,'Accept')]";
        public String DeclineButton = "//button[@class='btn btn-refresh pull-right']/span[contains(.,'Decline')]";
        public String PrintButton = "//div[@class='ack-action-buttons ']/i[@class='fa fa-print pull-right']";

//*********************ACKNOWLEDGMENT_PAGE_MODAL*****************************************************************************************************************************************

        public String AcknowldegementPageModalConfimrationButton = "//div[@class='husbandryModalContent']//button/span[contains(.,'Confirm')]";

//*********************ACKNOWLEDGMENT_PAGE_MODAL*****************************************************************************************************************************************

        public String AcknowledgementPageHeader2 = "//h3[contains(.,'Acknowledge')]//following-sibling::span[contains(.,'Nominated by Hub')][contains(.,'STD1870028 ')]";
        public String AcknowledgementPageHeader = "//div[@class='row heading']//h3[contains(.,'Acknowledge')]//following-sibling::span[contains(.,'Nominated by Hub')]";

 //**************************************************************************************************************************************************************************************

    }
}
