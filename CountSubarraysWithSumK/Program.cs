using System;
using System.Collections.Generic;

public class Program {

    public static void Main(String[] args) {

        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int target = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(CountSubarrays(arr, target));
    }

    public static int CountSubarrays(int[] arr, int target) {

        HashSet<int> set = new HashSet<int>();

        int ctr = 0;
        int sum = 0;

        for (int i = 0; i < arr.Length; i++) {

            if (set.Contains(arr[i])) {
                ctr++;
            }
            set.Add(target - arr[i]);
            sum += arr[i];
        }

        return ctr;
    }

}