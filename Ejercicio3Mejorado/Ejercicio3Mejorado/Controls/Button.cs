using Ejercicio3Mejorado.Controllers;
using OpenQA.Selenium;

namespace Ejercicio3Mejorado.Controls
{
    public class Button : BaseControl
    {
        public Button(By by) : base(by)
        {
        }

        public string Text
        {
            get
            {
                try
                {
                    return this.WebElement.Text;
                }
                catch (NoSuchElementException)
                {
                    throw new NoSuchElementException("WebDriver cannot find the element in the page and is unable to get the text from it");
                }
            }
        }

        public void Click() => this.WebElement.Click();

        public void Click_Waiter()
        {
            this.WebElementWaiter.Click();
        }
    }
}