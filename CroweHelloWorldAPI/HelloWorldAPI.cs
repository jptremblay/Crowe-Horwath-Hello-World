using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorldAPI
{
    public class ConsoleMode : IApplicationMode
    {
        public string ConsoleMessage;

        public void SetMessage(string message)
        {
            ConsoleMessage = message;
        }
        public void WriteMessage()
        {
            Console.WriteLine(ConsoleMessage);
        }
        public string ReturnMessage()
        {
            return ConsoleMessage;
        }
    }

    public class DatabaseMode : IApplicationMode
    {
        public string ConsoleMessage;

        public void SetMessage(string message)
        {
            ConsoleMessage = message;
        }
        public void WriteMessage()
        {
            Console.WriteLine(ConsoleMessage);
        }
        public string ReturnMessage()
        {
            return ConsoleMessage;
        }
    }

    public class ApplicationSetting
    {

    }

}
