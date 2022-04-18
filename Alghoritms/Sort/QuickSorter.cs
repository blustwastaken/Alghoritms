namespace Alghoritms.Sort
{
    public class QuickSorter<T>
    {
        /// <summary>
        /// Sort array by QuickSort alghoritms
        /// </summary>
        /// <param name="array"></param>
        /// <param name="comparer"></param>
        /// <returns>Sorted List of T</returns>
        public IEnumerable<T> Sort(T[] array, IComparer<T> comparer)
        {
            if (array.Length <= 1)
                return array;

            List<T> left = new List<T>();
            List<T> right = new List<T>();
            List<T> middle = new List<T>();
            T middleElement = array[array.Length/2];

            for(int i = 0; i<array.Length; i++)
            {
                if (comparer.Compare(array[i], middleElement) == 0)
                    middle.Add(array[i]);
                else if (comparer.Compare(array[i], middleElement) > 0)
                    right.Add(array[i]);
                else
                    left.Add(array[i]);
            }

            T[] leftArray = left.ToArray();
            T[] rightArray = right.ToArray();
            T[] middleArray = middle.ToArray();

            return Sort(leftArray, comparer)
                .Concat(middleArray)
                .Concat(Sort(rightArray, comparer));
        }
    }
}
