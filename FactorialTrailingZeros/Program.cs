using System;

public class Program {
    public static void Main(String[] args) {

        int x = 10;

        Console.WriteLine(TrailingZeros(x));
    }

    public static int TrailingZeros(int x) {
        int ctr = 0;

        int fact = 1;

        for (int i = 1; i <= x; i++) {
            fact *= i;
        }

        string factString = Convert.ToString(fact);

        for (int i = factString.Length - 1; i >= 0; i--) {
            if (factString[i] != '0') {
                break;
            }
            ctr++;
        }

        return ctr;
    }
}