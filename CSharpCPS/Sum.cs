namespace Sum
{
    class Program
    {
        public void Run()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of the numbers 1-10 are: {sum}");
        }
    }
}