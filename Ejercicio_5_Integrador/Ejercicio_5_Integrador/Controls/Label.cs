using OpenQA.Selenium;

namespace Ejercicio_5_Integrador.Controls
{
    public class Label : BaseControl
    {
        public Label(By by)
            : base(by)
        { }

        public Label(IWebElement webElement)
            : base(webElement)
        { }

        public string Text
        {
            get
            {
                try
                {
                    return this.WebElement.Text;
                }
                catch
                {
                    throw new NoSuchElementException("El elemento no está");
                }
            }
        }
    }
}