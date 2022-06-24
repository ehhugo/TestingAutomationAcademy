using Ejercicio3Mejorado.Controllers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Mejorado.PageObject
{
    public class MainPage : BasePage
    {
        public MainPage() : base(By.CssSelector(".page-template-default"))
        {
        }

        public Menu MainMenu
        {
            get
            {
                try
                {
                    return new Menu(By.CssSelector("#menu-home-page-menu li.menu-item"));
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            }
        }

        public Menu ActionLinks
        {
            get
            {
                try
                {
                    return new Menu(By.CssSelector(".et_pb_text_inner li a"));
                }
                catch (NoSuchElementException)
                {

                    return null;
                }
            }
        }
    }
}
