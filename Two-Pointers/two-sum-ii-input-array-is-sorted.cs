// Problem: 167. Two Sum II - Input Array Is Sorted
// Author: Muhammed Maher
// Approach: Two pointers, since the array is sorted in ASC order
	     we iterate using l and r, if sum > target move r to left to reduce sum.

// Why r = n-1 is better than r = l+1?  

If we initialize r = l + 1, the approach fails to utilize the "Sorted" property effectively:

Directional Limitation: If the sum is already greater than the target, you cannot move r backwards to find a smaller number because r is already at the smallest possible position relative to l. It takes n square while the first one takes o(n).

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n= numbers.Length;
        int l=0,r=n-1;
        while(l<r){
            int sum = numbers[l] + numbers[r];
            if(sum == target)
            {
                return new int[]{l+1,r+1};
            }
            if (l< n && sum <target ){
                l++;
            }
            else {
                r--;
            }
        }
        return new int[]{l+1,r+1};
    }
}