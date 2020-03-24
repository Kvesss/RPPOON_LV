using System;
using System.Collections.Generic;
using System.Text;

namespace Uvod_U_Cs
{
    class ToDo
    {
        private List<Note> notes;

        public ToDo()
        {
            this.notes = new List<Note>();
        }

        public void Add(Note note)
        {
            notes.Add(note);
        }

        public void Remove(Note note)
        {
            notes.Remove(note);
        }

        public void RemoveAt(int index)
        {
            notes.RemoveAt(index);
        }
        public Note GetNoteAt(int index)
        {
            return notes[index];
        }

        public override string ToString()
        {
            StringBuilder allNotes = new StringBuilder();
            foreach (Note note in notes)
            {
                allNotes.Append(note).Append("\n");
            }
            return allNotes.ToString();
        }
        public void PrintNotes()
        {
            Console.WriteLine(ToString());
        }

        public void ExecuteHighPriorites()
        {
            foreach(Note note in notes.ToArray())
            {
                if (note.IsHighPriority())
                {
                    Remove(note);
                }
            }
        }

        
    }
}
