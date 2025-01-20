using System;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    // public List<Entry> _entries = new List<Entry>();
    public void AddEntry(string text, string fileName)
    {
        string textString = text;
        using (StreamWriter backUpFile = File.AppendText(fileName))
        {
            backUpFile.WriteLine(textString);
        }
    }
    public void DisplayAll()
    {
        //     string[] lines = System.IO.File.ReadAllLines(filename);

        //     foreach (string line in lines)
        //     {
        //         string[] parts = line.Split(",");

        //         string firstName = parts[0];
        //         string lastName = parts[1];
        // }
    }

    public void LoadFromFile(string file)
    {
        string sourceFile = $"{file}.txt";
        string destinationFile = @"journalBackupFile.txt";
        File.Copy(sourceFile, destinationFile);
        Console.WriteLine("\nFile Loaded");
        int milliseconds = 2000;
        Thread.Sleep(milliseconds);
    }

    public void SaveNewFile(string file)
    {
        string sourceFile = @"journalBackupFile.txt";
        string destinationFile = $"{file}.txt";
        File.Copy(sourceFile, destinationFile);
        Console.WriteLine("\nFile Saved");
        int milliseconds = 2000;
        Thread.Sleep(milliseconds);
    }
}