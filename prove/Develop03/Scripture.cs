public class Scripture
{
    //Attributes
    private List<Word> _scripture = new List<Word>();
    private Reference _reference;

    private int _sizeOfScripture;

    private bool _scriptureStatus;

    private List<string> _defaultScripture = new List<string> 
    {
    "For", "ye", "shall", "not", "go", "out", "with", "haste", 
    "nor","go", "by", "flight;", "for", "Lord", "will", "go", 
    "before", "you,", "and", "the", "God", "of", "Israel", "shall",
    "be","your","rearward." 
     };

    private Random rnd = new Random();

    //Methods
    private void RevealScripture()
    {
        string scripture = "";
        foreach (Word word in _scripture)
        {
            scripture += word.SendWord();
        }
        Console.WriteLine(scripture);
    
    }

    public void RandomDisappear()
    {
        List<int> list = [];
        for (int i =0; i < 3; i=i+1)
        {
            int _index = rnd.Next(_sizeOfScripture);
            _scripture[_index].ReceiveStatus(false);

        }

    }

    //Constructor
    public Scripture(Reference reference, string scripture)
    {
        
        string[] parts = scripture.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _scripture.Add(word);
        }

        _reference = reference;
        _sizeOfScripture = _scripture.Count;
        _scriptureStatus = true;

        
    }
    public Scripture()
    {
       foreach (string word1 in _defaultScripture)
       {
        Word word2= new Word(word1);
        _scripture.Add(word2);
       }
       _reference = new Reference();
       _sizeOfScripture = _scripture.Count;
       _scriptureStatus = true;
    }
    public void SendScripture()
    {
        _reference.RevealReference();
        foreach (Word word in _scripture)
        {
            Console.Write(word.SendWord());
        }
    }
    public bool ScriptureStatus()
    {
        int _status = 0;
        foreach (Word word in _scripture)
        {
            if (word.SendStatus() == true)
            {
                _status += 1;
                
            }
            
        }
        if (_status > 0)
        {
            _scriptureStatus = true;
        }
        if (_status == 0)
        {
            _scriptureStatus = false;
        }
        
        return _scriptureStatus;
    }
}