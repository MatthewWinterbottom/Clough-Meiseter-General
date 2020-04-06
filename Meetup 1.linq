<Query Kind="Program" />

void Main()
{
    /*
        1) there's built-in types like string, integers, booleans.
        
        2) The var keyword means we don't have to explcitly state
            the type all the time on the left hand-side of the expression
            
        3) We can make our own types! They're almost always made using classes! (other types: Structs and Enums, for example, int is a struct)
        
        4) We can add fields, properties, methods to a class.
        
        5) Fields: are a unit of data relating to the class.
            Properties: Have a backing field and a getter and setter which allows us to put in some logic.
            Methods: Known as functions in other languages.
            
        6) Static Keyword means we can't create an instance of the class
            we access the class' members use the member access operator (fullstop).
            We can also have a normal class with static members. These static members
            can not be accessed via the object, put must be accessed through the class name.
            
        7) We create an instance by (from left to right) stating the type, the variable name,
            the new keyword, parentheses and semicolon.
        
        8) C# is obsessed with types. This is good! If our application compiles
            we can be confident that it will work at runtime (when it's actually running).
            because it is type-safe.
    */
    
    var rectangle = new Rectangle();

    
    rectangle.Height = 5; // Setting
    
    rectangle.Width = 20;
    
    var areaOfRectangle = rectangle.GetArea();
    
    Console.WriteLine(areaOfRectangle);
    
    
    var userService = new UserService();
    
    bool isEmailValid = userService.ValidateEmail("clough-meister-general@outlook.com");
    
    Console.WriteLine(isEmailValid);
}

public class Rectangle
{
    public int Height { get; set; }
    
    public int Width { get; set; }
    
    public int GetArea()
    {
        return Height * Width;
    }
    
    public static int Perimeter { get; set; }
}

public class UserService
{
    public bool ValidateEmail(string email)
    {
        bool doesEmailContainAtCharacter = email.Contains('@');
        bool doesEmailContainFullstop = email.Contains('.');
        
        if (doesEmailContainAtCharacter && doesEmailContainFullstop)
        {
            return true;
        }

        return false;
    }
    
    // just to show you a shorthand way of doing the ValidateEmail Method
    // the arrow means we can only have one expression.
    // and it returns the value of that expression
    public bool ValidateEmailVersionTwo(string email) =>
        email.Contains('@') && email.Contains('.');
        
        
    // This is less readable, so might not be best
    // Good to know, though.
}