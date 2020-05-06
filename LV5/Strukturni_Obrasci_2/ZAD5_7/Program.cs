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
            GroupNote homeTeam = new GroupNote("Football, 5PM. ", consoleTheme);
            List<string> homeTeamPlayers = new List<string>();
            homeTeamPlayers.Add("Luis Nazario de Lima Ronaldo");
            homeTeamPlayers.Add("Ronaldo de Assis Morreira");
            homeTeamPlayers.Add("Luis Figo");
            homeTeam.AddNames(homeTeamPlayers);
            homeTeam.AddName("Milan Rapaić");
            homeTeam.RemoveName("Luis Figo");
            homeTeam.Show();

            consoleTheme = new MagentaWhiteTheme();
            GroupNote awayTeam = new GroupNote("Football, 5PM. ", consoleTheme);
            List<string> awayTeamPlayers = new List<string>();
            awayTeamPlayers.Add("Edgar Davids");
            awayTeamPlayers.Add("Christian Vieri");
            awayTeamPlayers.Add("Ruud Van Nistelrooy");
            awayTeam.AddNames(awayTeamPlayers);
            awayTeam.Show();


            //Zad 7
            Console.WriteLine("Zad 7    *************************");
            Notebook notebook = new Notebook();
            notebook.AddNote(note);
            notebook.AddNote(homeTeam);
            notebook.Display();

            consoleTheme = new LightTheme();
            notebook.ChangeTheme(consoleTheme);
            notebook.Display();

            ITheme MagentaWhiteTheme = new MagentaWhiteTheme();
            Notebook magentaNotebook = new Notebook(MagentaWhiteTheme);
            magentaNotebook.AddNote(note);
            magentaNotebook.AddNote(homeTeam);
            magentaNotebook.Display();

        }
    }
}
