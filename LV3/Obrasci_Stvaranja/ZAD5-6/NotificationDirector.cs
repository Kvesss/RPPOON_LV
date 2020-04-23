using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5
{
    class NotificationDirector
    {
        public void ConstructInfoNotification(IBuilder builder, String author)
        {
            builder.SetAuthor(author).SetLevel(Category.INFO);
        }
        public void ConstructAlertNotification(IBuilder builder, String author)
        {
            builder.SetAuthor(author).SetLevel(Category.ALERT);
        }
        public void ConstructErrorNotification(IBuilder builder, String author)
        {
            builder.SetAuthor(author).SetLevel(Category.ERROR);
        }
    }
}
