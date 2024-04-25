using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the full path of the file:");
        string filePath = Console.ReadLine();

        Console.WriteLine("Enter the word to be replaced:");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter the new word:");
        string newWord = Console.ReadLine();

        Console.WriteLine("Enter the full path for the new file:");
        string newFilePath = Console.ReadLine();

        try
        {
            // Read the content from the file
            string content = File.ReadAllText(filePath);

            // Replace the word using Regex for case-sensitive matching
            string newContent = Regex.Replace(content, $@"\b{oldWord}\b", newWord);

            // Write the new content to the new file
            File.WriteAllText(newFilePath, newContent);

            Console.WriteLine("File has been successfully processed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred:");
            Console.WriteLine(ex.Message);
        }
    }
}
