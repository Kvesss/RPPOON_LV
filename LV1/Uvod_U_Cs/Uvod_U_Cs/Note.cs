using System;
using System.Collections.Generic;
using System.Text;

namespace Uvod_U_Cs
{

    class Note
    {
        protected string text;
        protected string author;
        protected int priority;

        public string GetText()
        {
            return this.text;
        }
        public string GetAuthor()
        {
            return this.author;
        }

        public int GetPriority()
        {
            return priority;
        }

        public void SetText(string text)
        {
            this.text = text;
        }
        private void SetAuthor(string author)
        {
            this.author = author;
        }

        public Note()
        {
            this.text = "/";
            this.author = "John Doe";
            this.priority = 0;
        }

        public Note(string text, string author)
        {
            this.text = text;
            this.author = author;
            this.priority = 0;
        }

        public Note(string text, string author, int priority)
        {
            this.text = text;
            this.author = author;
            this.priority = priority;
        }

        public string Text { get => text; set => text = value; }
        public string Author { get => author;private set => author = value; }

        public override string ToString()
        {
            return "Hello, my name is " + this.author + " " + this.text;
        }

        public bool IsHighPriority()
        {
            return priority == 1;
        }
    }
}
