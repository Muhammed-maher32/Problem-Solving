// Problem: 15. 3Sum
// Author: Muhammed Maher
// Approach: Sorting and Two Pointers. 
// 1. Sort the input array to handle duplicates and enable the two-pointer technique.
// 2. Iterate through the array, fixing one element 'i'.
// 3. Use two pointers ('l' and 'r') to find two other numbers that sum to -nums[i].
// 5. Note: This is essentially 2Sum wrapped in a loop; no better solution exists below O(n^2).
// Time: O(n^2) | Space: O(1) 

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        int n = nums.Length;
        Array.Sort(nums);
        List<IList<int>> result = new();
        
        for(int i = 0; i < n - 2; i++) { // Stops at n-2 because we need at least 2 more numbers (l and r) after 'i'
            int l = i + 1, r = n - 1;
            
            // Skip the current 'i' ,avoid duplicate triplets
            if(i > 0 && nums[i] == nums[i - 1]) continue; 
            
            while(l < r) {
                int sum = nums[l] + nums[r] + nums[i];
                if(sum == 0) {
                    result.Add(new List<int> {nums[i], nums[l], nums[r]});
                    l++; r--;
                    
                    // After finding a match, skip identical left values to avoid the same triplet again
                    while(l < r && nums[l] == nums[l - 1]) l++; 
                    
                    // After finding a match, skip identical right values to avoid the same triplet again
                    while(l < r && nums[r] == nums[r + 1]) r--; 
                }
                else if(sum < 0) {
                    l++;
                }
                else {
                    r--;
                }
            }
        }
        return result;
    }
}