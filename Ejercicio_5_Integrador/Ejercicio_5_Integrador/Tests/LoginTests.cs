using Ejercicio_5_Integrador.PageObjects;
using NUnit.Framework;

namespace Ejercicio_5_Integrador.Tests
{
    public class LoginTests : BaseTest
    {
        private LoginPage LoginPage => new LoginPage();
        private MainPage MainPage => new MainPage();

        [Test]
        public void LoginPage_UserLogsIn_TheUserSeesItsExams()
        {
            LoginPage.TxtUsername.Write("testingAcademy5.6");
            LoginPage.TxtPassword.Write("abc123");
            LoginPage.BtnLoginButton.Click();

            var title = this.MainPage.Title;

            title.WaitUntilVisible(5);
            Assert.Multiple(() =>
            {
                Assert.That(title.Text.Equals("Exámenes"));
                Assert.IsTrue(MainPage.EnglishExam.Displayed, "The exam is not present in the page");
                Assert.IsTrue(MainPage.TestingTechnicalExam.Displayed, "The exam is not present in the page");
                Assert.IsTrue(MainPage.LogicExam.Displayed, "The exam is not present in the page");
            });
        }
    }
}