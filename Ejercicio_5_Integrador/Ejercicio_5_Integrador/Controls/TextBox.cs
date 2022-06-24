using OpenQA.Selenium;

namespace Ejercicio_5_Integrador.Controls
{
    public class TextBox : BaseControl
    {
        public TextBox(By by)
           : base(by)
        { }

        public TextBox(IWebElement webElement)
           : base(webElement)
        { }

        public void Write(string texto)
        {
            this.WebElementWaiter.SendKeys(texto);
            //this.WebElement.Clear();
            //this.WebElement.SendKeys(texto);
        }

        private void Clear()
        {
            this.WebElement.Clear();
        }
    }
}