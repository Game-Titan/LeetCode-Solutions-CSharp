// See https://aka.ms/new-console-template for more information
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int number = target - nums[i];
            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i && number == nums[j])
                {
                    return [i, j];

                }
            }
        }
        return null;
    }
}
