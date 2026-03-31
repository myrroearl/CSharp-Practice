using System;

public class Program {

    public static void Main(String[] args) {
        string s = "PPALLP";

        Console.WriteLine(CheckRecord(s));
    }

    public static bool CheckRecord(string s) {

        int aCtr = 0;
        int lCtr = 0;

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == 'A') {
                aCtr++;

                if (aCtr == 2) {
                    return false;
                }
                lCtr = 0;
            }
            else if (s[i] == 'L') {
                lCtr++;
                if (lCtr == 3) {
                    return false;
                }
            }
            else {
                lCtr = 0;
            }
        }

        return true;
    }

}