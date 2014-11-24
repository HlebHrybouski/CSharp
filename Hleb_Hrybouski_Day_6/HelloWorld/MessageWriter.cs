using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class MessageWriter : IMessageWriter
    {
        public string Message()
        {
            return "Hello world!";
        }
    }
}
