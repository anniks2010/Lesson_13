using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace workingWithFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Demo\demo.txt"; ///@ on selleks, et saaksime kauta tagurpidi kaldkriipsu.
                                               ///read file content
            List<string> lines = File.ReadAllLines(path).ToList();

            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("Lets add an item:");
            string userItem = Console.ReadLine();

            lines.Add(userItem);
            File.WriteAllLines(path, lines);
            
            List<string> lines1 = File.ReadAllLines(path).ToList();

            foreach (string line in lines1)
            {
                Console.WriteLine(line);
            }
        }
    }
}
