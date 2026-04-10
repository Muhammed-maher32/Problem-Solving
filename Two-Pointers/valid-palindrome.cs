/*
Problem: 125. Valid Palindrome
Author: Muhammed Maher
Approach: Two pointers with skipping non-alphanumeric characters

We use two pointers starting from both ends of the string.
The main idea is to ignore non-alphanumeric characters while comparing.

To skip invalid characters, we use:
char.IsLetterOrDigit()

Documentation:
https://learn.microsoft.com/en-us/dotnet/api/system.char.isletterordigit

After skipping, we compare characters ignoring case sensitivity
using:
char.ToLower()

If a mismatch occurs, return false.
If all valid characters match, return true.
*/

public class Solution {
    public bool IsPalindrome(string s) {
        int n=s.Length;
        int l=0,r=n-1;
        while(l<r){
            while(l<r && !char.IsLetterOrDigit(s[l])){
                l++;
            }
            while(l<r && !char.IsLetterOrDigit(s[r])){
                r--;
            }

            if(char.ToLower(s[l])!= char.ToLower(s[r])){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}