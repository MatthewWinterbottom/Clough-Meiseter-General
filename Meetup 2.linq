<Query Kind="Program" />

void Main()
{
    // What does Joe know already
    
    // C#
    
    /*
        Why create static class?
        
        When the utilisation of the class doesn't need
        to depend on any specific instance.
        
        Why create normal class?
        
        When the use of the class depends on a specific instance.
    */
    
    var rectangleOne = new Rectangle();
    var rectangleTwo = new Rectangle();
    
    rectangleOne.Length = 10;
    rectangleOne.Width = 5;
    
    rectangleTwo.Length = 100;
    rectangleTwo.Width = 50;
    
    var rectangleOneArea = rectangleOne.GetArea();
    var rectangleTwoArea = rectangleTwo.GetArea();
    
    Console.WriteLine(rectangleOneArea);
    Console.WriteLine(rectangleTwoArea);
}


public static class Example
{
    public static string Name { get; set; }
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
}

