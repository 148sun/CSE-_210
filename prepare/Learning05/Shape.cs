public class Shape
{
    //Attributes
    protected string _color;

    //Constructor
    public Shape(string color)
    {
        _color = color;
    }

    //Methods
    public void GetColor()
    {
        Console.WriteLine(_color);
        

    }

    public void SetColor(string color)
    {

    }

    public virtual double GetArea()
    {
        return 1;

    }
}