using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static bool IsPrime(int x) //creating a method for checking prime numbers
        {
            bool res = true; //creating a parameter - boolean type variable (true means prime)
            if (x == 1) //if the item equals 1, res is false (not prime)
            {
                res = false;
            }
            if (x == 2) //if the item equals 2, res is true (prime)
            {
                res = true;
            }
            else
            {
                for (int i = 2; i < x; i++) //cycle creation

                {
                    if (x % i == 0) //prime number check
                    {
                        res = false; //if the number is divisible by numbers previous to it, starting from 2, then this number is not prime


                        break;
                    }
                }
            }
            return res; //return control to the calling method
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //creating and converting user input value (which is a string) to integer
            string s = Console.ReadLine(); //writing the numbers to string
            string[] arr = s.Split(); //creating an array with elements of the string type and separating them through spaces 
            int cnt = 0; //create counter variable
            for (int i = 0; i < n; i++)  
            {
                int x = int.Parse(arr[i]); //converting element of string array and saving as element of integer array
                if (IsPrime(x) == true)  //checking the method
                {
                    cnt++; //adding each prime number to counter
                }
            }
            Console.WriteLine(cnt); //print the number of prime numbers
            for (int i = 0; i < n; i++) //repeat the operation to show all primes
            {
                int x = int.Parse(arr[i]);
                if (IsPrime(x) == true)
                {
                    Console.Write(x + " "); //output to the console prime numbers separated by a space in one line
                }
            }
        }
    }
}