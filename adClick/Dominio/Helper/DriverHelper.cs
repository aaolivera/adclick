using Dominio.Entidades;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Dominio.Helper
{
    public static class DriverHelper
    {
        public static void Autenticar(this IWebDriver driver, Autenticacion auth)
        {
            driver.Manage().Cookies.DeleteAllCookies();
            foreach (var c in auth.Cookies)
            {
                driver.Manage().Cookies.AddCookie(new OpenQA.Selenium.Cookie(c.Nombre, c.Valor));
            }
        }

        public static List<string> ObtenerLinks(this IWebDriver driver)
        {
            driver.Url = "http://www.admimsy.com/Main.cfm";
            var elements = driver.FindElements(By.XPath("//*[@class='LeftWhole']//a"));
            var retorno = new List<string>();
            foreach (var r in elements)
            {
                retorno.Add(r.GetAttribute("href"));
            }
            return retorno;
        }

        public static void Visitar(this IWebDriver driver, string url)
        {
            
            driver.Url = url;
            while (driver.FindElements(By.XPath("//*[@class='TheTopMainMenu2']")).Any())
            {
                Thread.Sleep(1000);
            }
        }
    }
}
