﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assess4ques1
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\infinite\C#\Assessments\assessment4";
            string fileName = "file1.txt";
            string filePath = Path.Combine(directoryPath, fileName);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Please enter the text to append to the file:");
            string userText = Console.ReadLine();

            string textToAppend = userText;

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filePath, append: true);
                writer.WriteLine(textToAppend);
                Console.WriteLine($"Text appended successfully to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            Console.ReadLine();
        }
    }
}