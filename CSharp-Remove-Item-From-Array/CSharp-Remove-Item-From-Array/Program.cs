using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Remove_Item_From_Array
{
    class Program
    {
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //populate the arrays
            string[] array_A = { "Dog", "Wolf", "Flamingo", "Spider", "?", "7", "Orange", "Android" };
            string[] array_B = { "Fox", "Wolf", "Bear", "7", "Cheese", "Spider", "Cat", "Linux" };

            ArrayList ArrayA = new ArrayList(array_A);
            ArrayList ArrayB = new ArrayList(array_B);

            bool found_switch = false;

            for (int i = 0; i < ArrayA.Count; i++)
            {
                for (int j = 0; j < ArrayB.Count; j++)
                {
                    if (ArrayA[i] == ArrayB[j])
                    {
                        found_switch = true;

                        Console.WriteLine("ArrayA element \"" + ArrayA[i] + "\" was found in ArrayB");

                        ArrayA.RemoveAt(i);
                    }
                }

                if (found_switch == false)
                {
                    Console.WriteLine("ArrayA element \"" + ArrayA[i] + "\" was not found in ArrayB");
                }

                found_switch = false;
            }

            PrintValues(ArrayA);
            PrintValues(ArrayB);

            Console.Write("Press Any Key to exit...");
            Console.ReadKey();
        }
    }
}
