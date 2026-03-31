using System;
using System.Runtime.InteropServices;

public class Program {
    public static void Main(String[] args) {

        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int target = Convert.ToInt32(Console.ReadLine());
        
    }

    public static int LongestSubarray(int[] arr, int k) {

        int max = 0;

        return max;
    }
}