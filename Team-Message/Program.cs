using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Message communication = new Message();
            communication.printAmyMessage();
            communication.printGabeMessage();
            communication.printMichaelMessage();
            communication.printPaulMessage();
            Console.ReadKey();
        }
    }
}
