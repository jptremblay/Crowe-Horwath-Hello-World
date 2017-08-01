using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorldAPI
{
    internal interface IApplicationMode
    {
        void SetMessage(string Message);
        void WriteMessage();
        string ReturnMessage();
    }
}
