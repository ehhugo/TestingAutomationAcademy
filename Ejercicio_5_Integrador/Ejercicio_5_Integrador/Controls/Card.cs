using OpenQA.Selenium;

namespace Ejercicio_5_Integrador.Controls
{
    public class Card : BaseControl
    {
        public Card(By by)
            : base(by)
        { }

        public Label LblTitle
        {
            get
            {
                try
                {
                    return new Label(this.WebElement.FindElement(By.TagName("h3")));
                }
                catch
                {
                    return null;
                }
            }
        }

        public Button BtnBeginExam
        {
            get
            {
                try
                {
                    return new Button(this.WebElement.FindElement(By.ClassName("boton-examen")));
                }
                catch
                {
                    return null;
                }
            }
        }

        public Label LblFinishedExam
        {
            get
            {
                try
                {
                    return new Label(this.WebElement.FindElement(By.ClassName("examen-realizado")));
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}