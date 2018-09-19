using System;
using System.Collections.Generic;
namespace LessthanThree.Domain
{
    public class DM
    {
        //Inbox and outbox consist of an array of strings, of length 3 (Three)
        //0 will corrospond to the sender, 1 will corrospond to the receiver and
        //2 will contain the message
        List<string[]> Inbox;
        List<string[]> Outbox;
        public DM()
        {
            Inbox = new List<string[]>();
            Outbox = new List<string[]>();
        }

        public void SendMessage(Person sender, Person receiver, string text)
        {
            string[] message = new string[3];
            message[0] = sender.FirstName;
            message[1] = receiver.FirstName;

            Console.WriteLine("\n\tWrite the message you want to send!");
            message[2] = Console.ReadLine();

            receiver.Messages.Inbox.Add(message);
            sender.Messages.Outbox.Add(message);
        }
    }
}
