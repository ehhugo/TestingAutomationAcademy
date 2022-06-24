using Ejercicio_5_Integrador.Controls;
using OpenQA.Selenium;

namespace Ejercicio_5_Integrador.PageObjects
{
    public class ExamPage : BasePage
    {
        public ExamPage()
            : base(By.CssSelector("main[class *='cuerpo-largo'] div[class*=container]"))
        { }

        public Label Title
        {
            get
            {
                try
                {
                    return new Label(By.CssSelector("div[class*='caja-aclaraciones'] h2"));
                }
                catch
                {
                    return null;
                }
            }
        }

        public Alert BeginExamTimeAlert
        {
            get
            {
                try
                {
                    return new Alert(By.CssSelector("div[class*='alerta-aviso']"));
                }
                catch
                {
                    return null;
                }
            }
        }

        public Button BtnContinue
        {
            get
            {
                try
                {
                    return new Button(By.CssSelector("div[class='botones-back-next'] button:not([class *='boton-back'])"));
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}