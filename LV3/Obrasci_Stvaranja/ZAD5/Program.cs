using System;

namespace ZAD5
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationDirector director = new NotificationDirector();
            NotificationBuilder alertBuilder = new NotificationBuilder();
            director.ConstructAlertNotification(alertBuilder, "David Kvesic");
            ConsoleNotification alertNote = alertBuilder.Build();
            NotificationManager manager = new NotificationManager();
            manager.Display(alertNote);

            NotificationBuilder ErrorBuilder = new NotificationBuilder();
            ErrorBuilder.SetColor(ConsoleColor.Magenta);
            director.ConstructErrorNotification(ErrorBuilder, "John Doe");
            ErrorBuilder.SetText("Hello World!");
            ConsoleNotification errorNote = ErrorBuilder.Build();
            manager.Display(errorNote);
        }
    }
}
