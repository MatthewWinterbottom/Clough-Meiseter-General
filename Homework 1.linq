<Query Kind="Program" />

void Main()
{
    
    
    /*
    
        Task: - Given an array of numbers. return the boolean value true
                if the array contains two or more of the same number
                and false if the array contains no duplicate numbers.
                
                Return false if the array is empty
    */
    

    // Tests... When in the console, there is only True written out, your alogorithm probs works! :)

    Console.WriteLine(DuplicatePresent(new[] { 1, 2, 3, 4, 5, 6 }) == false);
    Console.WriteLine(DuplicatePresent(new[] { 15, 20, 30, 50, 20 }) == true);
    Console.WriteLine(DuplicatePresent(new[] { 73, 52, 100000001, 03, 100000001 }) == true);
    Console.WriteLine(DuplicatePresent(new int[] {}) == false);
}

bool DuplicatePresent(int[] numberArray)
{
    // Write code here
    
    
    
    return false;
}