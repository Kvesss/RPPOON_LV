using System;

namespace ZAD5
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationManager manager = new NotificationManager();
            NotificationDirector director = new NotificationDirector();
            NotificationBuilder Builder = new NotificationBuilder();
            director.ConstructAlertNotification(Builder, "David Kvesic");
            ConsoleNotification alertNote = Builder.Build();
            manager.Display(alertNote);

            //NotificationBuilder ErrorBuilder = new NotificationBuilder();
            Builder.SetColor(ConsoleColor.Magenta);
            director.ConstructErrorNotification(Builder, "John Doe");
            Builder.SetText("Hello World!");
            ConsoleNotification errorNote = Builder.Build();
            manager.Display(errorNote);

            Builder.SetColor(ConsoleColor.Green);
            Builder.SetText("Information");
            ConsoleNotification infoNote = Builder.Build();
            director.ConstructInfoNotification(Builder, "Unknown");
            manager.Display(infoNote);


        }
    }
}
