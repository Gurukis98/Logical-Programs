using System;

namespace Fibonacci_Series
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            int i;
            int num;
            Console.WriteLine("Enter the Fibonacci Series : ");
            num = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < num; ++i)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
