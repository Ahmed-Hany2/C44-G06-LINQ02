namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators

            // 1. Uses Count to get the number of odd numbers in the array
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddCount = Arr.Count(n => n % 2 != 0);


            #endregion
        }
    }
}
