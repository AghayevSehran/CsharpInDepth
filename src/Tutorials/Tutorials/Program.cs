using System;
using System.Collections;
using System.Collections.Specialized;

namespace Tutorials
{

    internal class Program
    {
        //version 1

        static string[] GenerateNames()
        {
            string[] names = new string[4];
            names[0] = "Gamma";
            names[1] = "Vilisiddes";
            names[2] = "Jahnson";
            names[3] = "Helm";
            return names;
        }

        static void PrintNames(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        //version 2
        static ArrayList GenerateNamesArrayList()
        {
            ArrayList names = new ArrayList();
            names.Add("Gamma");
            return names;
        }

        //version 3
        static ArrayList GenerateNamesStringCollection()
        {
            StringCollection names = new StringCollection();
            names.Add("Gamma");
            return names;
        }

        static void Main(string[] args)
        {
            PrintNames(GenerateNames());
            Console.WriteLine("Hello World!");
        }
    }
}
