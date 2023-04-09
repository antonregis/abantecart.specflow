using AventStack.ExtentReports;
using OpenQA.Selenium;
using System.Text;


namespace TestSuite.Utilities
{
    public class ScreenShotHelper : Driver
    {
        // For capturing screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(string ScreenShotFileName)
            {
                var folderLocation = (EnvironmentHelper.ScreenshotPath);

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

        public static MediaEntityModelProvider CaptureScreenShot()
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            var screenShot = ts.GetScreenshot().AsBase64EncodedString;

            DateTime time = DateTime.Now;
            String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenShot, fileName).Build();
        }


    }
}