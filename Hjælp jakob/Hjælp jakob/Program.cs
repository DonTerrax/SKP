using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_jakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message("Test@test.dk","Mike@Mike.dk","test","endnu en test","Lad os se om det virker");

            string[] recivers = new string[4] {"ali", "hans", "laura", "mikkel" };

            SendMessage sendMessage = new SendMessage();

            sendMessage.sendMessage(MessageCarrier.Smtp,message,true);

            sendMessage.sendMessageToAll(MessageCarrier.Smtp, recivers, message,true);
        }


        

  
    }
}
