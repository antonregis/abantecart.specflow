using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using WebDriverManager.DriverConfigs.Impl;

namespace TestSuite.Utilities
{
    public class Driver
    {
        // Initialize the browser
        public static IWebDriver driver = null!;


        public static void InitializeBrowser(int BrowserType)
        {
            // Initializing browser
            switch (BrowserType)
            {
                case 1:
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
                case 2:
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("headless");
                    driver = new ChromeDriver(chromeOptions);
                    break;
                case 3:
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
                case 4:
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
                default:
                    Console.WriteLine("Browser Type Options:");
                    Console.WriteLine("1 - Chrome");
                    Console.WriteLine("2 - Headless Chrome");
                    Console.WriteLine("3 - Firefox");
                    Console.WriteLine("4 - Edge");
                    throw new NullReferenceException(BrowserType + " is Invalid Browser Type!");
            }

            // Implicit wait global time declaration
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            // Maximize browser window
            driver.Manage().Window.Maximize();
        }

        public static void NavigateToBaseUrl()
        {
            driver.Navigate().GoToUrl(EnvironmentHelper.BaseUrl);
        }

        public static void NavigateToUrl(string path)
        {
            driver.Navigate().GoToUrl(EnvironmentHelper.BaseUrl + path);
        }
    }
}