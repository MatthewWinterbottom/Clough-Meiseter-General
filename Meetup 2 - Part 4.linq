<Query Kind="Program" />

void Main()
{
    /*
        In C# there's different types of integers
        
        sbyte -127 to 127
        short -32,768 to 32,768
        ushort 0 to 65,535
        int -2,147,483,648 to 2,147,483,647
        uint 0 to 4,294,967,295
        long -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        ulong 0 to 18,446,744,073,709,551,615
    */

    /*
        Different types of decimal numbers
        Float 10 ^ -45 to 10 ^ 38
        Double 10 ^ -324 to 10 ^ 308
        Decimal 10 ^ -28 to 10 ^ 28
    */

    var num = 10d / 3d;
    
    Console.WriteLine(num);
}

// Define other methods, classes and namespaces here
