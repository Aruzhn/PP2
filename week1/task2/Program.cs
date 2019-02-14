using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        string name;
        string id;
        int year = 1;

        public Student(string n, string i)//parameters
        {
            name = n;
            id = i;
        } //constructor

        public void PrintInfo()
        {
            year++; //+1 year to 1
            Console.WriteLine(name + " " + id + " " + year); //output name, id and year with year++ command
        } //method
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Aruzhan", "18BD110952");
            s.PrintInfo(); //print info of s
        }
    }
}
