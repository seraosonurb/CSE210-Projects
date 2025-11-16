// Keeps track of a single word ans whether it is shown or hidden
using System.Text;

public class Word
{
     private string _word = "";
    private bool _isHidden = false;
    public Word(string text)
    {
        _word = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char _letter in _word)
            {
                sb.Append("_");
            }
            return sb.ToString();
        }
        return _word;
    }
}