
var primes = GetPrimesWith5DistinctDigits();

Console.WriteLine(primes.Count);

List<int> GetPrimesWith5DistinctDigits()
{
    List<int> result = new List<int>();

    for (int i=10000; i<99999; i++) 
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