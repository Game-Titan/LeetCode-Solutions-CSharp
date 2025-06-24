# Plus One Problem - LeetCode Solution (C#)

This repository contains a C# solution for the "Plus One" problem on LeetCode.

## Problem Statement

You are given a large integer represented as an integer array `digits`, where each `digits[i]` is the $i^{th}$ digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.

**Examples:**

* **Input:** `digits = [1,2,3]`
    **Output:** `[1,2,4]` (123 + 1 = 124)
* **Input:** `digits = [4,3,2,1]`
    **Output:** `[4,3,2,2]` (4321 + 1 = 4322)
* **Input:** `digits = [9]`
    **Output:** `[1,0]` (9 + 1 = 10)
* **Input:** `digits = [9,9,9]`
    **Output:** `[1,0,0,0]` (999 + 1 = 1000)

## Solution Overview

The solution simulates the process of adding one to a number by hand, starting from the least significant digit (rightmost).

1.  **Iterate from Right to Left:** The code traverses the `digits` array from the last element towards the first.
2.  **Handle Non-Nine Digits:** If a digit encountered is less than 9, it is simply incremented by one. Since no carry-over is generated, the updated array is immediately returned.
3.  **Handle Nine Digits (Carry-over):** If a digit is 9, it is reset to 0, signifying a carry-over to the next digit to its left. The loop continues to process the preceding digit.
4.  **Special Case (All Nines):** If the loop completes (meaning all original digits were 9s, like `[9,9]` or `[9,9,9]`), it indicates that a new most significant digit (a `1`) is needed. A new array is created, one element larger than the original, with `1` as its first element and the rest filled with zeros.

## Complexity Analysis

* **Time Complexity:** $O(N)$, where $N$ is the number of digits in the input array. In the worst case (e.g., `[9,9,...,9]`), we iterate through the entire array once.
* **Space Complexity:** $O(1)$ in most cases, as the modification happens in-place. $O(N)$ in the worst case (e.g., `[9,9,...,9]`) when a new array of size $N+1$ needs to be created.

## How to Run (C#)

To test this solution:

1.  Save the C# code (the `Solution` class) in a `.cs` file (e.g., `PlusOne.cs`).
2.  You can use a C# compiler (like the one in Visual Studio or the .NET CLI).
3.  Include a `Main` method (like the one provided in previous explanations) to call the `PlusOne` method with various test cases.

```csharp
// Example of how you might test it in a console application:
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Solution s = new Solution();

        Console.WriteLine(string.Join(",", s.PlusOne(new int[] { 1, 2, 3 })));
        Console.WriteLine(string.Join(",", s.PlusOne(new int[] { 4, 3, 2, 1 })));
        Console.WriteLine(string.Join(",", s.PlusOne(new int[] { 9 })));
        Console.WriteLine(string.Join(",", s.PlusOne(new int[] { 9, 9 })));
        Console.WriteLine(string.Join(",", s.PlusOne(new int[] { 8, 9, 9 })));
    }
}
