using NPOI.SS.Formula.Functions;
using System;
using System.IO;

namespace Test_File_Reader_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            string file = "jamaica.txt";
            string fileToRead = $"{path}/{file}";

            Console.WriteLine($"Reading{fileToRead}");
            try
            {
                using (StreamReader sr=new StreamReader(fileToRead))
                {
                    Console.WriteLine($"Starting to Reading {fileToRead}");
                    string line;
                    while ((line=sr.ReadLine()) !=null)
                    {
                        Console.WriteLine($"\t{line}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
