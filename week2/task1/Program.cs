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
            FileStream fs = new FileStream(@"C:\Users\Лаура\Desktop\ICT\FInal\W2T1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string s1 = sr.ReadLine();

            sr.Close();
            fs.Close();

            char[] s2 = s1.ToCharArray();
            Array.Reverse(s2);

            string s3 = new string(s2);
            if (s1 == s3)
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("No");

            Console.ReadKey();
        }
    }
}