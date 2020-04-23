using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD7
{
    public enum Category { ERROR, ALERT, INFO }
    class ConsoleNotification : ICloneable
    {
        public String Author { get; private set; }
        public String Title { get; private set; }
        public String Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }
        public ConsoleNotification(String author, String title,
        String text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }
        public ConsoleNotification()
        {

        }

        public object Clone()
        {
            ConsoleNotification clone = new ConsoleNotification(this.Author, this.Title, this.Text, this.Timestamp, this.Level, this.Color);
            return (ConsoleNotification)clone;
            /*Hoće li biti razlike između plitkog i dubokog kopiranja ovisi o svrsi tih obavijesti i njihovih kopija.
            U ovom slučaju ne mijenjaju se atributi poruka već je bitno samo stvoriti kopiju pa je dovoljno i plitko kopiranje,
            ali ako bi npr. trebalo uvesti promjenu stanja , a staru verziju sačuvati  tada bi bilo potrebno duboko kopiranje
            kako bi kloniranje stvorilo novi neovisan objekt.*/
        }
    }
}
