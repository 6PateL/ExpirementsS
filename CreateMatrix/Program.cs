using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateMatrix
{
    public class Program
    {
        static void Main(string[] args)
        {
            var createdMatrix = new Matrix(3,3);

            var result = createdMatrix.CreateRandomMatrixDouble(1, 10);
            var result1 = createdMatrix.CreateUserMatrixDouble();
            var result2 = createdMatrix.CreateRandomMatrixInt(1, 10);
            var result3 = createdMatrix.CreateUserMatrixInt();
            var reuslt4 = createdMatrix.CreateIdentityMatrix(); 

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(reuslt4);
        }
    }
}