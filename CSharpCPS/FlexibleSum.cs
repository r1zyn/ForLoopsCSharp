namespace FlexibleSum
{
    class Program
    {
        public void Run()
        {
            Console.WriteLine("Enter the number of numbers you want to find the sum of: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= amount; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of the numbers 1-{amount} are: {sum}");
        }
    }
}