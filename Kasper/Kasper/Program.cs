using System;
using System.IO;

namespace Kasper
{
    public class FileProcessor
    {
        public static void ProcessFile(string FileName)
        {
            string Extension = Path.GetExtension(FileName);
            switch (Extension)
            {
                case ".json": JsonHandler(); break;
                case ".html": HtmlHandler(); break;
                case ".txt": TxtHandler(); break;
                default: DefaultHandler(); break;
            }
        }
        public static void JsonHandler()
        {
            Console.WriteLine("JSON File");
            // for processing
        }
        public static void HtmlHandler() 
        {
            Console.WriteLine("HTML File");
            // for processing
        }
        public static void TxtHandler()
        {
            Console.WriteLine("Text File");
            // for processing
        }
        public static void DefaultHandler() 
        {
            Console.WriteLine("Unknown type of File");
            // for processing
        }
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            FileProcessor.ProcessFile("..\\Kasper\\Kasper\\test1.txt");
            FileProcessor.ProcessFile("..\\Kasper\\Kasper\\test2.html");
            FileProcessor.ProcessFile("..\\Kasper\\Kasper\\test3.json");
            FileProcessor.ProcessFile("..\\Kasper\\Kasper\\test4.jpg");
        }
    }
}
