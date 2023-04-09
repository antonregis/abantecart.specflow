using System.Collections;

namespace TestSuite.Utilities
{
    public class EnvironmentHelper
    {

        // Base Url
        public static string BaseUrl = Resource.BaseUrl;

        // Browser type (Chrome, Firefox, Edge, Headles Chrome)
        public static int BrowserType = Int32.Parse(Resource.BrowserType);

        // Memeber Username
        public static string MemberUsername = Resource.MemberUsername;

        // Memeber Password
        public static string MemberPassword = Resource.MemberPassword;

        // Get Project directory path
        public static string ProjectDirectoryPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\";

        // ScreenshotPath 
        public static string ScreenshotPath = ProjectDirectoryPath + Resource.ScreenshotPath + "\\";

        // ExtentReportsPath
        public static string ReportPath = ProjectDirectoryPath + Resource.ReportPath + "\\";

        // ExcelDataPath
        public static string ExcelDataPath = ProjectDirectoryPath + Resource.ExcelDataPath;
    }
}