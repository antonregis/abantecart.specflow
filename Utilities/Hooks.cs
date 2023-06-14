using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using TestSuite.Pages;
using TechTalk.SpecFlow;
using static TestSuite.Utilities.ScreenShotHelper;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.Text;


namespace TestSuite.Utilities
{
    [Binding]
    public class Hooks : Driver
    {
        private static ExtentTest featureName = null!;
        private static ExtentTest scenario = null!;
        private static ExtentReports extent = null!;

        [BeforeTestRun]
        public static void InitializeExtentReports()
        {
            var htmlReporter = new ExtentHtmlReporter(EnvironmentHelper.reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Client", Resource.metaData_Client);
            extent.AddSystemInfo("Project", Resource.metaData_Project);
            extent.AddSystemInfo("Testing Type", Resource.metaData_TestingType);
            extent.AddSystemInfo("Environment", Resource.metData_TestEnvironment);
            extent.AddSystemInfo("Host name", Resource.baseUrl);            
            extent.AddSystemInfo("Test Analyst", Resource.metaData_TestAnalyst);
        }

        [BeforeFeature]
        public static void InitializeFeature(FeatureContext featurecontext)
        {
            // ExtentReport: Create test or the Feature
            featureName = extent.CreateTest<Feature>(featurecontext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void Setup(ScenarioContext scenarioContext)
        {
            // Launch the browser
            InitializeBrowser(EnvironmentHelper.browserType);
            
            // ExtentReport: Create node or the Scenario
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }

        [AfterStep]
        public void AfterEachStep(ScenarioContext scenariocontext)
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (scenariocontext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }

            if (scenariocontext.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
                if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenariocontext.TestError.Message);
            }
        }

        [AfterScenario]
        public void TearDown()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;

            if (status == TestStatus.Failed)
            {
                // Take a screenshot and attach a base64-img.      
                // This is preferred as the screenshot is integrated in the html report as a text. 
                // No need to attach separate screenshot files.
                scenario.AddScreenCaptureFromBase64String(ScreenShotHelper.GetBase64Screenshot());

                // Take a screenshot and attach an image
                //string img = SaveScreenShotClass.SaveScreenshot("Screenshot");
                //scenario.AddScreenCaptureFromPath(img);
            }

            //Close the browser
            driver.Quit();
        }

        [AfterTestRun]
        public static void SaveExtentReports()
        {
            // Save Extentereport html file
            extent.Flush();
        }
    }
}