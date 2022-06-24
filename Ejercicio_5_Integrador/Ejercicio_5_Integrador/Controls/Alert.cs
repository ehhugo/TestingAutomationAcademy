using OpenQA.Selenium;

namespace Ejercicio_5_Integrador.Controls
{
    public class Alert : BaseControl
    {
        public Alert(By by)
            : base(by)
        { }

        public Alert(IWebElement webElement)
            : base(webElement)
        { }

        public Label LblAlertMessage
        {
            get
            {
                try
                {
                    return new Label(this.WebElement.FindElement(By.ClassName("alerta-aviso-secundario")));
                }
                catch
                {
                    throw new NoSuchElementException("El elemento no está");
                }
            }
        }

        public Button BtnCloseAlert
        {
            get
            {
                try
                {
                    return new Button(this.WebElement.FindElement(By.ClassName("alerta")));
                }
                catch
                {
                    throw new NoSuchElementException("El elemento no está");
                }
            }
        }
    }
}