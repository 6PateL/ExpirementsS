using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateMatrix
{
    public class Matrix
    {
        private int _MATRIX_ROWS; 
        private int _MATRIX_COLUMNS;

        public Matrix(int MATRIX_ROWS, int MATRIX_COLUMNS)
        {
             _MATRIX_ROWS = MATRIX_ROWS;
             _MATRIX_COLUMNS = MATRIX_COLUMNS;  
        }
        public Matrix()
        {
            
        }

        public void SetMatrixSize(int MATRIX_ROWS, int MATRIX_COLUMNS)
        {
            _MATRIX_ROWS = MATRIX_ROWS; 
            _MATRIX_COLUMNS = MATRIX_COLUMNS;   
        }

        public double[,] CreateRandomMatrixDouble(int minValue, int maxValue)
        {
            var rnd = new Random(); 
            double[,] matrix = new double[_MATRIX_ROWS, _MATRIX_COLUMNS];
            
            for(int i = 0; i < _MATRIX_ROWS; i++) 
            {
                for(int j = 0; j < _MATRIX_COLUMNS; j++)
                {
                    matrix[i, j] = rnd.Next(minValue, maxValue);
                }
            }

            return matrix; 
        }

        public double[,] CreateUserMatrixDouble()
        {
            double[,] matrix = new double[_MATRIX_ROWS, _MATRIX_COLUMNS];

            for(int i = 0; i < _MATRIX_ROWS; i++)
            {
                for(int j = 0; j < _MATRIX_COLUMNS; j++)
                {
                    Console.WriteLine("введите {0}, {1}", i, j);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            return matrix; 
        }

        public int[,] CreateRandomMatrixInt(int minValue, int maxValue) 
        {
            var rnd = new Random(); 
            int[,] matrix = new int[_MATRIX_ROWS, _MATRIX_COLUMNS];

            for(int i = 0; i < _MATRIX_ROWS; i++)
            {
                for(int j = 0; j < _MATRIX_COLUMNS; j++)
                {
                    matrix[i, j] = rnd.Next(minValue, maxValue);
                }
            }

            return matrix;
        }

        public int[,] CreateUserMatrixInt()
        {
            int[,] matrix = new int[_MATRIX_ROWS, _MATRIX_COLUMNS];

            for (int i = 0; i < _MATRIX_ROWS; i++) 
            {
                for(int j = 0; j < _MATRIX_COLUMNS; j++)
                {
                    Console.WriteLine("введите {0}, {1}", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }

        public int[,] CreateIdentityMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    matrix[i, j] = 0; 
                }
            }

            for(int i = 0; i < matrix.Length; i++)
            {
                matrix[i, i] = 1; 
            }

            return matrix; 
        }
    }
}
