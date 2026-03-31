using System;

public class Program {

    public static void Main(String[] args) {

        int[] nums = [2, -1, 2];
        int k = 3;

        Console.WriteLine(SmallestSubarray(nums, k));
    }

    public static int SmallestSubarray(int[] arr, int k) {

        int min = int.MaxValue;
        for (int i = 0; i < arr.Length; i++) {
            int ctr = 0;
            for (int j = i; j < arr.Length; j++) {
                ctr += arr[j];

                if (ctr >= k) {
                    min = Math.Min(min, j - i + 1);
                }
            }
        }

        if (min == int.MaxValue) {
            return -1;
        }
        return min;
    }
}