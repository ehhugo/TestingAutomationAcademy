using Ejercicio3Mejorado.Controllers;
using OpenQA.Selenium;

namespace Ejercicio3Mejorado.Controls
{
    public class Label : BaseControl
    {
        public Label(By by) : base(by)
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
    }
}