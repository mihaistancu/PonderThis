var primes = Get5DigitPrimes();

List<int> Get5DigitPrimes()
{
    List<int> result = new List<int>();

    for (int i=10000; i<99999; i++) 
    {
        if (IsPrime(i)) 
        {
            result.Add(i);
        }
    }

    return result;
}

bool IsPrime(int n)
{
    double limit = Math.Sqrt(n);

    for (int i=2;i<limit;i++) {
        if (n % i == 0) return false;
    }    

    return true;
}