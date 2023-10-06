using Expirements.Executers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Expirements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] c = { 1, 2, 3, 4, 5 };

            var reverse = new ExecuteReverse<int>();
            var x = reverse.ReverseArray(c);

            Console.WriteLine(x);

            //int maxSize = 100;
            //int currentSize = 0;
            //int[] b = new int[maxSize];

            //for (int i = c.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(c[i]);
            //    b[currentSize] = c[i];
            //    currentSize++; 
            //}
        }
    }
}
