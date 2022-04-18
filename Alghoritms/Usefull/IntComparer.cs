namespace Alghoritms.Usefull
{
    public class IntComparer : IComparer<int>
    {
        public int Compare(int x, int y) => x.CompareTo(y);
    }
}
