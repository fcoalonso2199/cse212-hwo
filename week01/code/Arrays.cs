//Author: Francisco Javier Alonso
//Date: 2026-04-107

using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// Produces an array of size 'length' containing multiples of 'number'.
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start:
        // Step by Step for MultiplesOf:
        // 1. Create a new array of type double with the size specified by 'length'.
        // 2. Use a 'for' loop that goes from i = 0 to length - 1.
        // 3. In each iteration, calculate the multiple by multiplying 'number' by (i + 1).
        // 4. Store that value in the 'i' position of the array.
        // 5. Return the resulting array once the loop is complete. finish

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotates the 'data' list to the right by 'amount' positions.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start:
        // STEP BY STEP FOR RotateListRight:
        // 1. Validate that the list is not empty and that amount is greater than 0.
        // 2. Normalize 'amount' using the modulo: if amount is equal to data.Count,
        //    the list remains the same, so we use amount % data.Count.
        // 3. Identify the cut index: the point where the new list begins
        //    is (data.Count - amount).
        // 4. Get the final section (the part that will move to the front) using GetRange.
        // 5. Get the initial section (the part that will move to the back) using GetRange.
        // 6. Clear the original list.
        // 7. Add the final section first (AddRange) and then the initial section (AddRange).

        if (data == null || data.Count == 0 || amount <= 0) return;

        int rotation = amount % data.Count;
        if (rotation == 0) return; // No is necessary the rotation  

        int splitIndex = data.Count - rotation;

        // Obtain the two parts
        List<int> endPart = data.GetRange(splitIndex, rotation);
        List<int> startPart = data.GetRange(0, splitIndex);

        // Modify the original list
        data.Clear();
        data.AddRange(endPart);
        data.AddRange(startPart);
    }
}