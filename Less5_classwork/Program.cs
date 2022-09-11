namespace Less5_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("rec factorial");
            var res2 = GetFactorialRecursionOf(5);
            Console.WriteLine(res2);

            static long GetFactorialRecursionOf(int n)
            {
                if (n == 1)
                    return 1;

                return n * GetFactorialRecursionOf(n - 1);
            }





        }



    }
}
