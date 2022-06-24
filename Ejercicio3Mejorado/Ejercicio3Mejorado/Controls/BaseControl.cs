using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Ejercicio3Mejorado.Controllers
{
    public class BaseControl
    {
        protected By locator;

        public BaseControl(By by)
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
                try
                {
                    return this.Driver.FindElement(this.locator);
                }
                catch (NoSuchElementException)
                {
                    throw new NoSuchElementException("WebDriver cannot find the element in the page under that locator");
                }
            }
        }

        protected IWebElement WebElementWaiter
        {
            get
            {
                try
                {
                    return this.Driver.FindElementWait(this.locator, 30);
                }
                catch (NoSuchElementException)
                {
                    throw new NoSuchElementException("WebDriver could not find the element in the page after the indicated time");
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
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public void ScrollToElement()
        {
            Actions actionProvider = new Actions(Driver);
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