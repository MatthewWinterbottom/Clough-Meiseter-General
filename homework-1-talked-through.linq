<Query Kind="Program" />

void Main()
{
    var numberArray = new int[] { 23, 54, 53 };
    
    var numberArray2 = Enumerable.Range(0, 1000000).ToArray();
    
    var result = IsDuplicatePresent(numberArray2);
    
    result.Dump();
}

bool IsDuplicatePresent2(int[] numberArray)
{
    var noMatchFoundYet = new List<int>();
    
    foreach (var number in numberArray)
    {
        if(!noMatchFoundYet.Contains(number))
        {
            noMatchFoundYet.Add(number);
        }
        else
        {
            return true;
        }
    }
    
    return false;
}


bool IsDuplicatePresent(int[] numberArray)
{
    bool DuplicatePresent = false;
    
    numberArray = numberArray.OrderBy(number => number).ToArray();

    if (numberArray.Length > 0)
    {
        for (int i = 0; i < numberArray.Length -  1; i++)
        {
            if (numberArray[i] == numberArray[i+1])
                return true;
        }
    }

    return DuplicatePresent;
}



bool DuplicatePresent(int[] numberArray)
{
    bool DuplicatePresent = false;

    if (numberArray.Length > 0)
    {
        for (int i = 0; i < numberArray.Length; i++)
        {
            for (int j = i + 1; j < numberArray.Length; j++)
            {
                if (numberArray[i] == numberArray[j])
                {
                    DuplicatePresent = true;
                    break;
                }
            }
        }
    }
    
    return DuplicatePresent;
}