using System;

public class CheckStringPalindrome {
    public static void Main(String[] args) {

        string s = "hello";

        CheckPalindrome(s);
    }

    public static void CheckPalindrome(string s) {

        int l = 0;
        int r = s.Length - 1;


        while (l <= r) {
            
            if (s[l] != s[r]) {
                Console.WriteLine("NO");
                return;
            }

            l++;
            r--;
        }

        Console.WriteLine("YES");

    }
}