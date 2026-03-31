using System;
using System.ComponentModel.DataAnnotations;

public class Project {
    public static void Main(String[] args) {

        string s = "1101010";

        Console.WriteLine(LongestBalancedSubstring(s));
    }

    public static int LongestBalancedSubstring(string s) {

        int max = 0;
        

        for (int i = 0; i < s.Length; i++) {
            
            int x = 0;
            int y = 0;
            for (int j = i; j < s.Length; j++) {
                
                if (s[j] == '1') {
                    x++;
                }
                else {
                    y++;
                }

                if (x == y) {
                    max = Math.Max(max, x * 2);
                }
            }
        }

        return max;
    }
}