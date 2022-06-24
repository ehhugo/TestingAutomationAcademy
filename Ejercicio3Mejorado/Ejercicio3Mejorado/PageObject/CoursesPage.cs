using OpenQA.Selenium;

namespace Ejercicio3Mejorado.PageObject
{
    public class CoursesPage : BasePage
    {
        public CoursesPage() : base(By.ClassName("collections-landing-page"))
        {
        }

        public string PageTite => this.Driver.Title;
    }
}