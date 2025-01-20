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
        Console.WriteLine("\n---Entry added---");
        int milliseconds = 2000;
        Thread.Sleep(milliseconds);
    }
    public void DisplayAll()
    {
        string[] lines = System.IO.File.ReadAllLines(@"journalBackupFile.txt");
        foreach (string line in lines)
        {
            Console.WriteLine("\n");
            Console.WriteLine(line);
        }
        int milliseconds = 2000;
        Thread.Sleep(milliseconds);
    }

    public void LoadFromFile(string file)
    {
        string sourceFile = $"{file}.txt";
        string destinationFile = @"journalBackupFile.txt";
        File.Copy(sourceFile, destinationFile);
        Console.WriteLine("\n---File Loaded---\n");
        int milliseconds = 2000;
        Thread.Sleep(milliseconds);
    }

    public void SaveNewFile(string file)
    {
        string sourceFile = @"journalBackupFile.txt";
        string destinationFile = $"{file}.txt";
        File.Copy(sourceFile, destinationFile);
        Console.WriteLine("\n---File Saved---");
        int milliseconds = 2000;
        Thread.Sleep(milliseconds);
    }
}