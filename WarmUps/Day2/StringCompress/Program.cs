using System;
using System.Text;


public class Program {
    public static void Main(String[] args) {

        string s = "aabcccccaaa";

        Console.WriteLine(StringCompress(s));
    }

    public static string StringCompress(string s) {

        StringBuilder sb = new StringBuilder();

        int ctr = 1;
        for (int i = 1; i < s.Length; i++) {

            if (s[i] != s[i-1]) {
                sb.Append(s[i-1]);
                sb.Append(ctr);
                ctr = 1;
            }
            else {
                ctr++;
            }
        }

        sb.Append(s[s.Length-1] + "" + ctr);

        return sb.ToString();
    }
}