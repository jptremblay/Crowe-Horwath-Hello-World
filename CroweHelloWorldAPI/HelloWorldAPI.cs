using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorldAPI
{
    public class HelloWorldApp
    {
        IApplicationMode mode;

        public void SetMode(IApplicationMode mode)
        {
            this.mode = mode;
        }

        public IApplicationMode GetMode()
        {
            return mode;
        }

        public void SetMessage(string message)
        {
            mode.SetMessage(message);
        }
        public string ReturnMessage()
        {
            return mode.ReturnMessage();
        }
        public void WriteMessage()
        {
            mode.WriteMessage();
        }
    }

    /// <summary>
    /// Inherits from IApplicationMode. Will execute by default or if ApplicationMode setting in AppSettings is 'Console'
    /// </summary>
    public class ConsoleMode : IApplicationMode
    {
        private string ConsoleMessage;

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

    /// <summary>
    /// Inherits from IApplicationMode. Will execute if ApplicationMode setting in AppSettings is 'Database'
    /// </summary>
    public class DatabaseMode : IApplicationMode
    {
        private string ConsoleMessage;

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
}
