using CsharpIndexer.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number..  ");

            var key = Console.ReadLine();

            // out n variable 
            var isNumeric = int.TryParse(key, out int n);

            // new instance to Test class
            Test T = new Test(n);

            // define this method 
            // Another();

            if (isNumeric)
            {
                for (int i = 0; i < n; i++)
                {
                    T[i] = i;
                    Console.WriteLine(" " + T[i].ToString());
                }
            }

            else
                Console.WriteLine("Please Enter The Number");
            Console.ReadKey();
        }

        //   another usage 
        static void Another()
        {
            Test T = new Test();

            T[0] = 5;
            Console.WriteLine(T[0]);
        }
    }
}