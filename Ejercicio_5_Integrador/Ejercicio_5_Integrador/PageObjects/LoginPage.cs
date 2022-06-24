using Ejercicio_5_Integrador.Controls;
using OpenQA.Selenium;

namespace Ejercicio_5_Integrador.PageObjects
{
    public class LoginPage : BasePage
    {
        public LoginPage()
            : base(By.ClassName("login"))
        { }

        public TextBox TxtUsername
        {
            get
            {
                try
                {
                    return new TextBox(By.Id("log-usuario"));
                }
                catch
                {
                    throw new NoSuchElementException("Element not present");
                }
            }
        }

        public TextBox TxtPassword
        {
            get
            {
                try
                {
                    return new TextBox(By.Id("log-pwd"));
                }
                catch
                {
                    throw new NoSuchElementException("Element not present");
                }
            }
        }

        public Label AlertMessage
        {
            get
            {
                try
                {
                    return new Label(By.ClassName("alert-danger"));
                }
                catch
                {
                    throw new NoSuchElementException("Element not present");
                }
            }
        }

        public Button BtnLoginButton
        {
            get
            {
                try
                {
                    return new Button(By.ClassName("boton-ingreso"));
                }
                catch
                {
                    throw new NoSuchElementException("Element not present");
                }
            }
        }
    }
}