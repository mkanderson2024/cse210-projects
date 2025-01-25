using System;

public class Scripture
{
    //Create a list of strings from the scripure text
    public string[] WordProcess(string scripture)
    {
        string text = scripture;
        string[] splitStrings = text.Split(' ');
        int listCount = splitStrings.Count();
        return splitStrings;
    }
    //Create a list of boolians to match the list of scriptures
    public List<bool> CreateBoolList(string[] splitStrings)
    {
        List<bool> boolianList = new List<bool>();

        foreach (var item in splitStrings)
        {
            boolianList.Add(true);
        }
        int count = boolianList.Count();
        return boolianList;
    }
    private string _reference;
}