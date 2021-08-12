using System;

namespace IsInclude
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 1, 2, 3, 3, 3, 5, 7, 9, 11, 15, 21, 22, 29, 38, 56, 101 };
            int[] subArray1 = new int[] { 3, 3, 3, 3, 5, 7 };
            int[] subArray2 = new int[] { 3, 5, 7 };
            int[] subArray3 = new int[] { 3, 3, 5, 7 };

            Console.WriteLine(EntryCheck.IsInclude(array, subArray1));
            Console.WriteLine(EntryCheck.IsInclude(array, subArray2));
            Console.WriteLine(EntryCheck.IsInclude(array, subArray3));

            Console.ReadKey();
        }
    }
}
