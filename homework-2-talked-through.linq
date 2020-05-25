<Query Kind="Program" />

void Main()
{
    var listOfItems = new[] { 4, 2, 3, 1, 6, 8, 2, 3, 1 , 3, 3, 3 };
    
    // Dictionary is a set of Key-Value Pairs
    
    // Obnoxious (Key) = Matthew Winterbottom (Value), Terrific (Key) = Joe Clough (Value)
    
    var result = GetNumberOccurences(listOfItems);
    
    Console.WriteLine(result);
}

Dictionary<int, int> GetNumberOccurences(int[] listOfItems)
{
    var Dictint = new Dictionary<int, int>(); 
    
    foreach (var number in listOfItems)
    {
        // if the number isn't a key in the dictionary, add it as a key and set the value 1
        if (!Dictint.ContainsKey(number)) Dictint.Add(number, 1);
        
        //If the number is a jey in the dictionary, add 1 to the value. Then return the dictionary at end
        else Dictint[number]++;
    }

    return Dictint;
}