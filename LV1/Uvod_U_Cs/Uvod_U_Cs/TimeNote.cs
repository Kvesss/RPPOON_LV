using System;
using System.Collections.Generic;
using System.Text;

namespace Uvod_U_Cs
{
    class TimeNote : Note
    {
        private DateTime time;

        public void SetTime()
        {
            this.time = DateTime.Now;
        }



        public DateTime Time { get => time; set => time = value; }


        public TimeNote(string text, string author) : base(text, author)
        {
            this.Time = DateTime.Now;
        }

        public TimeNote(string text, string author, int priority) : base(text, author, priority)
        {
            this.Time = DateTime.Now;
        }

        public TimeNote():base()
        {
            this.Time = DateTime.Now;
        }

        public override string ToString()
        {
            return "Hello, my name is " + this.author + " " + this.text + ". This note is written in: "+ this.time.ToString();
        }
    }
}
