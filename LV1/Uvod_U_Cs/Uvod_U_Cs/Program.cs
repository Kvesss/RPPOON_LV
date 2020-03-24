using System;

namespace Uvod_U_Cs
{
    class Program
    {
        public static Note GenerateNote()
        {
            
            string noteText = Console.ReadLine(); 
            string noteAuthor = Console.ReadLine();
            string notePriority = Console.ReadLine();
            int priorityValue = int.Parse(notePriority);
            return new Note(noteText, noteAuthor, priorityValue);
        }


        static void Main(string[] args)
        {
            Note firstNote = new Note("I'm first note!", "Johnny Bravo", 1);
            Note secondNote = new Note("I'm second note!", "Tyson Fury");
            Note thirdNote = new Note();
            Console.WriteLine(firstNote.ToString());
            Console.WriteLine(secondNote.ToString());
            Console.WriteLine(thirdNote.ToString());
            TimeNote firstTimeNote = new TimeNote("First time note", "Heisenberg", 1);
            Console.WriteLine(firstTimeNote.ToString());

            ToDo notesList = new ToDo();
            for(int count=0; count < 3; count++)
            {
                notesList.Add(GenerateNote());
            }
            Console.WriteLine(notesList.ToString());

            notesList.ExecuteHighPriorites();

            Console.WriteLine(notesList.ToString());
        }
    }

}
