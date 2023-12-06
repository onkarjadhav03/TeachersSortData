using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersSortAndUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            string dir = "D:\\SimpleLearnassignmentfinal2\\";
 string filename = dir + "Teachers.txt";
            string[] list = File.ReadAllLines(filename);
            Console.WriteLine("*****************************************");
            Console.WriteLine("Teachers Records");
            Console.WriteLine("1. Retrive Teachers Data \n2. Add Teachers Data\n3.Search Teachers Data");
           
            Console.WriteLine("Choose Option:");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("*****************************************");
            switch (ch)
            {
                case 1:
                    {
                        Print(list);
                        break;
                    }
                case 2:
                    {
                        AddTeacher(filename);
                        break;
                    }
                case 3:
                    {
                        Search(list);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Choice");
                        goto end;
                    }
            }
            goto start;
        end:
            Console.ReadKey();
        }
        public static void Print(string[] list)
        {
            if (list == null)
            {
                Console.WriteLine("No data Found");
            }
            else
            {
                Console.WriteLine("Teachers Data");
                Console.WriteLine("ID\tName\tClass\tSection");
                foreach (string s in list)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void AddTeacher(string filename)
        {
            Console.WriteLine("Enter teacher ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter teacher Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Class: ");
            int clas = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Section: ");
            string sec = Console.ReadLine();
            string data = id + "\t" + name + "\t" + clas + "\t" + sec;
            File.AppendAllText(filename, Environment.NewLine + data);
            Console.WriteLine("Teacher Data Updated");
        }
        public static void Search(string[] list)
        {
            Console.WriteLine("Enter teacher id to search: ");
            string id = Console.ReadLine();
            string l = Array.Find(list, s => s.StartsWith(id));
            if (l != null)
            {
                Console.WriteLine("Teacher Found!!");
                Console.WriteLine(l);
            }
            else
            {
                Console.WriteLine("Teacher not Found!!");
            }
        }
    }
}
        
   
