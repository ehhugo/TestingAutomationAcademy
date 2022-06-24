using NUnit.Framework;

namespace Ejercicio_5_Integrador.Tests
{
    public class BaseTest
    {
        public BaseTest()
        {
            WebDriverInstanceManager.WebDriver.Navigate().GoToUrl("http://hxv-evaluaciondev.interview.hexacta.com");
        }

        [TearDown]
        public void clenaup()
        {
            WebDriverInstanceManager.CloseDriver();
        }
    }
}