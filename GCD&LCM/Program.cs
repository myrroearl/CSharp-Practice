using System;

public class Program {
    public static void Main(String[] args) {
        int x = 12;
        int y = 18;

        Console.WriteLine("GCD = " + GCD(x, y) + ", LCM = " + LCM(x, y));
    }

    public static int GCD(int x, int y) {

        int min = Math.Min(x, y);
        int gcd = 0;

        for (int i = 1; i <= min; i++) {
            if (x % i == 0 && y % i == 0) {
                gcd = i;
            }
        }

        return gcd;
    }

    public static int LCM(int x, int y) {

        int lcm = Math.Min(x, y);
        int ctr = lcm;

        while ((lcm % y != 0) || (lcm % x != 0)) {

            lcm += ctr;

        }
        

        return lcm;
    }
}