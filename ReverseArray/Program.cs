using System;

public class Program {

    public static void Main(String[] args) {
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] reversedArr = revArr(arr);

        for (int i = 0; i < reversedArr.Length; i++) {
            Console.Write(reversedArr[i] + " ");
        }
    }

    public static int[] revArr(int[] arr) {
        
        for (int i = 0; i < arr.Length / 2; i++) {
            int temp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = temp;
        }

        return arr;
    }

}