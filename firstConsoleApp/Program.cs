
using System;
using System.Collections.Generic;
using System.Linq;

namespace firstConsoleApp
{

    
    internal class Program
    {


        static void Main(string[] args)

        {

            int[] arr = new int[5];


            int max, min, n;
            Console.Write("Enter the array elements : ");
            Console.WriteLine("-----------------------------------------\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("element - {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("\nElements in array are: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}  ", arr[i]);

            }

            Console.WriteLine( "Hello,max min");

            max = arr[0];
            min = arr[0];
            int w = arr.Length;
            Console.WriteLine("hello : " + w);
            for (int i = 0; i < w; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine("Max element :" + max);
            Console.WriteLine("Min element :" + min);





            Console.ReadKey();



        }

    }
}
