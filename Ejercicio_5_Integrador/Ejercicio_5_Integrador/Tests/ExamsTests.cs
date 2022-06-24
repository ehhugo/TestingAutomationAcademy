using Ejercicio_5_Integrador.PageObjects;
using NUnit.Framework;

namespace Ejercicio_5_Integrador.Tests
{
    public class ExamsTests : BaseTest

    {
        private LoginPage LoginPage => new LoginPage();
        private MainPage MainPage => new MainPage();
        private ExamPage ExamPage => new ExamPage();
        private FinishedExamPage FinishedExamPage => new FinishedExamPage();

        [Test]
        public void MainPage_Exams_CompletedExamCannotBeRetaken()
        {
            var loginPage = this.LoginPage;
            loginPage.TxtUsername.Write("testingAcademy5.6");
            loginPage.TxtPassword.Write("abc123");
            loginPage.BtnLoginButton.Click();

            var technicalExam = this.MainPage.TestingTechnicalExam;

            technicalExam.WaitUntilVisible(10);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(technicalExam.LblFinishedExam.Displayed, "The exam has not being taken yet");
                Assert.IsTrue(technicalExam.BtnBeginExam is null, "The exam has already being taken");
            });
        }

        [Test]
        public void ExamsPage_UserTakesLogicExam_ExamIsCompleted()
        {
            LoginPage.TxtUsername.Write("testingAcademy5.9");
            LoginPage.TxtPassword.Write("abc123");
            LoginPage.BtnLoginButton.Click();

            var logicExamCard = this.MainPage.LogicExam;
            logicExamCard.WaitUntilVisible(10);
            logicExamCard.BtnBeginExam.Click();

            var exam = this.ExamPage;
            exam.WaitUntilVisible(10);

            var examTimeAlert = exam.BeginExamTimeAlert;

            if (examTimeAlert.Displayed)
            {
                examTimeAlert.BtnCloseAlert.Click();
            }

            var continueButton = exam.BtnContinue;
            continueButton.ScrollToElement();
            continueButton.Click();

            var btnReturnToMainPage = this.FinishedExamPage.BtnReturnToMainPage;
            btnReturnToMainPage.WaitUntilVisible(10);
            Assert.IsTrue(this.FinishedExamPage.BtnReturnToMainPage.Displayed, "The exam has not being completed yet");
        }
    }
}