using System;

public class Program {
    public static void Main(String[] args) {

        int x = 14;

        Console.WriteLine(UglyNumber(x));
    }

    public static bool UglyNumber(int x) {

        while (x != 1) {
            if (x % 5 == 0) {
                x /= 5;
            }
            else if (x % 3 == 0) {
                x /= 3;
            }
            else if (x % 2 == 0) {
                x /= 2;
            }
            else {
                return false;
            }
        }

        return true;
    }
}