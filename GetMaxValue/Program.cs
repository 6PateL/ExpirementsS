using GetValue; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetValueFromText
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine(); 

            var txtAnalyzer = new TxtAnalyzer();

            txtAnalyzer.SetPath(path);

            int[] elements = txtAnalyzer.GetInformationArray();
            int result = txtAnalyzer.GetMax();
            int result1 = txtAnalyzer.GetMin();
            int? result2 = txtAnalyzer.GetCurrentIndex(10);
            int? result3 = txtAnalyzer.FindElement(10);

            Console.WriteLine(elements.ToString());
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}
