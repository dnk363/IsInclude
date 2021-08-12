
namespace IsInclude
{
    public class EntryCheck
    {
        public static bool IsInclude(int[] array, int[] subarray)
        {
            if (subarray.Length == 0)
                return true;

            int startIndex = SearchRightEntry(array, subarray[0], 0, array.Length - 1);
            int firstElementCount = GetFirstElementReapeatCount(subarray);

            startIndex = startIndex - firstElementCount + 1;

            if (startIndex < 0)
            {
                return false;
            }
            else
            {
                for (int i = startIndex; i < subarray.Length + startIndex; i++)
                {
                    if (array[i] != subarray[i - startIndex])
                        return false;
                }
            }

            return true;
        }

        private static int SearchRightEntry(int[] array, int key, int left, int right)
        {
            if (left > right)
                return -1;

            int mid = (left + right) / 2;

            if (array[mid] == key)
            {
                int index = SearchRightEntry(array, key, mid + 1, right);

                if (index > mid)
                    return index;
                else
                    return mid;
            }
            else
            {
                if (array[mid] > key)
                    return SearchRightEntry(array, key, left, mid - 1);
                else
                    return SearchRightEntry(array, key, mid + 1, right);
            }
        }

        private static int GetFirstElementReapeatCount(int[] array)
        {
            int count = 1;

            if (array.Length == 1)
                return count;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                    count++;
                else
                    break;
            }

            return count;
        }
    }
}
