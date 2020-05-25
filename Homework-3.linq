<Query Kind="Program" />

void Main()
{
    /*
        Return the characters which are not common to both strings.
        Please ignore casing E.g. if string a has an 'A' and string b has an
        'a', then 'a' would not be included on the output.
        return the answer in all lowercase
    */
    
    // Test 1 
    var result1 = GetCharactersNotCommon("Hello", "Testing");
    
    if (result1 == "hllotsting")
        Console.WriteLine("First test passed!");
    else
        Console.WriteLine("First test failed.");
    
    // Test 2
    var result2 = GetCharactersNotCommon("Joe", "Clough");
    
    if (result2 == "jeclugh")
        Console.WriteLine("Second test passed! I am so proud of you Brother.");
    else
        Console.WriteLine("Second test failed.");
}

public string GetCharactersNotCommon(string a, string b)
{
    // Write your code here Mr Clough :)
    // Just return the answer
    
    return "Fix me";
}
