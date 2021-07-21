using System;

namespace Prime_Number
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n;
            int i;
            int m = 0;
            int o = 0;
            Console.WriteLine("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Number is not Prime ");
                    o = 1;
                    break;
                }
            }
            if (o == 0)
            {
                Console.WriteLine("Number is Prime.");
            }
        }
    }
}
