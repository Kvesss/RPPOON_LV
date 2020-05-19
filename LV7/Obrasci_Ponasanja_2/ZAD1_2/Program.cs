using System;

namespace ZAD1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad 1
            Console.WriteLine("==========ZAD 1==========");
            double[] numbers = new double[10] { 7, 4.4, 5.5, 6, 1.1, 3.3, 2.2, 10, 9, 8 };
            SortStrategy sequentialSortStrategy = new SequentialSort();
            SortStrategy bubbleSortStrategy = new BubbleSort();
            SortStrategy combSortStrategy = new CombSort();
            NumberSequence sequentialSortedNumbers = new NumberSequence(numbers);
            sequentialSortedNumbers.SetSortStrategy(sequentialSortStrategy);
            sequentialSortedNumbers.Sort();
            NumberSequence bubblelSortedNumbers = new NumberSequence(numbers);
            bubblelSortedNumbers.SetSortStrategy(bubbleSortStrategy);
            bubblelSortedNumbers.Sort();
            NumberSequence combSortedNumbers = new NumberSequence(numbers);
            combSortedNumbers.SetSortStrategy(combSortStrategy);
            combSortedNumbers.Sort();
            Console.WriteLine(sequentialSortedNumbers.ToString());
            Console.WriteLine(bubblelSortedNumbers.ToString());
            Console.WriteLine(combSortedNumbers.ToString());

            //Zad 2
            Console.WriteLine("==========ZAD 2==========");
            NumberSequence numberSequence = new NumberSequence(numbers);
            SearchStrategy linearSearch = new LinearSearch();
            SearchStrategy binarySearch = new BinarySearch();
            numberSequence.SetSortStrategy(sequentialSortStrategy);
            numberSequence.Sort();

            numberSequence.SetSearchStrategy(linearSearch);
            Console.WriteLine(numberSequence.Search(6));
            numberSequence.SetSearchStrategy(binarySearch);
            Console.WriteLine(numberSequence.Search(6));

            numberSequence.SetSearchStrategy(linearSearch);
            Console.WriteLine(numberSequence.Search(5));
            numberSequence.SetSearchStrategy(binarySearch);
            Console.WriteLine(numberSequence.Search(5));
        }
    }
}
