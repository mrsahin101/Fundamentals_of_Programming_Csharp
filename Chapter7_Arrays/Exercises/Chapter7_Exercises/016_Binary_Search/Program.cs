/*  Write a program, which uses a binary search in a sorted array of
    integer numbers to find a certain element.
*/

int[] mySortedArray = { 1, 3, 4, 5, 8, 11, 15, 19, 21, 55 };

static int binarySearch(int[] arr, int x)
{
    int left = 0, right = arr.Length - 1;
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        // Check if x is present at mid
        if (arr[mid] == x)
            return mid;

        // If x greater, ignore left half
        if (arr[mid] < x)
            left = mid + 1;

        // If x is smaller, ignore right half
        else
            right = mid - 1;
    }

    // if we reach here, then element was
    // not present
    return -1;
}

int searchedNumber = 2;

if (binarySearch(mySortedArray, searchedNumber) == -1)
    Console.WriteLine("Element is not present in array!");
else
    Console.WriteLine("Element found at index : {0}", binarySearch(mySortedArray, searchedNumber));