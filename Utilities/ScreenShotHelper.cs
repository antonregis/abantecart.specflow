using AventStack.ExtentReports;
using OpenQA.Selenium;
using System.Text;
using System.Drawing.Imaging;

namespace TestSuite.Utilities
{
    public class ScreenShotHelper : Driver
    {
        // For capturing screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(string ScreenShotFileName)
            {
                var folderLocation = (EnvironmentHelper.screenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_yyyy-MM-dd_HHmmss"));
                fileName.Append(".png");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Png);
                return fileName.ToString();
            }
        }

        public static string GetBase64Screenshot()
        {
            var screenShot = ((ITakesScreenshot)driver).GetScreenshot();

            // Convert the screenshot to a byte array
            byte[] screenshotBytes = screenShot.AsByteArray;

            // Convert the byte array to a base64 string
            string base64String = Convert.ToBase64String(screenshotBytes);

            return base64String;
        }
    }
}