using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();

        string[] wordsSplitted = text.Split(' ');

        foreach(string word in wordsSplitted)
        {
            Word wordInstance = new Word(word);
            _words.Add(wordInstance);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<int> alreadyHidden = [];


        while(alreadyHidden.Count < numberToHide)
        {
            int randomInt = random.Next(0, _words.Count);
            if(!alreadyHidden.Contains(randomInt))
            {
                alreadyHidden.Add(randomInt);
                _words[randomInt].Hide();
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        for(int i = 0; i < _words.Count; i++)
        {
            if(_words[i].isHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayString()
    {
        string strings = "";

        for(int i = 0; i < _words.Count; i++)
        {
            if(i != 0 && i != _words.Count)
            {
                strings += " ";
            }
            strings += _words[i].GetDisplayString();
        }
        return $"{_reference.GetDisplayString()} {strings}";
    }
}