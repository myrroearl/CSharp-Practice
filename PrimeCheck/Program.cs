using System;

public class Program {
    public static void Main(String[] args) {

        int x = 29;

        Console.WriteLine(PrimeCheck(x));
    }

    public static bool PrimeCheck(int x) {

        for (int i = 2; i <= x - 1; i++) {
            if (x % i == 0) {
                return false;
            }
        }

        return true;
    }

}