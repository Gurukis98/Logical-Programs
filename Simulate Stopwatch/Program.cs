using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Simulate_Stopwatch
{
   public class Program
    {
       public static void Main(string[] args)
        {
			var watch = Stopwatch.StartNew();

			using (var task = Task.Delay(1000))
			{
				task.Wait();
			}

			watch.Stop();

			Console.WriteLine("Time elapsed : " + watch.Elapsed);
        }
    }
}
