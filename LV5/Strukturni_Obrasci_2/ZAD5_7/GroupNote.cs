using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    class GroupNote : Note
    {
        private List<string> names;

        public GroupNote(string message, ITheme theme, List<string> newNames = null) : base(message, theme)
        {
            this.names = new List<string>();
            if (newNames != null)
            {
                foreach(string Name in newNames)
                {
                    names.Add(Name);
                }
            }

        }
        public void AddName(string name)
        {
            names.Add(name);
        }
        public void AddNames(List<string> newNames)
        {
            foreach(string newName in newNames)
            {
                names.Add(newName);
            }
        }

        public void RemoveName(string Name)
        {
            for(int i=0; i < names.Count; i++) 
            {
                if (names[i] == Name)
                {
                    names.RemoveAt(i);
                    i--;
                }
            }
        }

        public void PrintNames()
        {
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("Group Note: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            PrintNames();
            Console.ResetColor();
        }
    }
}
