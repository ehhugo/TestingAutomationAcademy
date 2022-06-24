using Ejercicio3Mejorado.PageObject;
using NUnit.Framework;

namespace Ejercicio3Mejorado.Tests
{
    public class T2_Complicated_Page_Tests : BaseTest
    {
        private MainPage mainPage;
        private ComplicatedPage complicatedPage;
        private WordPressResetPasswordPage wordPressResetPasswordPage;

        [Test]
        public void captchaAutomation()
        {
            AccessComplicatedPage();

            this.complicatedPage = new ComplicatedPage();
            var pageTitle = this.complicatedPage.PageTitle;

            Assert.Multiple(() =>
            {
                Assert.That(pageTitle.Contains("Complicated Page"));
                this.complicatedPage.CompleteAndSendForm("Hugo", "Hugo@mail.com", "Text for the message textArea sample");

                var confirmation = this.complicatedPage.Confirmation;

                confirmation.WaitUntilVisible(10);
                Assert.AreEqual("Thanks for contacting us", confirmation.Text);
            });
        }

        [Test]
        public void resetWordpressPassword()
        {
            AccessComplicatedPage();

            this.complicatedPage = new ComplicatedPage();
            this.complicatedPage.WordPressForgotPassword.Click();

            wordPressResetPasswordPage = new WordPressResetPasswordPage();

            wordPressResetPasswordPage.Disclaimer.WaitUntilVisible(10);
            wordPressResetPasswordPage.TxtEmailLogin.Write("something");
            wordPressResetPasswordPage.BtnNewPassword.Click();

            Assert.IsTrue(wordPressResetPasswordPage.ErrorMessage.WaitUntilVisible());
        }

        private void AccessComplicatedPage()
        {
            this.mainPage = new MainPage();
            this.mainPage.ActionLinks.SelectElementFromMenu("Big page with many elements");
        }
    }
}