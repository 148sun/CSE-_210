public class Word
{
    //Attributes
    private string _word;

    private int _wordLength;

    private bool _wordStatus; //This indicates whether the word will be sent as the actual word (true), or the underscored word (false)

    private string _modifiedWord;

    //Constructors
    public Word()
    {
        _word = "smile";
        _wordLength = _word.Length;
        _wordStatus = true;
    }

    public Word(string word)
    {
        _word = word;
        _wordLength = _word.Length;
        _wordStatus = true;
    }

    //Methods
    public string SendWord()
    {

        if (_wordStatus)
        {
            _modifiedWord = RevealWord();
        }
        else
        {
            _modifiedWord = HideWord();
        }
        return $"{_modifiedWord} ";
    }

    public void ReceiveStatus(bool status)
    {
        _wordStatus = status;
    }
    public bool SendStatus()
    {
        return _wordStatus;
    }

    private string RevealWord()
    {
        return _word;
    }

    private string HideWord()
    {
       
       return new string('_',_wordLength);
    }

}