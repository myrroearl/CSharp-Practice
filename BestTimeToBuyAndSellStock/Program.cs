using System;

public class Program {
    public static void Main(String[] args) {

        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(maxProfit(arr));

    }

    public static int maxProfit(int[] arr) {

        int max = 0;
        for (int i = 0; i < arr.Length; i++) {

            for (int j = i + 1; j < arr.Length; j++) {
                int profit = arr[j] - arr[i];

                max = Math.Max(max, profit);
            }

        }

        return max;
    }
}