public class Rectangle : Shape
{
    //Attributes
    private double _width;
    private double _length;

    //Constructor
    public Rectangle(string color, double width, double length) : base(color)
    {
       
        _width = width;
        _length = length;

    }
    //Override method
    public override double GetArea()
    {
        return _width * _length;
    }



}
