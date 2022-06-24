using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Ejercicio_5_Integrador.Controls
{
    public class BaseControl
    {
        protected By locator;
        private IWebElement webElement;

        public BaseControl(By by)
        {
            this.locator = by;
        }

        public BaseControl(IWebElement webElement)
        {
            this.webElement = webElement;
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
                try
                {
                    if (this.locator is not null)
                    {
                        this.webElement = this.Driver.FindElement(this.locator);
                    }
                    return this.webElement;
                }
                catch
                {
                    return null;
                }
            }
        }

        protected IWebElement WebElementWaiter
        {
            get
            {
                try
                {
                    return new WebDriverWait(this.Driver, System.TimeSpan.FromSeconds(50)).Until<IWebElement>(d => d.FindElement(this.locator));
                }
                catch
                {
                    return null;
                }
            }
        }

        public bool Displayed
        {
            get
            {
                try
                {
                    return this.WebElement.Displayed;
                }
                catch
                {
                    return false;
                }
            }
        }

        public void ScrollToElement()
        {
            var actionProvider = new Actions(Driver);
            actionProvider.MoveToElement(this.WebElement).Build().Perform();
            actionProvider.Reset();
        }

        public string GetAttributeValue(string attribute)
        {
            return this.WebElement.GetAttribute(attribute);
        }

        public bool WaitUntilVisible(int secondsTimeout = 80)
        {
            return this.Driver.WaitUntilVisible(this.locator, secondsTimeout);
        }
    }
}