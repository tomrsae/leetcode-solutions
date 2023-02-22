using System.Collections;

public class Solution {

    public int[] TwoSum(int[] nums, int target) {
        bool bestSolution = true; // set false for naive

        if (bestSolution)
            return TwoSumBest(nums, target);
        else
            return TwoSumNaive(nums, target);
    }

    // Best - O(n)
    public int[] TwoSumBest(int[] nums, int target) {
        Hashtable table = new Hashtable();

        for (int i = 0; i < nums.Length; i++) {
            int delta = target - nums[i];
            if (table.ContainsKey(delta)) {
                if ((int)table[delta] == i) continue;
                return new int[] { (int)table[delta], i };
            }
            table.Add(nums[i], i);
        }

        return Array.Empty<int>();
    }

    // Naive - O(n^2)
    public int[] TwoSumNaive(int[] nums, int target) {
        for (int i = 0; i < nums.Length - 1; i++) {
            for (int j = i + 1; i < nums.Length; i++) {
                if (nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }

        return Array.Empty<int>();
    }
}