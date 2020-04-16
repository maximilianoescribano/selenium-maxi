using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar cantidad de Instancias y presionar Enter");
            var num = Convert.ToUInt16(Console.ReadLine());
            for (var i = 0; i < num; i++)
            {
                var opt = new ChromeOptions();
                opt.AddArgument("--ignore-certificate-errors");
                var driver = new ChromeDriver(opt);
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://stream.clawstudios.com:8443");
                driver.FindElementByCssSelector("#viewer").Click();
            }
        }
    }
}
