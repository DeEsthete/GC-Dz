using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_GC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TestClass> test = new List<TestClass>();
            TestClass classTemp = new TestClass();
            for (int i = 0; i < int.MaxValue; i++)
            {
                test.Add(classTemp);
                GC.Collect();
            }
            //Console.WriteLine("Поколение коллекции 'test - '" + GC.GetGeneration(test));
            //{
            //    int Temp = 0;
            //    Console.WriteLine("Поколение переменной 'Temp' - " + GC.GetGeneration(Temp));
            //}

            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
