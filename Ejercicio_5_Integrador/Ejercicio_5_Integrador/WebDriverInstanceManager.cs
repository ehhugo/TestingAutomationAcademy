using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Ejercicio_5_Integrador
{
    public static class WebDriverInstanceManager
    {
        private static IWebDriver? activeDriver;

        public static IWebDriver WebDriver
        {
            get
            {
                if (activeDriver == null)
                {
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--disable-popup-blocking");
                    activeDriver = new ChromeDriver(options);
                    activeDriver.Manage().Window.Maximize();
                }
                return activeDriver;
            }
        }

        public static void CloseDriver()
        {
            if (activeDriver != null)
            {
                activeDriver.Close();
                activeDriver.Quit();
                activeDriver.Dispose();
                activeDriver = null;
            }
        }
    }
}