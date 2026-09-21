using SortingAlgorithm;
using System.Collections;

Console.WriteLine("This program sorts some numbers.");
Random randomInt = new Random();
ArrayList myCollection = new ArrayList();
Console.WriteLine("how many numbers do you want?");
MySortingAlgos sorters = new MySortingAlgos();
int amountofInts = int.Parse(Console.ReadLine());

for (int i = 0; i < amountofInts; i++)
{
    int myint = randomInt.Next(1, 100);
    myCollection.Add(myint);
}

foreach (int item in myCollection)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
Console.WriteLine("Start sorting!");

sorters.InsertionSort(myCollection);
sorters.SelectionSort(myCollection);
sorters.MergeSortcall(myCollection);