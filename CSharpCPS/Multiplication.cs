namespace Multiplication
{
    class Program
    {
        public void Run()
        {
            Console.WriteLine("Enter the number you want to multiply: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }
    }
}