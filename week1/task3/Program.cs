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
            string line1 = Console.ReadLine(); //creating string value line1
            string line2 = Console.ReadLine(); //creating string value line2

            int n = int.Parse(line1); //creating and converting line 1(which is a string) to integer

            string[] nums = line2.Split(); //creating an array with elements of the string type in line2 and separating them through spaces

            for (int i = 0; i < nums.Length; i++) //cycle creation for line2 array elements
            {
                int x = int.Parse(nums[i]); //converting element of string array and saving as element of integer array

                for (int j = 0; j < 2; j++) //run through the cycle 
                {
                    Console.Write(x + " "); //output to the console 
                }

            }
        }
    }
}