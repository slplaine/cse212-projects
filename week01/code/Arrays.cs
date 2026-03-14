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

        // Plan to solve the problem:
        // 1. Create an array of doubles with the size equal to 'length'.
        // 2. Use a loop to go through each index of the array.
        // 3. For each position, calculate the multiple of the given number.
        //    Since array indexes start at 0, multiply the number by (i + 1).
        // 4. Store the calculated value in the corresponding position of the array.
        // 5. After filling the array with multiples, return the array.

        // Step 1: Create an array of doubles with the size equal to 'length'
        double[] result = new double[length];

        // Step 2: Loop through each position of the array
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple of the number
            // Since arrays start at index 0, we use (i + 1) to get the correct multiple
            double multiple = number * (i + 1);

            // Step 4: Store the calculated multiple in the array
            result[i] = multiple;
        }

        // Step 5: Return the completed array
        return result;    
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Plan to solve the problem:
        // 1. Determine where the last 'amount' elements begin in the list.
        // 2. Copy those elements into a temporary list.
        // 3. Remove those elements from the original list.
        // 4. Insert the saved elements at the beginning of the original list.
        // This effectively rotates the list to the right by the specified amount.
        
        // Step 1: Determine the starting index of the elements that will move
        // to the front of the list
        int startIndex = data.Count - amount;
        // Step 2: Create a temporary list containing the last 'amount' elements
        List<int> lastPart = data.GetRange(startIndex, amount);
        // Step 3: Remove those elements from the original list
        data.RemoveRange(startIndex, amount);
        // Step 4: Insert the saved elements at the beginning of the list
        data.InsertRange(0, lastPart);
    }
}
