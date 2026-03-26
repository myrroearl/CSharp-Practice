using System;

public class Program {

    public static void Main(String[] args) {

        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        arr = RemoveDup(arr);

        for (int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }

    }

    public static int[] RemoveDup(int[] arr) {

        List<int> list = new List<int>();

        for (int i = 0; i < arr.Length; i++) {

            if (!list.Contains(arr[i])) {
                list.Add(arr[i]);
            }

        }

        int j = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (j < list.Count) {
                arr[i] = list[j];
                j++;
            }
            else {
                arr[i] = 0;
            }
        }

        return arr;        
    }

}