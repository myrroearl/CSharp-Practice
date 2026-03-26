using System;

public class Program {

    public static void Main(String[] args) {

        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(MaxSubarray(arr));

    }

    public static int MaxSubarray(int[] arr) {
        
        int max = int.MinValue;

        for (int i = 0; i < arr.Length; i++) {
            
            int cur = 0;
            for (int j = i; j < arr.Length; j++) {
                
                cur += arr[j];

                max = Math.Max(max, cur);
            }
        }

        return max;
    }

}