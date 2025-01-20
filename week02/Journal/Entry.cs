using System;
using System.Security.Cryptography.X509Certificates;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display()
    {
        string fullEntry = $"{_date} -- {_promptText}\n{_entryText}";
        Console.WriteLine(fullEntry);
        return fullEntry;
    }
}