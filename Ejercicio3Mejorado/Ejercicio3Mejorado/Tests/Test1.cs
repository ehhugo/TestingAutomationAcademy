using Ejercicio3Mejorado.PageObject;
using NUnit.Framework;
using System.Linq;

namespace Ejercicio3Mejorado.Tests
{
    public class Test1 : BaseTest
    {
        private MainPage mainPage;
        private CoursesPage coursesPage;
        private FormsPage formPage;

        [Test]
        public void SelectCoursesPageAndCheckPageTitle()
        {
            this.mainPage = new MainPage();
            var mainMenu = this.mainPage.MainMenu;
            var menuOptionsCount = mainMenu.Options.Count();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(7, menuOptionsCount);
                mainMenu.SelectElementFromMenu("Courses");

                this.coursesPage = new CoursesPage();
                Assert.AreEqual("Ultimate QA", this.coursesPage.PageTitle, "Page Title Matches");
            });
        }

        [Test]
        public void FillFormAndGetApprovalMessage()
        {
            this.mainPage = new MainPage();
            this.mainPage.ActionLinks.SelectElementFromMenu("Fill out forms");

            this.formPage = new FormsPage();
            this.formPage.TxtMessage.WaitUntilVisible(10);

            //Completes the form and waits until the message Appears,
            //if it doesn't, clicks again in the button and then Asserts

            this.formPage.CompleteAndSendForm("Hugo", "Test case description sample");
            if (!formPage.ConfirmatrionMessage.WaitUntilVisible(10))
            {
                this.formPage.BtnSubmit.Click();
                this.formPage.ConfirmatrionMessage.WaitUntilVisible(10);
            }

            Assert.AreEqual("Thanks for contacting us", this.formPage.ConfirmatrionMessage);
        }
    }
}