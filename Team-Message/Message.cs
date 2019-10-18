using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Message
{
    class Message
    {
        public Gabe gabriel { get; set; }
        public Michael mike { get; set; }
        public Amy amers { get; set; }
        public Paul wolly {get; set; }


        public Message()
        {
            wolly = new Paul();
            amers = new Amy();
            gabriel = new Gabe();
            mike = new Michael();
        }

        public void printPaulMessage()
        {
            Console.WriteLine(wolly.message);
        }

        public void printAmyMessage()
        {
            Console.WriteLine(amers.message);
        }

        public void printMichaelMessage()
        {
            Console.WriteLine(mike.message);
        }

        public void printGabeMessage()
        {
            Console.WriteLine(gabriel.message);
        }
    }
    

}
