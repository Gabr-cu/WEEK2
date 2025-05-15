namespace PrimeFactorLibrary
{
    public static class PrimeFactorizer
    {
        public static string PrimeFactors(int number)
        {
            if (number < 2 || number > 1000)
                throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 2 and 1000.");

            var factors = new List<int>();
            int divisor = 2;

            while (number > 1)
            {
                if (number % divisor == 0)
                {
                    factors.Add(divisor);
                    number /= divisor;
                }
                else
                {
                    divisor++;
                }
            }

            return string.Join(" x ", factors);
        }
    }
}
