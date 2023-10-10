using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomChoice
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new RandomChoice();
            var rnd = new Random(); 
            random.SetExceptedNumbers( new int[] { 3, 5, 7, 8 } );
            int result = random.GetRandomWithExceptedNumbers(1, 15);

            for(int i = 0; i < 20; i++)
            {
                Console.Write(random.GetRandomWithExceptedNumbers(0,10) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            { 
                Console.Write(rnd.Next(0, 10) + " ");
            }
            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
