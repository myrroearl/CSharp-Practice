using System;

public class Program {
    public static void Main(String[] args) {
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(SubArrayGivenSum(arr, k));
    }

    public static string SubArrayGivenSum(int[] arr, int k) {

        for (int i = 0; i < arr.Length; i++) {
            
            int cur = 0;
            for (int j = i; j < arr.Length; j++) {
                
                cur += arr[j];

                if (cur == k) {
                    return "YES";
                }
            }
        }

        return "NO";
    }
}