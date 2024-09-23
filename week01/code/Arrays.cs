public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        double[] multiples = new double[length]; // I created a new list with the length of the parameter given
        
        for (int i = 0; i < length; i++)  // Inside this loop we iterate over the possible multiples 
        {
            multiples[i] = number * (i + 1); // Multiplication
        }


        return multiples; // Now we return the list with the multiples of the number given and with the length given
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// 

    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Adjust amount if it's larger than the list size
        amount = amount % data.Count;

    // Step 2: 
        List<int> rotatedPart = data.GetRange(data.Count - amount, amount); // Gettng the number desired til the last element of the List
        List<int> remainingPart = data.GetRange(0, data.Count - amount);    // Getting the elements before the number desired

    // Step 3:
    data.Clear(); // Clear the original list so we can add the new list in this List
    data.AddRange(rotatedPart); // Add rotated part first
    data.AddRange(remainingPart); // Add remaining part next (Those elements before the number desired)
    }
}
