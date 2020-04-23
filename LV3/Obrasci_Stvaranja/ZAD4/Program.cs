using System;

namespace ZAD4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Author = "John Doe";
            string Title = "Title";
            string Text = "Hello World";
            DateTime Timestamp = DateTime.Now;
            Category Level = Category.ALERT;
            ConsoleColor Color = ConsoleColor.Cyan;
            ConsoleNotification notification = new ConsoleNotification(Author, Title, Text, Timestamp, Level, Color);
            NotificationManager manager = new NotificationManager();
            manager.Display(notification);
        }
    }
}
