using Alghoritms.Sort;
using Alghoritms.Usefull;

void PrintArray<T>(IEnumerable<T> array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int[] array = {6,5,4,3,2,1};

PrintArray(new BubbleSorter<int>().Sort(array, new IntComparer()));

PrintArray(new SelectionSorter<int>().Sort(array, new IntComparer()));

PrintArray(new QuickSorter<int>().Sort(array, new IntComparer()));