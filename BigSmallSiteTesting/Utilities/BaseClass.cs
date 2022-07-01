using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Log = Serilog.Log;

namespace BigSmallSiteTesting.Utilities
{
    [Binding]
    public class BaseClass
    {

        public static IWebDriver driver;
        public static ExtentReports extents;
        public static ExtentTest feature;
        public static ExtentTest scenario;

        [BeforeFeature]
        public static void FeatureBrowser(FeatureContext featurecontext)
        {
            feature = extents.CreateTest<Feature>(featurecontext.FeatureInfo.Title);
            Serilog.Log.Information("Selecting feature file {0} to run", featurecontext.FeatureInfo.Title);
        }


        [BeforeScenario]
        public static void LaunchBrowser(ScenarioContext scenarioContext)
        {

            scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            Serilog.Log.Information("Selecting scenario {0} to run", scenarioContext.ScenarioInfo.Title);

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.bigsmall.in/");
            driver.Manage().Window.Maximize();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("test.png", ScreenshotImageFormat.Png);
            //(ITakesScreenshot)driver).
            //.SaveAsFile("Test.png", ScreenshotImageFormat.Png);
        }

        [BeforeTestRun]
        public static void GenerateReport()
        {
            var htmlReport = new ExtentHtmlReporter(@"C:\Users\mindtreejanedge220\Desktop\New folder\BigSmallSiteTesting\BigSmallSiteTesting");
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extents = new ExtentReports();
            extents.AttachReporter(htmlReport);
            //Log.Logger = new LoggerConfiguration().WriteTo.File(@"C:\Users\mindtreefeb65\source\repos\FinalAssessment\FinalAssessment\log.txt", rollingInterval: RollingInterval.Minute).CreateLogger();

            LoggingLevelSwitch loggingLevel = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Debug);
            Serilog.Log.Logger = new LoggerConfiguration()
                         .MinimumLevel.ControlledBy(levelSwitch: loggingLevel).WriteTo
                         .File(@"C:\Users\mindtreejanedge220\Desktop\New folder\BigSmallSiteTesting\BigSmallSiteTesting\Logs", outputTemplate: "{TimeSpamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message} {NewLine}", rollingInterval: RollingInterval.Day)
                         .CreateLogger();

        }

        [AfterTestRun]
        public static void CloseExtentReport()
        {
            extents.Flush();
        }

        [AfterStep]
        public static void InsertReportingStep(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError == null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "When")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "Then")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "And")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);


            }
            if (scenarioContext.TestError != null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                Log.Error("Test Step Failed | " + scenarioContext.TestError.Message);
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "And")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);

            }
        }
        [AfterScenario]
        public static void Clean()
        {
            driver.Quit();
        }





    }
}
