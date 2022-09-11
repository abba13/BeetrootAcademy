using System.Runtime.InteropServices;

namespace Less5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int a = 10;
            //short b = 10;
            //SquareAndX(a, b);


            //static void SquareAndX(int horizValue, int vertValue) 
            //{ 
            //for (int i = 0; i < horizValue; i++)
            //{
            //    for (int j = 0; j < vertValue; j++)
            //    {
            //        if (i == 0 || i == horizValue - 1) Console.Write("*");
            //        else if (j == 0 || j == vertValue - 1) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < horizValue; i++)
            //{
            //    for (int j = 0; j < vertValue; j++)
            //    {
            //        if (i == j || j == horizValue - i - 1) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //}

            //int n = 10;

            //int sum1 = 1;
            //int sum2 = 1;
            //int resultNumberFibo = 0;

            //for (int i = 1; i < n; ++i)
            //{
            //    if (i <= 1) Console.Write($"{sum1} {sum2} ");

            //    resultNumberFibo = sum1 + sum2;
            //    Console.Write(resultNumberFibo + " ");
            //    sum1 = sum2;
            //    sum2 = resultNumberFibo;            
            //}

            //Console.WriteLine();

            for (int i = 0; i <= 20; i++)
            {
                static int Fibona(int n)
                {
                    if (n <= 1) return 1;
                    else return Fibona(n - 2) + Fibona(n - 1);
                }
                Console.Write(Fibona(i) + " ");
            }

            //Console.WriteLine();

        }

    }
}