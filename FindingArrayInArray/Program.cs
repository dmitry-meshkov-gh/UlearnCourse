int[] firstArray = new int[8] {1, 2, 4, 5, 6, 4, 5, 8};
int[] secondArray = new int[2] { 4, 5 };
FindSubarrayStartIndex(firstArray, secondArray);


static int FindSubarrayStartIndex(int[] array, int[] subArray)
{
    for (var i = 0; i < array.Length - subArray.Length + 1; i++)
        if (ContainsAtIndex(array, subArray, i))
            return i;
    return -1;
}
static bool ContainsAtIndex(int[] array, int[] subArray, int index)
{
    for (int i = 0; i < subArray.Length; i++)
    {
        if (array[index + i] == subArray[i])
            continue;
        else return false;
    }
    return true;
}