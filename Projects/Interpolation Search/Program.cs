int interpolationSearch(int[] arr, int lenght, int x)
{
    int low = 0;
    int high = lenght - 1;
    while(low<=high && x>=arr[low]&& x <= arr[high])
    {
        if (low == high)
        {
            if (arr[low] == x)
            {
                return low;
            }
            else
            {
                return -1;
            }

        }

        int pos = low + (high - low) / (arr[high] - arr[low]) * (x - arr[low]);

        if (arr[pos] == x)
        {

            return pos;
        }

        if (arr[pos] < x)
        {

            low = pos + 1;
        }
        else
        {
            high = pos - 1;
        }
    }
    return -1;
}