using System;
using System.Collections.Generic;

public class Program {
    public static void Main(String[] args) {

        int[] arr = [1, 2, 4, 5];

        Console.WriteLine(MissingNumber(arr));

    }

    public static int MissingNumber(int[] arr) {

        HashSet<int> set = new HashSet<int>(arr);

        for (int i = 1; i <= arr.Length; i++) {
            if (!set.Contains(i)) {
                return i;
            }
        }

        return 0;
    }
}