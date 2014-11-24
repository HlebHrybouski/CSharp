using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Client
    {
        public static void Write(IMessageWriter writer)
        {
            Console.WriteLine(writer.Message());
        }
    }
}
