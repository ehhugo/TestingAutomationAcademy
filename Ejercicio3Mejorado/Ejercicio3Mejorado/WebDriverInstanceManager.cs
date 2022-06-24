using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Mejorado
{
    public static class WebDriverInstanceManager
    {
        private static IWebDriver? activeDriver;

        public static IWebDriver WebDriver
        {
            get
            {
                if(activeDriver == null)
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
