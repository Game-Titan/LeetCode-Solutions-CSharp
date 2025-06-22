# 001. Two Sum (Easy)

**Problem Description:**
Given an array of integers `nums` and an integer `target`, return indices of the two numbers such that they add up to `target`.
You may assume that each input would have exactly one solution, and you may not use the same element twice.

**My Solution Approach (Initial Attempt - Brute Force):**
My current solution uses a brute-force approach with nested loops. It iterates through each number in the input array (`nums`) using an outer loop. For each `nums[i]`, it calculates the `number` (complement) needed to reach the `target`. Then, an inner loop iterates through the array again to find if this `number` exists, ensuring that the index `j` is not the same as `i` (as an element cannot be used twice).

**Time Complexity:** O(N^2)
* The code involves a nested `for` loop structure. The outer loop runs `N` times (where `N` is the length of `nums`). For each iteration of the outer loop, the inner loop also runs `N` times. This results in approximately `N * N` (N-squared) operations in the worst-case scenario.

**Space Complexity:** O(1)
* This solution uses a constant amount of extra space. It only utilizes a few variables (`i`, `j`, `number`) whose memory consumption does not increase with the size of the input array `nums`.

**LeetCode Submission Details:**
* **Runtime:** 58 ms
* **Memory:** 47.61 MB

**Note:**
This solution successfully passes LeetCode's test cases. I'm aware that a more optimized solution exists for this problem, notably one using hash maps (dictionaries) which can achieve an O(N) time complexity. As I continue to learn more about data structures, I plan to revisit this problem to implement and compare more efficient approaches.
