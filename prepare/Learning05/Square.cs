public class Square : Shape
{
    //Attributes
    private double _side;

    //Constructor
    public Square(string color, double side) : base(color)
    {
       // _color = color;
        _side = side;
    }
    //Override method
    public override double GetArea()
    {
        return _side * _side;
    }



}