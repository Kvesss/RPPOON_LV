using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD7
{
    class NotificationBuilder : IBuilder
    {
        public String Author { get; private set; }
        public String Title { get; private set; } = "";
        public String Text { get; private set; } = "Empty note";
        public DateTime Time { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; } = ConsoleColor.White;
        public ConsoleNotification Build()
        {
            return new ConsoleNotification(Author, Title, Text, Time=DateTime.Now, Level, Color);
        }

        public IBuilder SetAuthor(string author)
        {
            this.Author = author;
            return this;
        }

        public IBuilder SetColor(ConsoleColor color)
        {
            this.Color = color;
            return this;
        }

        public IBuilder SetLevel(Category level)
        {
            this.Level = level;
            return this;
        }

        public IBuilder SetText(string text)
        {
            this.Text = text;
            return this;
        }

        public IBuilder SetTime(DateTime time)
        {
            this.Time = time;
            return this;
        }

        public IBuilder SetTitle(string title)
        {
            this.Title = title;
            return this;
        }
    }
}
