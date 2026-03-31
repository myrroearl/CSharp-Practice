using System;

public class Program {

    public static void Main(String[] args) {

        int x = 1234;

        RevandCount(x);
    }

    public static void RevandCount(int x) {

        int ctr = 0;
        int rev = 0;

        while (x != 0) {
            int rem = x % 10;
            rev *= 10;
            rev += rem;
            x /= 10;

            ctr++;
        }

        Console.WriteLine("Digits = " + ctr + ", Reversed = " + rev);
    }
}