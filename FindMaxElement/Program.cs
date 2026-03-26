using System;

public class Program {

    public static void Main(String[] args) {


        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(MaxElement(arr));

    }

    public static int MaxElement(int[] arr) {

        if (arr.Length == 1) {
            return arr[0];
        }
        
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++) {
            max = Math.Max(max, arr[i]);
        }
        return max;
    }

}