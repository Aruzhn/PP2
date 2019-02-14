using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Лаура\source\repos");//open the folder
            PrintInfo(dir, 0); //show content in folder
        }

        static void PrintInfo(FileSystemInfo fsi, int k)//create the method which consider folder/file
        {
            string s = new string(' ', k);//create string,where space repeat preset times 
            Console.WriteLine(s + fsi.Name);//output to the consol given string and folder / file

            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos();//create method ,where add folder
                for (int i = 0; i < arr.Length; ++i)
                {
                    PrintInfo(arr[i], k + 3);//output folders with space number + 6 
                }
            }
        }
    }
}