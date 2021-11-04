using System;
using System.Collections.Generic;
using System.Text;

namespace _06_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();

            Subsciriber sub1 = new Subsciriber("Yamen");
            Subsciriber sub2 = new Subsciriber("Anna");
            Subsciriber sub3 = new Subsciriber("Fredrik");

            publisher.SendMessage += sub1.HandleMessageRecieved;
            publisher.SendMessage += sub2.HandleMessageRecieved;
            publisher.SendMessage += sub3.HandleMessageRecieved;

            publisher.OnSendMessage("Hi");
            Console.WriteLine();
            publisher.SendMessage -= sub2.HandleMessageRecieved;
            publisher.OnSendMessage("Hi there");
        }

        class MessageEventArgs : EventArgs
        {
            public MessageEventArgs(string message)
            {
                Message = message;
            }

            public string Message { get; set; }
        }

        class Publisher
        {
            //public delegate void SendMessage(object sender, MessageEventArgs args);

            public event EventHandler<MessageEventArgs> SendMessage;

            public void OnSendMessage(string text)
            {
                SendMessage.Invoke(this, new MessageEventArgs(text));
            }
        }

        class Subsciriber
        {
            private string name;

            public Subsciriber(string name)
            {
                this.name = name;
            }

            public void HandleMessageRecieved(object sender, MessageEventArgs args)
            {
                Console.WriteLine($"{name} got a message: {args.Message}!");
            }
        }

    }
}
