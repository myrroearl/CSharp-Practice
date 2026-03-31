using System;

public class Program {
    public static void Main(String[] args) {

        int x = 12;

        Console.WriteLine(NumberOfDiv(x));
    }

    public static int NumberOfDiv(int x) {
        int ctr = 0;

        for (int i = 1; i <= x; i++) {
            if (x % i == 0) {
                ctr++;
            }
        }

        return ctr;
    }
}