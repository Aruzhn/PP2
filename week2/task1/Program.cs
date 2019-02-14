using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Лаура\Desktop\ICT\FInal\W2T1.txt", FileMode.Open, FileAccess.Read); //open and reading access to file in shown path 
            StreamReader sr = new StreamReader(fs); //reads information from file

            string s1 = sr.ReadLine();

            sr.Close();
            fs.Close();

            char[] s2 = s1.ToCharArray(); //initialize s1 string to char array in s2
            Array.Reverse(s2);//reverse array

            string s3 = new string(s2); 
            if (s1 == s3) //if reverse array equals initial array
            {
                Console.WriteLine("Yes"); //output yes
            }
            else
                Console.WriteLine("No");//else output no
            Console.ReadKey();
        }
    }
}