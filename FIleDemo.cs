using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test_File_Reader_1
{
    public class FIleDemo
    {
        public static void ReadDemo()
        {
            string path = "C:/Users/meama/Documents/A3/Semester Abroad/Object Oriented Programming/Test_File_Reader_1_Files";
            string file = "jamaica.txt";
            string fileToRead = $"{path}/{file}";

            Console.WriteLine($"Reading{fileToRead}");
            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {
                    Console.WriteLine($"Starting to Reading {fileToRead}");
                    string line;
                    while ((line = sr.ReadLine()) != null)
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
        public static void ReadAndParseString(string fileToRead)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileToRead))
                {
                    Console.WriteLine($"Starting to Reading {fileToRead}");
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] splitData = line.Split(':');
                        Console.WriteLine($"\t{String.Format("{0,-20}", splitData[0])}\t{splitData[1]}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read.");
                Console.WriteLine(e.Message);
            }
        }
        public static void WriteDemo(string fileToWrite, string[] heroes)
        {                       
            using (StreamWriter sw = new StreamWriter(fileToWrite))
            {
                foreach (string s in heroes)
                {
                    sw.WriteLine(s);
                }
            }
            Console.WriteLine("Done");
        }
        public static char[] SplitAString(string word)
        {
            char[] characters = new char[word.Length];
            for(int i=0; i<word.Length; i++)
            {
                characters[i] = word[i];
            }
            return characters ;
        }
    }   
}
