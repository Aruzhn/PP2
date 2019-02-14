using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllText(@"C:\Users\Лаура\Desktop\ICT\FInal\W2T2.txt").Split();
            using (StreamWriter file = new StreamWriter(@"C:\Users\Лаура\Desktop\ICT\FInal\W2T2(2).txt"))
            {
                for (int i = 0; i < text.Length; i++)
                {
                    int a = int.Parse(text[i]);
                    bool prime = true;
                    for (int j = 2; j < a; j++)
                    {
                        if (a % j == 0)
                            prime = false;
                    }
                    if (prime == true && a > 1)
                        file.Write(a + " ");
                }
            }

        }
    }
}