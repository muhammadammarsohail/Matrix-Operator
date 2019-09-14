using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Multiplication
    {
        public void Solve(double[,] arr1, double[,] arr2)
        {
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    //Console.Write("m" + i + j + " = ");
                    Multiply(arr1[i, j], arr1[i, j]);
                }
            }
        }   
        public void Multiply(double a, double b)
        {

        }
        public void Add(double a, double b)
        {

        }
    }
}
