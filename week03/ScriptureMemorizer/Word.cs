using System;
//Contains a check to ensure that all words are removed at end of removing words for memorization and allows for returning to main menu
public class Word
{
    private int _randomOne;
    private int _randomTwo;
    private int _randomThree;
    private bool playing = true;
    private bool _check;
    private string _responce;
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
                string _characterChange = "";
                _characterChange = textList[count];
                foreach (var character in _characterChange)
                {
                    _characterChange = _characterChange.Replace(character, '_');
                }
                tempList.Add(_characterChange);
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
        Reference _scriptureReference = new Reference();
        Scripture scriptureText = new Scripture();
        string[] textList = scriptureText.WordProcess(text);
        int listLength = textList.Count();
        List<bool> boolList = scriptureText.CreateBoolList(textList);
        int counter = 0;
        Random rnd = new Random();
        List<string> tempList = new List<string>();

        while (playing == true)
        {
            counter = 0;
            foreach (bool item in boolList)
            {
                if (item == true)
                {
                    _check = true;
                    counter++;
                }
                else
                {
                    _check = false;
                }
            }
            tempList.Clear();
            //Random Number Generator with chekcs for used number
            //For _randomOne
            _randomOne = rnd.Next(0, listLength - 1);
            counter = counter - 1;
            if (counter > 0)
            {
                while (boolList[_randomOne] != true)
                {
                    _randomOne = rnd.Next(0, listLength - 1);
                }
            }
            //For _randomTwo
            if (counter >= 2)
            {
                _randomTwo = rnd.Next(0, listLength - 1);
                counter = counter - 1;
                while ((_randomTwo == _randomOne) || (boolList[_randomTwo] != true))
                {
                    _randomTwo = rnd.Next(0, listLength - 1);
                }
            }
            //For _randomThree
            if (counter > 3)
            {
                _randomThree = rnd.Next(0, listLength - 1);
                counter = counter - 1;
                while ((_randomThree == _randomTwo) || (boolList[_randomThree] != true) || (_randomThree == _randomOne))
                {
                    _randomThree = rnd.Next(0, listLength);
                }
            }
            //Gets user input
            Console.Write("\nTo continue click ENTER key to hide words or type stop to return to menu \n");
            _responce = Console.ReadLine();
            //Hides words
            if (_responce == "")
            {
                Console.Clear();
                boolList = Hide(_randomOne, _randomTwo, _randomThree, boolList);
                string newText = HiddingWords(boolList, textList);
                Console.WriteLine($"{_scriptureReference.GetReference()} {newText}");
                Console.WriteLine(counter);
                if (counter <= 0)
                {
                    for (var i = 0; i < boolList.Count(); i++)
                    {
                        boolList[i] = false;
                    }
                    newText = HiddingWords(boolList, textList);
                    Console.Clear();
                    Console.WriteLine($"{_scriptureReference.GetReference()} {newText}");
                    Console.WriteLine("No more words left. Recite out Loud");
                    Console.ReadLine();
                    playing = false;
                }
            }
            else if (_responce == "stop")
            {
                break;
            }

            else
            {
                Console.WriteLine("Invalid resonce");
            }
        }
    }
}