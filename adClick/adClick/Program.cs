using Dominio.Entidades;
using Dominio.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace adClick
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.admimsy.com";
            
            driver.Autenticar(ObtenerAuth());
            var links = driver.ObtenerLinks();
            
            foreach(var l in links)
            {
                driver.Visitar(l);
            }
        }

        

        public static Autenticacion ObtenerAuth()
        {
            return new Autenticacion
            {
                Cookies = new List<Dominio.Entidades.Cookie>
                {
                    new Dominio.Entidades.Cookie{ Nombre = "ACCOUNT", Valor = "vdzub93kvas2r9eak1a89ntemzb3d6qp87arq8e5" },
                    new Dominio.Entidades.Cookie{ Nombre = "CFGLOBALS", Valor = "urltoken%3DCFID%23%3D257291571%26CFTOKEN%23%3Df28f54a3a90d64d8%2D2B9FD039%2DBA85%2D92E4%2D480AD78FE1EDC528%23lastvisit%3D%7Bts%20%272018%2D04%2D26%2020%3A01%3A39%27%7D%23hitcount%3D35%23timecreated%3D%7Bts%20%272018%2D04%2D26%2019%3A48%3A55%27%7D%23cftoken%3Df28f54a3a90d64d8%2D2B9FD039%2DBA85%2D92E4%2D480AD78FE1EDC528%23cfid%3D257291571%23"},
                    new Dominio.Entidades.Cookie{ Nombre = "CFID", Valor = "257291571"},
                    new Dominio.Entidades.Cookie{ Nombre = "CFTOKEN", Valor = "f28f54a3a90d64d8-2B9FD039-BA85-92E4-480AD78FE1EDC528"},
                    new Dominio.Entidades.Cookie{ Nombre = "PASSWORD", Valor = "BCD1C80CD8AEBA4CC69715AAAC7FA6E9799CF2C01649FF0016E432C2AD887F7A8F95D8B77DE7B494D51CAAB6E2C32D40B18C294EE5C7F260EE1C26D81E1EBCC5"},
                    new Dominio.Entidades.Cookie{ Nombre = "USER", Valor = "84026"},
                    new Dominio.Entidades.Cookie{ Nombre = "_ga", Valor = "GA1.2.1380251925.1524786565"},
                    new Dominio.Entidades.Cookie{ Nombre = "_gid", Valor = "GA1.2.2120496251.1524786565"}
                }
            };
        }
    }
}
