using System.Collections;

namespace TestSuite.Utilities
{
    public class EnvironmentHelper
    {

        // Base Url
        public static string baseUrl = Resource.baseUrl;

        // Browser type (Chrome, Firefox, Edge, Headles Chrome)
        public static int browserType = Int32.Parse(Resource.browserType);

        // Get Project directory path
        public static string projectDirectoryPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\";

        // ScreenshotPath 
        public static string screenshotPath = projectDirectoryPath + Resource.screenshotPath + "\\";

        // ExtentReportsPath
        public static string reportPath = projectDirectoryPath + Resource.reportPath + "\\";

        // ExcelDataPath
        public static string excelTestData = projectDirectoryPath + Resource.excelTestData;
    }
}