using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"C:\pp2\folder\file1.txt", FileMode.Create, FileAccess.Write); //create new file
            StreamWriter sw = new StreamWriter(file); //access to write

            sw.Write("copy this line"); //in sw write text

            sw.Close();
            file.Close();
            string fileName = "file1.txt";
            string sourcePath = @"C:\pp2\folder";
            string path1 = @"C:\pp2\folder2";
            string sourceFile = Path.Combine(sourcePath, fileName); //combines 2 strings into a path
            string destFile = Path.Combine(path1, fileName); //combines 2 strings into a path
            File.Copy(sourceFile, destFile, true); //copies an existing file to a new file. Overwriting a file of the same name is allowed
            File.Delete(@"C:\pp2\folder\file1.txt"); //delete the original one
        }
    }
}
