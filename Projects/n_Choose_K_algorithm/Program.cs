
int numberOfPossibleCombinations(int n, int k)
{

    if (k == 0 || k==n)
    {
        return 1;

    }
    else
    {

        return numberOfPossibleCombinations(n - 1, k) + numberOfPossibleCombinations(n - 1, k - 1);

    }
}

Console.WriteLine(numberOfPossibleCombinations(3,2));