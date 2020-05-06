using System;
using System.Collections.Generic;

namespace ZAD5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zad 5    *************************");

            ITheme consoleTheme = new LightTheme();
            Note note = new ReminderNote("Light", consoleTheme);
            note.Show();

            //Zad 5
            consoleTheme = new BrasilTheme();
            note = new ReminderNote("Joga Bonito ", consoleTheme);
            note.Show();

            Console.WriteLine("Zad 6    *************************");
            //Zad 6
            GroupNote groupNote = new GroupNote("Football, 5PM. ", consoleTheme);
            List<string> players = new List<string>();
            players.Add("Luis Nazario de Lima Ronaldo");
            players.Add("Ronaldo de Assis Morreira");
            players.Add("Luis Figo");
            groupNote.AddNames(players);
            groupNote.Show();
            groupNote.AddName("Milan Rapaić");
            groupNote.RemoveName("Luis Figo");
            groupNote.Show();

            //Zad 7
            Console.WriteLine("Zad 7    *************************");
            Notebook notebook = new Notebook();
            notebook.AddNote(note);
            notebook.AddNote(groupNote);
            notebook.Display();

            consoleTheme = new LightTheme();
            notebook.ChangeTheme(consoleTheme);
            notebook.Display();

            ITheme MagentaWhiteTheme = new MagentaWhiteTheme();
            Notebook magentaNotebook = new Notebook(MagentaWhiteTheme);
            magentaNotebook.AddNote(note);
            magentaNotebook.AddNote(groupNote);
            magentaNotebook.Display();

        }
    }
}
