using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class DecoratorTwo : IMessageWriter
    {
        IMessageWriter messageWriter;

        public DecoratorTwo(IMessageWriter msgWrtr)
        {
            messageWriter = msgWrtr;
        }

        public string Message()
        {
            string msg = messageWriter.Message();
            msg += " I LOVE YOU!";
            return msg;
        }
    }
}
