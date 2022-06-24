using Ejercicio3Mejorado.Controllers;
using Ejercicio3Mejorado.Controls;
using OpenQA.Selenium;
using System;

namespace Ejercicio3Mejorado.PageObject
{
    public class ComplicatedPage : BasePage
    {
        public ComplicatedPage() : base(By.CssSelector(".page-id-579"))
        {
        }

        public TextBox TxtName
        {
            get
            {
                try
                {
                    return new TextBox(By.Id("et_pb_contact_name_1"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }

        public TextBox TxtEmail
        {
            get
            {
                try
                {
                    return new TextBox(By.Id("et_pb_contact_email_1"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }

        public TextBox TxtMessage
        {
            get
            {
                try
                {
                    return new TextBox(By.Id("et_pb_contact_message_1"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }

        public TextBox TxtCaptcha
        {
            get
            {
                try
                {
                    return new TextBox(By.CssSelector("input[name='et_pb_contact_captcha_1']"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }

        public Button BtnSubmit
        {
            get
            {
                try
                {
                    return new Button(By.XPath("//input[@name='et_pb_contact_captcha_1']/ancestor::div[@class='et_pb_contact_right']/following-sibling::button"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }

        public Label Confirmation
        {
            get
            {
                try
                {
                    return new Label(By.XPath("//div[@id='et_pb_contact_form_1']//div[@class='et-pb-contact-message']/p[text()='Thanks for contacting us']"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }

        public Button WordPressForgotPassword
        {
            get
            {
                try
                {
                    return new Button(By.CssSelector(".et_pb_module.et_pb_login.et_pb_login_0 a"));
                }
                catch (NoSuchElementException)
                {
                    throw;
                }
            }
        }

        public void CompleteAndSendForm(string name, string email, string message)
        {
            this.BtnSubmit.WaitUntilVisible();
            this.BtnSubmit.ScrollToElement();

            this.TxtName.Write(name);
            this.TxtEmail.Write(email);
            this.TxtMessage.Write(message);
            this.TxtCaptcha.Write(GetCaptchaResolution());
            this.BtnSubmit.Click();
        }

        private string GetCaptchaResolution()
        {
            var captchaValue1 = Int32.Parse(TxtCaptcha.GetAttributeValue("data-first_digit"));
            var captchaValue2 = Int32.Parse(TxtCaptcha.GetAttributeValue("data-second_digit"));
            return (captchaValue1 + captchaValue2).ToString();
        }
    }
}