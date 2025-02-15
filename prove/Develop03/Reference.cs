using Microsoft.VisualBasic;

public class Reference
{
    //Attributes
    private string _book;
    private int _chapter;
    
    private int _firstVerse;

    private int _secondVerse;

    //Method
    public void RevealReference()
    {
        if (_firstVerse != _secondVerse)
        {
            Console.WriteLine($"{_book} {_chapter} : {_firstVerse}-{_secondVerse}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter} : {_firstVerse}");
        }
        
    }

    //Constructors
    public Reference()
    {
        
        _book = "3 Nephi";
        _chapter = 20;
        _firstVerse = 42;
        _secondVerse = 42;
    }

    public Reference(string book, int chapter, int verse1, int verse2)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse1;
        _secondVerse = verse2;
    }
    public Reference(string book, int chapter, int verse1)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse1;
        _secondVerse = verse1;
    }
}