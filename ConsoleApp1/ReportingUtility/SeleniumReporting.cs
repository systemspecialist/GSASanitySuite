using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using MainTest;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserActions;


namespace ReportingUtility
{
    public class SeleniumReporting
    {
        public static void WriteResults(bool strValue,string ActionName)
        {
            //PropertyCollection.ExtentTest = PropertyCollection.ExtentReports.CreateTest("Click Button");
            if (strValue == true)
            {
                PropertyCollection.ChildTest.Log(Status.Pass, ActionName + " Action Successfully Completed");
            }
            else
            {
                string ScreenshotPath = TakeScreenshot();
                var mediaModel = MediaEntityBuilder.CreateScreenCaptureFromPath(ScreenshotPath).Build();
                PropertyCollection.ChildTest.Log(Status.Fail, "Unable to perform the '" + ActionName + "' action since the object is not available in the UI",mediaModel) ;
                throw new Exception(ActionName +" Not Found!");
            }
        }


        public static void ElementPresentVerification(bool strValue, string element)
        {
            //PropertyCollection.ExtentTest = PropertyCollection.ExtentReports.CreateTest("Click Button");
            if (strValue == true)
            {
                PropertyCollection.ChildTest.Log(Status.Pass, element + " Element Found Succesfully!");
            }
            else
            {
                string ScreenshotPath = TakeScreenshot();
                var mediaModel = MediaEntityBuilder.CreateScreenCaptureFromPath(ScreenshotPath).Build();
                PropertyCollection.ChildTest.Log(Status.Fail, "Unable to see '" + element + "' in the UI.", mediaModel);
                throw new Exception(element +" Not Found!");
            }
        }

        public static void ElementMatchingVerification(bool strValue, string element1, string element2)
        {
            //PropertyCollection.ExtentTest = PropertyCollection.ExtentReports.CreateTest("Click Button");
            if (strValue == true)
            {
                PropertyCollection.ChildTest.Log(Status.Pass, element1 + " matches "+ element2 + "!");
            }
            else
            {
                string ScreenshotPath = TakeScreenshot();
                var mediaModel = MediaEntityBuilder.CreateScreenCaptureFromPath(ScreenshotPath).Build();
                PropertyCollection.ChildTest.Log(Status.Fail, "Matching Verification Failed! - " + element1 + " and " + element2 + " does not match!", mediaModel);
                throw new Exception("Matching Verification Failed! - " + element1 + " and " + element2 + " does not match!") ;
            }
        }

        public static void clickButton(bool strValue, string ButtonName)
        {
            //PropertyCollection.ExtentTest = PropertyCollection.ExtentReports.CreateTest("Click Button");
            if (strValue == true)
            {
                PropertyCollection.ChildTest.Log(Status.Pass, " Click " + ButtonName + " Button Succesfully Done!");
            }
            else
            {
                string ScreenshotPath = TakeScreenshot();
                var mediaModel = MediaEntityBuilder.CreateScreenCaptureFromPath(ScreenshotPath).Build();
                PropertyCollection.ChildTest.Log(Status.Fail, "Verification Failed! - " + ButtonName + " was not clicked. Please check element. ", mediaModel);
                throw new Exception("Verification Failed! - " + ButtonName + " Button was not clicked. Please check element existence. ");
            }
        }



        public static void WriteMessageOnTheReport(string Message)
        {
            //PropertyCollection.ExtentTest = PropertyCollection.ExtentReports.CreateTest("Click Button");
                PropertyCollection.ChildTest.Log(Status.Pass, Message);
        }

        public static void GetResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                PropertyCollection.ChildTest.Log(Status.Fail, status + errorMessage);
            }

        }
        public static string TakeScreenshot()
        {
            ITakesScreenshot screenshot = PropertyCollection.Driver as ITakesScreenshot;
            var screen = screenshot.GetScreenshot();
            //string fileName = System.Configuration.ConfigurationManager.AppSettings["ScreenshotPath"] + DateTime.Now.ToString("yyyy-dd-MM--HH-mm-ss")+".png";
            string fileName = GetActions.GetFileName("ScreenshotPath", ".png");
            screen.SaveAsFile(fileName);
            return fileName;
        }
    }

}
