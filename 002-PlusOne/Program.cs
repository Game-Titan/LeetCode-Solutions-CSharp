public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        // Get the index of the last digit.
        int n = digits.Length - 1;

        // Iterate from the rightmost digit to the leftmost.
        for (int i = n; i >= 0; i--)
        {
            // If digit is less than 9, increment and return. No carry needed.
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            // If digit is 9, set to 0 and prepare for carry-over.
            digits[i] = 0;

            // If we're at the first digit (index 0) and it was 9,
            // a new leading '1' is needed (e.g., [9,9] -> [1,0,0]).
            if (i == 0)
            {
                // Create new array, one element larger than original.
                int[] newArray = new int[n + 2];
                newArray[0] = 1; // Set the new leading digit.
                return newArray;
            }
        }
        // This part is unreachable as all cases are handled above.
         return null;
    }
}