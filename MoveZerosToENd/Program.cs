using System;
using System.Data;
using System.Globalization;

public class Program {
    public static void Main(String[] args) {

        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        List<int> list = new List<int>();

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] != 0) {
                list.Add(arr[i]);
            }
        }

        int j = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (j != list.Count) {
                arr[i] = list[j];
                j++;
            }
            else {
                arr[i] = 0;
            }    
        }

        for (int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }

    }
}