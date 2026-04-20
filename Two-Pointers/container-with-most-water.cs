// Problem: 11. Container With Most Water
// Author: Muhammed Maher
// Approach: Greedy Two-Pointer.
// 1. Start with the maximum width (pointers at both ends).
// 2. The height of the water is limited by the shorter of the two walls, Thats why we take the minimum between 
      //the two heights.
// 3. To find a potentially larger area, always move the pointer pointing to the shorter wall.
// Time Complexity: O(n) | Space Complexity: O(1)

public class Solution {
    public int MaxArea(int[] height) {
        int n= height.Length;
        int l=0 ;
        int r=n-1;
        int max=-1;
        while(l<r){
            int area = (r-l)* Math.Min(height[l],height[r]);
            max=Math.Max(max,area);
            if(height[l]<height[r]){
                l++;
            }
            else {
                r--;
            }
        }
        return max;
    }
}