// Keeps track of both the reference and text of the scripture
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach(string word in words)
        {
            _words.Add(new Word(word));

        }
    }
    public void HideRandomWord(int numberToHide)
    {
        int displayCount = DisplayCount();
        if (displayCount < numberToHide)
        {
            numberToHide = displayCount;
        }
        for (int i = 0; i < numberToHide;)
        {
            Random randomWord = new Random();
            int randomNumber = randomWord.Next(0, _words.Count());
            
            if (_words[randomNumber].IsHidden())
            {
                continue;
            }
            _words[randomNumber].Hide();
            i++;
        }
    }
    public string GetDisplayText()
    {
        StringBuilder sb = new StringBuilder();
        foreach(Word word in _words)
        {
            sb.Append(word.GetDisplayText()+ " ");
        }
        return sb.ToString();
    }
    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
        public int DisplayCount()
    {
        int count = 0;
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                count += 1;
            }
        }
        return count;
    }

}