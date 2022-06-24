using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Mejorado.Tests
{
    public class BaseTest
    {
        
        public BaseTest()
        {
            WebDriverInstanceManager.WebDriver.Navigate().GoToUrl("https://www.ultimateqa.com/automation/");
        }

        [TearDown]
        public void clenaup()
        {
            WebDriverInstanceManager.CloseDriver();
        }
    }
}
