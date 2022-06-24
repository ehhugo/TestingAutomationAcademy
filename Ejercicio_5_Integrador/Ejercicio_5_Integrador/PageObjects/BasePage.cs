using OpenQA.Selenium;

namespace Ejercicio_5_Integrador.PageObjects
{
    public class BasePage
    {
        protected By locator;

        public BasePage(By by)
        {
            this.locator = by;
        }

        protected IWebDriver Driver
        {
            get
            {
                return WebDriverInstanceManager.WebDriver;
            }
        }

        protected IWebElement WebElement
        {
            get
            {
                return this.Driver.FindElement(this.locator);
            }
        }

        public void WaitUntilVisible(int secondsTimeout = 10)
        {
            this.Driver.WaitUntilVisible(this.locator, secondsTimeout);
        }

        public string PageTitle
        {
            get
            {
                return this.Driver.Title;
            }
        }
    }
}