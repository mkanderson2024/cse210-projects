using System;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        Journal text = new Journal();
        text._entries.Add(newEntry);


    }

    public void DisplayAll()
    {
        // foreach (Entry e in )
    }

    public void SaveToFile(string file)
    {
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            Entry en = new Entry();
            outputFile.WriteLine(en.Display());
        }


    }
    public void LoadFromFile(string file)
    {

    }

    // internal void AddEntry(string entryText)
    // {
    //     throw new NotImplementedException();
    // }
}