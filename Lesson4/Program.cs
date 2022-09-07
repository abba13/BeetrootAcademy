namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** Declaration of two randomaly constants (X and Y) and will count the sum of all numbers between ***\n");

            Random random = new Random();
            int x = random.Next(0, 10);
            int y = random.Next(0, 10);

            Console.WriteLine("number x = " + x);
            Console.WriteLine("number y = " + y);

            if (x != y)
            {
                int xMax = (y*(y + 1))/2 - ((x-1)*((x-1) + 1))/2;
                int yMax = (x*(x + 1))/2 - ((y-1)*((y-1) + 1))/2;
                int summ = (x < y) ? xMax : yMax;
                Console.WriteLine("sum of all numbers between:  " + summ);
            }
            else Console.WriteLine("x equals y " + x);

            Console.WriteLine("\n*** Extr ***");

            bool parseResult1;
            bool parseResult2;
            int x1;
            int y1;

            do
            {
                Console.Write("Enter X = ");
                string number1 = Console.ReadLine();
                parseResult1 = int.TryParse(number1, out x1);

                Console.Write("Enter Y = ");
                string number2 = Console.ReadLine();
                parseResult2 = int.TryParse(number2, out y1);

                if (parseResult1 == parseResult2) break;

                Console.WriteLine("Can not parse try again");
            } while (!parseResult1 && !parseResult2);

            if (x1 != y1)
            {
                int xMax = (y1*(y1 + 1))/2 - ((x1-1)*((x1-1) + 1))/2;
                int yMax = (x1*(x1 + 1))/2 - ((y1-1)*((y1-1) + 1))/2;
                int summ = (x1 < y1) ? xMax : yMax;
                Console.WriteLine("sum of all numbers between:  " + summ);
            }
            else Console.WriteLine("x equals y " + x1);

        }
    }
}
