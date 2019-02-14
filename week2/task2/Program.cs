using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllText(@"C:\Users\Лаура\Desktop\ICT\FInal\W2T2.txt").Split(); //read file and create string array with spaces 
            using (StreamWriter file = new StreamWriter(@"C:\Users\Лаура\Desktop\ICT\FInal\W2T2(2).txt")) //access to write to the file 
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int a = int.Parse(text[i]);//creating and converting user input value (which is a string) to integer
                    bool prime = true;
                    for (int j = 2; j < a; j++)
                    {
                        if (a % j == 0)
                            prime = false; //prime number checking method
                    }
                    if (prime == true && a > 1)
                        file.Write(a + " ");// if prime write each value
                }
            }

        }
    }
}