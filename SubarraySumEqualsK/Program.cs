using System;

public class Program {
    public static void Main(String[] args) {

        int[] nums = {1, 2, 3};
        int k = 3;

        Console.WriteLine(NumOfSubarrays(nums, k));

    }

    public static int NumOfSubarrays(int[] arr, int k) {

        int ctr = 0;

        for (int i = 0; i < arr.Length; i++) {
            int sum = 0;
            for (int j = i; j < arr.Length; j++) {
                sum += arr[j];

                if (sum == k) {
                    ctr++;
                }
                
            }
        }

        return ctr;
    
    }

}