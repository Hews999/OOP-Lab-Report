using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_day_6_Q_1
{
    internal class ArrayOperations
    {
        public static void CreateArray(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                int num;

                Console.WriteLine("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());

                array[i] = num;

                array[i + 1] = 0;
            }

            for (int i = 0; i < size * 2; i++)
            {
                Console.WriteLine("{0}", array[i]);
                Console.ReadKey();
            }
        }
    }
}

