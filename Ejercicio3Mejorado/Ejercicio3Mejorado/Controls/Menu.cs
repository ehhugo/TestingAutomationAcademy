using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio3Mejorado.Controllers
{
    public class Menu : BaseControl
    {
        public Menu(By by) : base(by)
        {
        }

        public IEnumerable<IWebElement> Options
        {
            get
            {
                try
                {
                    return this.Driver.FindElements(this.locator);
                }
                catch (NoSuchElementException)
                {
                    throw new NoSuchElementException("WebDriver cannot get find the elements under that locator");
                }
            }
        }

        public void SelectElementFromMenu(string menuOption)
        {
            this.Options.FirstOrDefault(o => o.Text.Equals(menuOption)).Click();
        }
    }
}