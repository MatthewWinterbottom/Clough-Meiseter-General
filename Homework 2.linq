<Query Kind="Program" />

void Main()
{
    /*
        Hey Joe,
        
        On a similar thread to the previous one. This time
        I want the method to return a dictionary, with the key
        being the number in the array, and the value being the
        number of times that number appears in the array
    */

    // Tests

    Console.WriteLine(GetNumberOccurences(new int[] { 55, 65, 23, 13, 54 }));
    Console.WriteLine(GetNumberOccurences(new int[] { 10001, 1000, 10001, 1000, 20002 }));
    Console.WriteLine(GetNumberOccurences(new int[] { 1, 1, 1 }));
    Console.WriteLine(GetNumberOccurences(new int[] { 2 }));
}

Dictionary<int,int> GetNumberOccurences(int[] numberArray)
{



    return new Dictionary<int, int>();
}


