using Ejercicio3Mejorado.Controllers;
using Ejercicio3Mejorado.Controls;
using OpenQA.Selenium;

namespace Ejercicio3Mejorado.PageObject
{
    public class FormsPage : BasePage
    {
        public FormsPage() : base(By.CssSelector(".page-template-default"))
        {
        }

        public TextBox TxtName
        {
            get
            {
                try
                {
                    return new TextBox(By.Id("et_pb_contact_name_0"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

        public TextBox TxtMessage
        {
            get
            {
                try
                {
                    return new TextBox(By.Name("et_pb_contact_message_0"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

        public Button BtnSubmit
        {
            get
            {
                try
                {
                    return new Button(By.XPath("(//button[@type='submit'])[1]"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

        public Label ConfirmatrionMessage
        {
            get
            {
                try
                {
                    return new Label(By.XPath("//div[@class='et-pb-contact-message']/p[text()='Thanks for contacting us']"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

        public void CompleteAndSendForm(string name, string description)
        {
            TxtName.Write(name);
            TxtMessage.Write(description);
            BtnSubmit.WaitUntilVisible();
            BtnSubmit.Click();
        }
    }
}