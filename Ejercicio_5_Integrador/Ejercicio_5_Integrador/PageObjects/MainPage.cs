using Ejercicio_5_Integrador.Controls;
using OpenQA.Selenium;

namespace Ejercicio_5_Integrador.PageObjects
{
    public class MainPage : BasePage
    {
        public MainPage()
            : base(By.ClassName("cuerpo-peque"))
        { }

        public Label Title
        {
            get
            {
                try
                {
                    return new Label(By.XPath("//div[@class='caja-aclaraciones']/h2"));
                }
                catch
                {
                    throw new NoSuchElementException("Element not present");
                }
            }
        }

        public Card EnglishExam
        {
            get
            {
                try
                {
                    return new Card(By.ClassName("examen-ingles"));
                }
                catch
                {
                    throw new NoSuchElementException("Element not present");
                }
            }
        }

        public Card LogicExam
        {
            get
            {
                try
                {
                    return new Card(By.ClassName("examen-logica"));
                }
                catch
                {
                    throw new NoSuchElementException("Element not present");
                }
            }
        }

        public Card TestingTechnicalExam
        {
            get
            {
                try
                {
                    return new Card(By.ClassName("examen-testingTecnico"));
                }
                catch
                {
                    throw new NoSuchElementException("Element not present");
                }
            }
        }
    }
}