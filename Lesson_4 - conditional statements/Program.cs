namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a program that will start with declaration of two constants (X and Y) " +
                 "\nand will count the sum of all numbers between these constants. " +
                 "\nIf they are equal then sum should be one of them");
            Console.Write("\nPress any key to continue... ");
            Console.ReadLine();

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