using System;
using System.Diagnostics.Contracts;

public class Program {
    public static void Main(String[] args) {

        string s = "ZY";

        Console.WriteLine(ExcelConversion(s));
    }

    public static int ExcelConversion(string s) {

        int conNum = 0;
        
        for (int i = 0; i < s.Length; i++) {

            conNum *= 26;

            conNum += s[i] - 'A' + 1;           
        }
        

        return conNum;
    }
}