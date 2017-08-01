using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CroweHelloWorldAPI;

namespace CroweHelloWorldApp
{
    class Program
    {
        private const string HELLO_WORLD_MESSAGE = "Hello World";
        public static void Main(string[] args)
        {
            HelloWorldApp app = new HelloWorldApp();
            var appMode = ConfigurationManager.AppSettings["ApplicationMode"];

            switch (appMode)
            {
                case "Console":
                    app.SetMode(new ConsoleMode());
                    app.SetMessage(HELLO_WORLD_MESSAGE);
                    app.WriteMessage();
                    break;
                case "Database":
                    app.SetMode(new DatabaseMode());
                    app.SetMessage(HELLO_WORLD_MESSAGE);
                    app.WriteMessage();
                    break;
                default:
                    app.SetMode(new ConsoleMode());
                    app.SetMessage(HELLO_WORLD_MESSAGE);
                    app.WriteMessage();
                    break;
            }

            Console.ReadKey();
        }
    }
}
