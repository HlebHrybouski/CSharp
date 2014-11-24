using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageWriter writer = new MessageWriter();
            IMessageWriter writer1 = new DecoratorOne(writer);
            IMessageWriter writer2 = new DecoratorTwo(writer);
            Client.Write(writer);
            Client.Write(writer1);
            Client.Write(writer2);
            Client.Write(new DecoratorOne(new DecoratorTwo(writer)));
            Console.Read();
        }
    }
}
