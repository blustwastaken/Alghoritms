namespace Alghoritms.Sort
{
    /// <summary>
    ///     Class that implements bubble sort algorithm.
    /// </summary>
    /// <typeparam name="T">Type of array element.</typeparam>
    public class BubbleSorter<T>
    {
        public IEnumerable<T> Sort(T[] array, IComparer<T> comparer)
        {
            for(int i = 0; i < array.Length - 1; i++)
                for(int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparer.Compare(array[j],array[j+1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            return array;
        }
    }
}
