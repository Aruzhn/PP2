using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //variable creation

            int[] arr1 = new int[n]; //creating an array of integer type
            int[] arr2 = new int[n * 2]; //creating an array with int type (size * 2)

            string[] s = Console.ReadLine().Split(); //creating an array with elements of the string type and separating them through spaces
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(s[i]); //convert elements of string array s[i] and write as element of integer array
            }

            int j = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[j++] = arr1[i]; //output array values 2 times
                arr2[j++] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " "); //output elements of new array
            }

        }
    }
}