using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //creating and converting user input value to integer
            string[,] arr = new string[n, n]; //creating a 2d arrray with equal values
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    arr[i, j] = "[*]"; //takes *
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++) //condition for triangle
                    Console.Write(arr[i, j]); //output * for all values of array
                Console.WriteLine();
            }
        }
    }
}