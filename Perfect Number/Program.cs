using System;

namespace Perfect_Number
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n;
            int i;
            int sum;
            Console.WriteLine("Enter the  Number : ");
            n = int.Parse(Console.ReadLine());
            sum = 0;
            Console.WriteLine("The Positive Divisor is  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("{0}  ", i);
                }
            }
            Console.WriteLine("The Sum of the Divisor is : {0}", sum);
            if (sum == n)
            {
                Console.WriteLine("The Number is Perfect ");
            }
            else 
            { 
                Console.WriteLine("The Number is Not Perfect. ");
            }
        }
    }
}
