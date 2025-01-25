using System;

public class Word
{
    private string _text;
    private bool _isHidden;
    private bool playing = true;
    public List<bool> Hide(int r1, int r2, int r3, List<bool> boolList)
    {
        boolList[r1] = false;
        boolList[r2] = false;
        boolList[r3] = false;

        return boolList;
    }
    public void IsHiden()
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
            int randomOne = rnd.Next(0, listLength);
            while (boolList[randomOne] != true)
            {
                randomOne = rnd.Next(0, listLength);
            }
            //For randomTwo
            int randomTwo = rnd.Next(0, listLength);
            if (counter > 1)
            {
                while ((randomTwo == randomOne) & (boolList[randomTwo] != true))
                {
                    randomTwo = rnd.Next(0, listLength);
                }
            }
            else
            {
                modifier = 1;
            }
            //For randomThree
            int randomThree = rnd.Next(0, listLength);
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
            //Gets user input
            Console.Write("To continue click ENTER key to hide words or type quit to return to menu ");
            responce = Console.ReadLine();
            //Hides words
            if (responce == "")
            {
                boolList = Hide(randomOne, randomTwo, randomThree, boolList);
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
