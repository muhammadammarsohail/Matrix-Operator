using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            Matrix m = new Matrix();
            Console.WriteLine("Fill in the FIRST MATRIX");
            m.Input(m.firstMatrix);
            Console.WriteLine("Fill in the SECOND MATRIX");
            m.Input(m.secondMatrix);

            m.Print(m.firstMatrix);
            Console.ReadKey();
        }
    }
}
