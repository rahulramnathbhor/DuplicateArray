using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateArray
{
    class GFG
    {



        static void printRepeating(int[] arr, int size)

        {

            int i, j;



            Console.Write("Duplicate Numbers are :");

            for (i = 0; i < size - 1; i++)

            {

                for (j = i + 1; j < size; j++)

                {

                    if (arr[i] == arr[j])

                        Console.WriteLine(arr[i] + " ");

                }

            }

        }

        

        public static void Main()

        {

            int[] arr = {1,2,3,2,4,3,5 };

            int arr_size = arr.Length;



            printRepeating(arr, arr_size);

        }
    }
}





    

       
        
    

