<Query Kind="Program" />

void Main()
{
 
    var rectangle = new Rectangle();
    
    /*
        For example we can't pass in a string
        to this method, because we've declared that it
        needs to be an int
    */
    
    rectangle.PrintOutArea("Hello"); // We get an error at this point.
}


public class Rectangle
{
    public int Length { get; set; }

    public int Width { get; set; }

    public int GetArea()
    {
        var area = Length * Width;

        return area;
    }
    
    
    public void PrintOutArea(int numberOfTimes)
    {
        for (int i = 0; i < numberOfTimes; i++)
        {
            Console.WriteLine(GetArea());
        }
    }
}