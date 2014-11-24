using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class DecoratorOne : IMessageWriter
    {
        IMessageWriter messageWriter;

        public DecoratorOne(IMessageWriter msgWrtr)
        {
            messageWriter = msgWrtr;
        }

        public string Message()
        {
            string msg = messageWriter.Message();
            msg += " To everyone!";
            return msg;
        }
    }
}
