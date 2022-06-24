using OpenQA.Selenium;

namespace Ejercicio3Mejorado.Controllers
{
    public class TextBox : BaseControl
    {
        public TextBox(By by)
            : base(by)
        {
        }

        public void Write(string texto)
        {
            this.WebElementWaiter.SendKeys(texto);
            this.WebElement.Clear();
            this.WebElement.SendKeys(texto);
        }

        private void Clear()
        {
            this.WebElement.Clear();
        }
    }
}