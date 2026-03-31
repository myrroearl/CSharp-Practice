using System;

public class Program {

    public static void Main(String[] args) {

        int[] arr = {1, 2, 3, 4};

        int[] outArr = ProductArray(arr);

        for (int i = 0; i < outArr.Length; i++) {
            Console.Write(outArr[i] + " ");
        }

    }

    public static int[] ProductArray(int[] arr) {
        int[] left = new int[arr.Length];
        int[] right = new int[arr.Length];
        int[] outArr = new int[arr.Length];

        left[0] = 1;
        right[arr.Length-1] = 1;

        for (int i = 1; i < left.Length; i++) {
            left[i] = left[i-1] * arr[i-1];
        }

        for (int i = right.Length - 2; i >= 0; i--) {
            right[i] = right[i+1] * arr[i+1];
        }   

        for (int i = 0; i < outArr.Length; i++) {
            outArr[i] = left[i] * right[i];
        }
        return outArr;
    }

}