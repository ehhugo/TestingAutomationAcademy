using Ejercicio3Mejorado.Controllers;
using Ejercicio3Mejorado.Controls;
using OpenQA.Selenium;

namespace Ejercicio3Mejorado.PageObject
{
    public class WordPressResetPasswordPage : BasePage
    {
        public WordPressResetPasswordPage() : base(By.CssSelector("WordPressResetPasswordPage"))
        {
        }

        public TextBox TxtEmailLogin
        {
            get
            {
                try
                {
                    return new TextBox(By.Id("user_login"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }

        public Label ErrorMessage
        {
            get
            {
                try
                {
                    return new Label(By.Id("login_error"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }

        public Button BtnNewPassword
        {
            get
            {
                try
                {
                    return new Button(By.Id("wp-submit"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }

        public BaseControl Disclaimer
        {
            get
            {
                try
                {
                    return new BaseControl(By.ClassName("message"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }
    }
}