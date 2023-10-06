using testingWhereTclassConstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingWhereTclassConstruction
{
    public class Program
    {
        static void Main(string[] args)
        {
            var example = new Example<Person>();
            example.AddPerson(new Person {  Name = "john", Age = 21});

            var result = example.ShowFirstPerson();
            var result1 = example.ShowLastPerson();
            var result2 = example.ShowPersonForIndex(0);

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
