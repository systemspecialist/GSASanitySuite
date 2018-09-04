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
    class GACShip_Agent_Search_Page
    {

        //Constructor to initialize the elements in this page.
        //ctor double tab will bring constructor

        public GACShip_Agent_Search_Page()
        {
            PageFactory.InitElements(PropertyCollection.Driver, this);
        }

//******SEARCH_PAGE_MAIN_HEADER************************************************************************************************************************************

        public String SearchPageHeader = "//h3[contains(.,'Search our database')]";
        public String SearchPageSubText = "//span[contains(.,'Use the filters below to find entries within the GACship database')]";

//******SEARCH_PAGE_FILTERS************************************************************************************************************************************

        public String JobNumberFilter="//input[@name='JobNumber']";
        public String VesselFilter = "//input[@name='Vessel_input']";
        public String PortFilter = "//input[@name='Port_input']";
        public String PrincipalFilter = "//input[@name='PrincipalName_input']";
        public String JobStatusFilter = "//input[@name='JobStatus_input']";
        public String JobStatusDropdown = "//input[@name='JobStatus_input']/ancestor::span//span[@class='k-icon k-i-arrow-s']";

                                    //*******JOB STATUS DROPDOWN*************************************************************************************************
                                            public String AllJobs_JobStatus_Dropdown = "//ul[@id='JobStatus_listbox']/li[contains(.,'All Jobs')]";
                                            public String Quotation_JobStatus_Dropdown = "//ul[@id='JobStatus_listbox']/li[contains(.,'Quotation')]";
                                            public String NomindatedByHub_JobStatus_Dropdown = "//ul[@id='JobStatus_listbox']/li[contains(.,'Nominated by Hub')]";
                                            public String AcknowledgedByPA_JobStatus_Dropdown = "//ul[@id='JobStatus_listbox']/li[contains(.,'Acknowledged by PA')]";
                                            public String ProformaSubmitted_JobStatus_Dropdown = "//ul[@id='JobStatus_listbox']/li[contains(.,'Proforma Submitted')]";
                                            public String ProformaApproved_JobStatus_Dropdown = "//ul[@id='JobStatus_listbox']/li[contains(.,'Proforma Approved')]";
                                            public String FinalDASubmitted_JobStatus_Dropdown = "//ul[@id='JobStatus_listbox']/li[contains(.,'Final D/A Submitted')]";
                                            public String FinalDAApproved_JobStatus_Dropdown = "//ul[@id='JobStatus_listbox']/li[contains(.,'Final D/A Approved')]";
                                            public String JobCancelled_JobStatus_Dropdown = "//ul[@id='JobStatus_listbox']/li[contains(.,'Job Cancelled')]";
                                            public String JobClosed_JobStatus_Dropdown = "//ul[@id='JobStatus_listbox']/li[contains(.,'Job Closed')]";
                                    //***************************************************************************************************************************    

        public String FundedByGDCInputFilter = "//input[@name='FundedByGDC_input']";
        public string FundedByGDCDropdown = "//input[@name='FundedByGDC_input']/ancestor::span//span[@class='k-icon k-i-arrow-s']";

                                    //*******FUNDED BY GDC DROPDOWN***********************************************************************************************
                                            public String All_FundedByGDC_Dropdown = "//ul[@id='FundedByGDC_listbox']/li[contains(.,'All')]";
                                            public String Yes_FundedByGDC_Dropdown = "//ul[@id='FundedByGDC_listbox']/li[contains(.,'Yes')]";
                                            public String No_FundedByGDC_Dropdown = "//ul[@id='FundedByGDC_listbox']/li[contains(.,'No')]";
                                    //****************************************************************************************************************************   


        public String ArrivalFromInputFilter = "//input[@id='EtaFrom']";
        public String ArrivalFromDateDropdown = "//input[@name='EtaFrom']/ancestor::span//span[@class='k-icon k-i-calendar']";
        public String ArrivalFromTimeDropdown = "//input[@name='EtaFrom']/ancestor::span//span[@class='k-icon k-i-clock']";

                                     //*******ARRIVAL FROM DROPDWON***********************************************************************************************
                                            public String ArrivalFromCalendar = "//div[@id='EtaFrom_dateview']/div/div/a[@class='k-link k-nav-fast']";

                                            public String ArrivalFromTime_1200AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'12:00 AM')]";
                                            public String ArrivalFromTime_1230AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'12:00 AM')]";
                                            public String ArrivalFromTime_1AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'1:00 AM')]";
                                            public String ArrivalFromTime_130AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'1:30 AM')]";
                                            public String ArrivalFromTime_2AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'2:00 AM')]";
                                            public String ArrivalFromTime_230AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'2:30 AM')]";
                                            public String ArrivalFromTime_3AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'3:00 AM')]";
                                            public String ArrivalFromTime_330AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'3:30 AM')]";
                                            public String ArrivalFromTime_4AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'4:00 AM')]";
                                            public String ArrivalFromTime_430AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'4:30 AM')]";
                                            public String ArrivalFromTime_5AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'5:00 AM')]";
                                            public String ArrivalFromTime_530AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'5:30 AM')]";
                                            public String ArrivalFromTime_6AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'6:00 AM')]";
                                            public String ArrivalFromTime_630AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'6:30 AM')]";
                                            public String ArrivalFromTime_7AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'7:00 AM')]";
                                            public String ArrivalFromTime_730AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'7:30 AM')]";
                                            public String ArrivalFromTime_8AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'8:00 AM')]";
                                            public String ArrivalFromTime_830AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'8:30 AM')]";
                                            public String ArrivalFromTime_9AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'9:00 AM')]";
                                            public String ArrivalFromTime_930AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'9:30 AM')]";
                                            public String ArrivalFromTime_10AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'10:00 AM')]";
                                            public String ArrivalFromTime_1030AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'10:30 AM')]";
                                            public String ArrivalFromTime_11AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'11:00 AM')]";
                                            public String ArrivalFromTime_1130AM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'11:30 AM')]";
                                            public String ArrivalFromTime_12PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'12:00 PM')]";
                                            public String ArrivalFromTime_1230PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'12:30 PM')]";
                                            public String ArrivalFromTime_1PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'1:00 PM')]";
                                            public String ArrivalFromTime_130PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'1:30 PM')]";
                                            public String ArrivalFromTime_2PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'2:00 PM')]";
                                            public String ArrivalFromTime_230PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'2:30 PM')]";
                                            public String ArrivalFromTime_3PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'3:00 PM')]";
                                            public String ArrivalFromTime_330PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'3:30 PM')]";
                                            public String ArrivalFromTime_4PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'4:00 PM')]";
                                            public String ArrivalFromTime_430PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'4:30 PM')]";
                                            public String ArrivalFromTime_5PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'5:00 PM')]";
                                            public String ArrivalFromTime_530PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'5:30 PM')]";
                                            public String ArrivalFromTime_6PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'6:00 PM')]";
                                            public String ArrivalFromTime_630PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'6:30 PM')]";
                                            public String ArrivalFromTime_7PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'7:00 PM')]";
                                            public String ArrivalFromTime_730PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'7:30 PM')]";
                                            public String ArrivalFromTime_8PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'8:00 PM')]";
                                            public String ArrivalFromTime_830PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'8:30 PM')]";
                                            public String ArrivalFromTime_9PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'9:00 PM')]";
                                            public String ArrivalFromTime_930PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'9:30 PM')]";
                                            public String ArrivalFromTime_10PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'10:00 PM')]";
                                            public String ArrivalFromTime_1030PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'10:30 PM')]";
                                            public String ArrivalFromTime_11PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'11:00 PM')]";
                                            public String ArrivalFromTime_1130PM_Dropdown = "//ul[@id='EtaFrom_timeview']/li[contains(.,'11:30 PM')]";
                                    //****************************************************************************************************************************   

        public String ArrivalToInputFilter = "//input[@id='EtaTo']";
        public String ArrivalToDateDropdown = "//input[@name='EtaTo']/ancestor::span//span[@class='k-icon k-i-calendar']";
        public String ArrivalToTimeDropdown = "//input[@name='EtaTo']/ancestor::span//span[@class='k-icon k-i-clock']";

                                    //*******ARRIVAL TO DROPDOWN**************************************************************************************************
                                            public String ArrivalToCalendar = "//div[@id='EtaTo_dateview']/div/div/a[@class='k-link k-nav-fast']";

                                            public String ArrivalToTime_1200AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'12:00 AM')]";
                                            public String ArrivalToTime_1230AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'12:00 AM')]";
                                            public String ArrivalToTime_1AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'1:00 AM')]";
                                            public String ArrivalToTime_130AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'1:30 AM')]";
                                            public String ArrivalToTime_2AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'2:00 AM')]";
                                            public String ArrivalToTime_230AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'2:30 AM')]";
                                            public String ArrivalToTime_3AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'3:00 AM')]";
                                            public String ArrivalToTime_330AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'3:30 AM')]";
                                            public String ArrivalToTime_4AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'4:00 AM')]";
                                            public String ArrivalToTime_430AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'4:30 AM')]";
                                            public String ArrivalToTime_5AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'5:00 AM')]";
                                            public String ArrivalToTime_530AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'5:30 AM')]";
                                            public String ArrivalToTime_6AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'6:00 AM')]";
                                            public String ArrivalToTime_630AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'6:30 AM')]";
                                            public String ArrivalToTime_7AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'7:00 AM')]";
                                            public String ArrivalToTime_730AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'7:30 AM')]";
                                            public String ArrivalToTime_8AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'8:00 AM')]";
                                            public String ArrivalToTime_830AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'8:30 AM')]";
                                            public String ArrivalToTime_9AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'9:00 AM')]";
                                            public String ArrivalToTime_930AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'9:30 AM')]";
                                            public String ArrivalToTime_10AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'10:00 AM')]";
                                            public String ArrivalToTime_1030AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'10:30 AM')]";
                                            public String ArrivalToTime_11AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'11:00 AM')]";
                                            public String ArrivalToTime_1130AM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'11:30 AM')]";
                                            public String ArrivalToTime_12PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'12:00 PM')]";
                                            public String ArrivalToTime_1230PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'12:30 PM')]";
                                            public String ArrivalToTime_1PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'1:00 PM')]";
                                            public String ArrivalToTime_130PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'1:30 PM')]";
                                            public String ArrivalToTime_2PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'2:00 PM')]";
                                            public String ArrivalToTime_230PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'2:30 PM')]";
                                            public String ArrivalToTime_3PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'3:00 PM')]";
                                            public String ArrivalToTime_330PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'3:30 PM')]";
                                            public String ArrivalToTime_4PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'4:00 PM')]";
                                            public String ArrivalToTime_430PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'4:30 PM')]";
                                            public String ArrivalToTime_5PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'5:00 PM')]";
                                            public String ArrivalToTime_530PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'5:30 PM')]";
                                            public String ArrivalToTime_6PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'6:00 PM')]";
                                            public String ArrivalToTime_630PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'6:30 PM')]";
                                            public String ArrivalToTime_7PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'7:00 PM')]";
                                            public String ArrivalToTime_730PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'7:30 PM')]";
                                            public String ArrivalToTime_8PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'8:00 PM')]";
                                            public String ArrivalToTime_830PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'8:30 PM')]";
                                            public String ArrivalToTime_9PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'9:00 PM')]";
                                            public String ArrivalToTime_930PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'9:30 PM')]";
                                            public String ArrivalToTime_10PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'10:00 PM')]";
                                            public String ArrivalToTime_1030PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'10:30 PM')]";
                                            public String ArrivalToTime_11PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'11:00 PM')]";
                                            public String ArrivalToTime_1130PM_Dropdown = "//ul[@id='EtaTo_timeview']/li[contains(.,'11:30 PM')]";
                                    //****************************************************************************************************************************   
        
//******SEARCH_PAGE_BUTTONS************************************************************************************************************************************

        public String RefreshButton = "//button/span[contains(.,'Refresh')]";
        public String SearchButton = "//button/span[contains(.,'Search')]";

//******SEARCH_PAGE_MAIN TABLE COLUMNS*******************************************************************************************************************************************

        public String JobNumberColumn = "//a[@href='#'][contains(.,'Job number')]";
        public String CallTypeColumn = "//a[@href='#'][contains(.,'Call type')]";
        public String AgentReferenceColumn = "//a[@href='#'][contains(.,'Agent Reference')]";
        public String VesselColumn = "//a[@href='#'][contains(.,'Vessel')]";
        public String PortColumn = "//a[@href='#'][contains(.,'Port')]";
        public String ETAColumn = "//a[@href='#'][contains(.,'ETA')]";
        public String VoyageNoColumn = "//a[@href='#'][contains(.,'Voyage No.')]";
        public String StatusColumn = "//a[@href='#'][contains(.,'Status')]";
        public String ActionNeededColumn = "//a[@href='#'][contains(.,'Action Needed')]";
        public String SOFStatusColumn = "//a[@href='#'][contains(.,'SOF Status')]";
        public String ACKColumn = "//a[@href='#'][contains(.,'ACK)]";
        public String PDAColumn = "//a[@href='#'][contains(.,'PDA)]";
        public String FDAColumn = "//a[@href='#'][contains(.,'FDA')]";

//******COLUMNS DROPDOWN************************************************************************************************************************************************

        public String ColumnDropdown = "//div[@id='grid-columns'][contains(.,'Column')]";
        public String JobNumberCheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'Job number')]";
        public String CallTypeCheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'Call type')]";
        public String AgentReferenceCheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'Agent Reference')]";
        public String VesselCheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'Vessel')]";
        public String PortCheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'Port')]";
        public String ETACheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'ETA')]";
        public String VoyageNoCheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'Voyage No.')]";
        public String StatusCheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'Status')]";
        public String ActionNeededCheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'Action Needed')]";
        public String SOFStatusCheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'SOF Status')]";
        public String ACKCheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'ACK')]";
        public String PDACheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'PDA')]";
        public String FDACheckbox = "//label/input[@type='checkbox']/following-sibling::span[contains(.,'FDA')]";

//**********************************************************************************************************************************************************************

    }
}
