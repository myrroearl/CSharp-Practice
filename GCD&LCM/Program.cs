using System;

public class Program {
    public static void Main(String[] args) {
        int x = 12;
        int y = 18;

        Console.WriteLine("GCD = " + GCD(x, y) + ", LCM = " + LCM(x, y));
    }

    public static int GCD(int x, int y) {
        
        while (x != 0) {
            int temp = x;
            x = y % x;
            y = temp;
        }

        return y;
        
    }

    public static int LCM(int x, int y) {

        return (x / GCD(x, y)) * y;
    }
}