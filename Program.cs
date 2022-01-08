var primes = GetPrimesWithDistinctDigits(5);

Console.WriteLine(primes.Count);

int GetMinWithGivenDigits(int d)
{
    return d == 1 
        ? 1 :
        10 * GetMinWithGivenDigits(d-1);
}

List<int> GetPrimesWithDistinctDigits(int d)
{
    List<int> result = new List<int>();

    int min = GetMinWithGivenDigits(d);
    int max = GetMinWithGivenDigits(d + 1) - 1;

    for (int i=min; i<max; i++) 
    {
        if (IsPrime(i) && AreDigitsDistinct(i)) 
        {
            result.Add(i);
        }
    }

    return result;
}

bool AreDigitsDistinct(int n) 
{
    int[] digits = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

    while (n / 10 > 0) 
    {
        n = n / 10;
        if (digits[n % 10] > 0) return false;
        digits[n % 10]++;
    }

    return true;
}

bool IsPrime(int n)
{
    double limit = Math.Sqrt(n);

    for (int i=2;i<limit;i++) {
        if (n % i == 0) return false;
    }    

    return true;
}