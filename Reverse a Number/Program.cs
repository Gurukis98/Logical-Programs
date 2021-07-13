using System;

namespace Reverse_a_Number
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n;
            int reverse = 0;
            int rem;
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reversed Number: " + reverse);
        }
    }
}
