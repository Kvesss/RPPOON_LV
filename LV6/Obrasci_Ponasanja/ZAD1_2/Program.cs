using System;

namespace ZAD1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zad 1.
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("Taxi", "5 dollars"));
            notebook.AddNote(new Note("Forrest Gump", "Run Forrest run!"));
            notebook.AddNote(new Note("Lord of the rings", "What about second breakfast?"));
            IAbstractIterator notebookIterator = notebook.GetIterator();
            notebookIterator.First().Show();
            while (notebookIterator.Next() != null)
            {
                notebookIterator.Current.Show();
            }

            //Zad 2.

            Box box = new Box();
            box.AddProduct(new Product("Keyboard", 199.99));
            box.AddProduct(new Product("Mouse", 249.99));
            box.AddProduct(new Product("Headset", 299.99));
            IBoxIterator boxIterator = box.GetIterator();
            Console.WriteLine(boxIterator.First().ToString());
            while (boxIterator.Next() != null)
            {
                Console.WriteLine(boxIterator.Current.ToString());
            }
        }
    }
}
