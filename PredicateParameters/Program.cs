using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomClass rc = new RandomClass();
            Console.WriteLine("Enter a number from 0 - 10: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (x > 10 || x < 0)
            {
                Console.WriteLine("Only numbers 0 - 10 allowed!");
                Console.WriteLine();
            }
            else
            {
                Predicate<int> PredSQ = rc.RandomFunc;
                bool res = rc.RandomFunc(x);
                Console.WriteLine();
            }


            Console.ReadLine();
        }

        class RandomClass
        {
            Random rand = new Random();
            int[] randArr = new int[10];

            public bool RandomFunc(int a)
            {
                for (int i = 0; i < randArr.Length; i++)
                {
                    randArr[i] = rand.Next(10);
                    Console.WriteLine("Element " + i + ": {0}",randArr[i]);
                    
                }

                for (int i = 0; i < randArr.Length; i++)
                {
                    if(a == randArr[i])
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nice! " + a + " has been found!");
                        Console.WriteLine();
                        return true;
                    }   
                }
                Console.WriteLine();
                Console.WriteLine("Sorry! " + a + " is no where to be found!");
                Console.WriteLine("Better luck next time!");
                Console.WriteLine();
                return false;
            }
        }
    }
}
