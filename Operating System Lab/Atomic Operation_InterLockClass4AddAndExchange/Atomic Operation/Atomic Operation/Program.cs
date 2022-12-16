using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Atomic_Operation
{
    class Program
    {
        static long _sum;
        static void Main(string[] args)
        {
        // _sum
        // Simple increment/decrement operations:
        Interlocked.Increment (ref _sum);                              // 1
        Interlocked.Decrement (ref _sum);                              // 0

       // Add/subtract a value:
       Interlocked.Add (ref _sum, 3);                                 // 3

       // Read a 64-bit field:
      Console.WriteLine (Interlocked.Read (ref _sum));               // 3

      // Write a 64-bit field while reading previous value:
      // (This prints "3" while updating _sum to 10)
      Console.WriteLine (Interlocked.Exchange (ref _sum, 10));       // 10
 
     // Update a field only if it matches a certain value (10):
     Console.WriteLine (Interlocked.CompareExchange (ref _sum,
                                                    123, 10));            // 123
     Console.ReadLine();

        }
    }
}
