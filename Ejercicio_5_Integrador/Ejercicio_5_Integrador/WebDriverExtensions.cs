using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Ejercicio_5_Integrador
{
    public static class WebDriverExtensions
    {
        public static bool WaitUntil(this IWebDriver driver, Func<bool> func, int secondsTimeout = 80)
        {
            try
            {
                return new WebDriverWait(driver, TimeSpan.FromSeconds(secondsTimeout)).Until(x => func());
            }
            catch (WebDriverException)
            {
                //Comment
                return false;
            }
        }

        public static bool WaitUntilVisible(this IWebDriver driver, By by, int secondsTimeout = 80)
        {
            return driver.WaitUntil
                (
                    () => driver.FindElement(by).Displayed, secondsTimeout
                );
        }

        public static IWebElement FindElementWait(this IWebDriver driver, By by, int secondsTimeout)
        {
            try
            {
                driver.WaitUntilVisible(by, secondsTimeout);
                return driver.FindElement(by);
            }
            catch
            {
                return null;
            }
        }

        public static IEnumerable<IWebElement> FindElementsWait(this IWebDriver driver, By by)
        {
            try
            {
                driver.WaitUntil(() => driver.FindElements(by).Count > 0);
                return driver.FindElements(by);
            }
            catch
            {
                return null;
            }
        }
    }
}