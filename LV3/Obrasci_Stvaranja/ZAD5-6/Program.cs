using System;

namespace ZAD5
{
    class Program
    {
        static void Main(string[] args)
        {
            NotificationDirector director = new NotificationDirector();
            IBuilder notificationBuilder = new NotificationBuilder();
            director.ConstructAlertNotification(notificationBuilder, "David Kvesic");
            ConsoleNotification note = notificationBuilder.Build();
            NotificationManager manager = new NotificationManager();
            manager.Display(note);
        }
    }
}
