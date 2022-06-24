using Ejercicio_5_Integrador.Controls;
using OpenQA.Selenium;

namespace Ejercicio_5_Integrador.PageObjects
{
    public class FinishedExamPage : BasePage
    {
        public FinishedExamPage()
            : base(By.ClassName("cuerpo-peque"))
        { }

        public Button BtnReturnToMainPage
        {
            get
            {
                try
                {
                    return new Button(By.ClassName("boton-volver-confirm"));
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}