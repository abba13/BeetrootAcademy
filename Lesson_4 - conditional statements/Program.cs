namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random random = new Random();
            int x = random.Next(0, 10);          
            int y = random.Next(0, 10);
            int summ = 0;
            Console.WriteLine("number x = " + x);
            Console.WriteLine("number y = " + y);

            if (x == y)
            {
                summ = x;
                Console.WriteLine("numbers equaly:  " + summ);
            }
            else if (x < y)
            {
                for (int i = x; i <= y; i++) summ += i;
                Console.WriteLine("sum of all numbers between x...y:  " + summ);
            }
            else if (y < x)
            {
                for (int i = y; i <= x; i++) summ += i;
                Console.WriteLine("sum of all numbers between y...x:  " + summ);
            }

        }
    }
}