using OpenQA.Selenium;

namespace Ejercicio_5_Integrador.Controls
{
    public class Button : BaseControl
    {
        public Button(By by)
            : base(by)
        { }

        public Button(IWebElement webElement)
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
                    return null;
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