using System;

public class Word
{
    private string _text;
    private bool _isHidden;
    private bool playing = true;

    private string HiddingWords(List<bool> boolList, string[] textList)
    {
        int count = 0;
        List<string> tempList = new List<string>();
        foreach (var item in boolList)
        {
            if (item == true)
            {
                tempList.Add(textList[count]);
            }
            else
            {
                tempList.Add("_____");
            }
            count++;
        }
        string result = String.Join(" ", tempList);
        return result;
    }
    private List<bool> Hide(int r1, int r2, int r3, List<bool> boolList)
    {
        boolList[r1] = false;
        boolList[r2] = false;
        boolList[r3] = false;

        return boolList;
    }
    public void IsHiden(string text)
    {
        playing = true;
        Reference scriptureReference = new Reference();
        Scripture scriptureText = new Scripture();
        string[] textList = scriptureText.WordProcess(text);
        int listLength = textList.Count();
        List<bool> boolList = scriptureText.CreateBoolList(textList);
        int counter = listLength;
        int modifier = 3;
        Random rnd = new Random();
        string responce = "";
        List<string> tempList = new List<string>();

        while (playing == true)
        {
            tempList.Clear();
            //Random Number Generator with chekcs for used number
            //For randomOne
            int randomOne = rnd.Next(0, listLength - 1);
            while (boolList[randomOne] != true)
            {
                randomOne = rnd.Next(0, listLength - 1);
            }
            //For randomTwo
            int randomTwo = rnd.Next(0, listLength - 1);
            if (counter > 1)
            {
                while ((randomTwo == randomOne) & (boolList[randomTwo] != true))
                {
                    randomTwo = rnd.Next(0, listLength - 1);
                }
            }
            else
            {
                modifier = 1;
            }
            //For randomThree
            int randomThree = rnd.Next(0, listLength - 1);
            if (counter > 2)
            {
                while ((randomThree == randomTwo) & (boolList[randomThree] != true))
                {
                    randomThree = rnd.Next(0, listLength);
                }
            }
            else
            {
                modifier = 2;
            }

            if (counter >= 3)
            {
                modifier = 3;
            }
            //Gets user input
            Console.Write("To continue click ENTER key to hide words or type quit to return to menu ");
            responce = Console.ReadLine();
            //Hides words
            if (responce == "")
            {
                Console.Clear();
                boolList = Hide(randomOne, randomTwo, randomThree, boolList);
                string newText = HiddingWords(boolList, textList);
                Console.WriteLine(newText);
            }
            else if (counter == 0)
            {
                Console.WriteLine("No more words left. Recite out Loud");
                Console.ReadLine();
                break;
            }
            else if (responce == "quit")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid resonce");
                responce = "";
            }
        }
    }
    public void PrintText()
    {

    }
}
