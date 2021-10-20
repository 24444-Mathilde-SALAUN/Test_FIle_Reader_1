using NPOI.SS.Formula.Functions;
using System;
using System.IO;

namespace Test_File_Reader_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FIleDemo.ReadDemo();
            string path = "C:/Users/meama/Documents/A3/Semester Abroad/Object Oriented Programming/Test_File_Reader_1_Files";
           
            string fileDC = "heroesDC.txt";
            string fileToWriteDC = $"{path}/{fileDC}";  
            string[] heroesDC = { "Batman:Bruce Wayne", "Superman:Clark Kent","Green Arrow:Oliver Queen" };
            FIleDemo.WriteDemo(fileToWriteDC, heroesDC);
            FIleDemo.ReadAndParseString(fileToWriteDC);        

            string fileMarvel = "heroesMarvel.txt";
            string fileToWriteMarvel = $"{path}/{fileMarvel}";
            string[] heroesMarvel = { "Iron Man:Tony Stark", "Thor:Thor Odinson", "The Hulk:Bruce Banner" };
            FIleDemo.WriteDemo(fileToWriteMarvel, heroesMarvel);
            FIleDemo.ReadAndParseString(fileToWriteMarvel);

            char[] characters = FIleDemo.SplitAString("supercalifragilisticexpialidocious");
        }
    }
}
