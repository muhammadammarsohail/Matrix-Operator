using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        public double[,] firstMatrix = new double[2, 2];
        public double[,] secondMatrix = new double[2, 2];
        public void Input(double[,] arr)
        {
                    
        }
        public void Print(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "\t");
                 //   arr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                Console.Write("\n");
            }
        }
    }
}
