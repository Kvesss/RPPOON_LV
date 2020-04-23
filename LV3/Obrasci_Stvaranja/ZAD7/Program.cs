using System;

namespace ZAD7
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationDirector director = new NotificationDirector();
            NotificationBuilder builder = new NotificationBuilder();
            NotificationManager manager = new NotificationManager();
            builder.SetColor(ConsoleColor.Green);
            builder.SetText("Test");
            director.ConstructInfoNotification(builder, "David Kvesic");
            ConsoleNotification note = builder.Build();
            manager.Display(note);
            ConsoleNotification clone = (ConsoleNotification)note.Clone();
            manager.Display(clone);
        }
    }
}
