using System;

namespace Interface
{
    class Program
    {

        public interface Inotifications
        {
            
           
        }

        public class Notification : Inotifications
        {
            private string sender;
            private string message;
            private string date;

            // Default constructor
            public Notification()
            {
                sender = "Admin";
                message = "You what is up?";
                date = " ";
            }

            public Notification(string mySender, string myMessage, string myDate)
            {
                this.sender = mySender;
                this.message = myMessage;
                this.date = myDate;
            }

            public void shownotification()
            {
                Console.WriteLine("Message {0} - was sent by {1} - at {2}",message,sender,date);
            }

            string getDate()
            {
                return date;
            }
        }






        static void Main(string[] args)
        {
            Notification n1 = new Notification("Mike", "Sup bra", "Today");
            Notification n2 = new Notification("Jakub","yes","igår");

            n1.shownotification();
            n2.shownotification();
            
        }
    }
}
