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
            Test T = new Test();


            Console.WriteLine("Enter number..  ");
            var key = Console.ReadLine();

            //out n variable 
            var isNumeric = int.TryParse(key, out int n);

            // define this method 
            // Another(n);

            if (isNumeric)
            {
                for (int i = 0; i < n; i++)
                {
                    T[i] = i;
                }
            }

            else
                Console.WriteLine("Please Enter The Number");
        }

        //   another usage 
        static void Another(int count)
        {
            Test T = new Test(count);

            for (int i = 0; i < count; i++)
            {
                T[i] = i;
            }
        }
    }
}