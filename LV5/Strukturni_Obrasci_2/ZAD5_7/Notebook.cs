using System;
using System.Collections.Generic;
using System.Text;

namespace ZAD5_7
{
    class Notebook
    {
        private ITheme defaultTheme;
        private List<Note> notes;
        public Notebook()
        { 
            this.notes = new List<Note>();
            defaultTheme = null;

        }

        public Notebook(ITheme theme)
        {
            notes = new List<Note>();
            this.defaultTheme = theme;
        }

        public void AddNote(Note note)
        {
            if(defaultTheme != null)
            {
                note.Theme = defaultTheme;  //Izmijenjeno u 7. zad

            }
            this.notes.Add(note);
            
        }



        public void ChangeTheme(ITheme theme)
        {
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach (Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }

    }
}
