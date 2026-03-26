using System;
using System.Collections.Generic;
public class Program {

    public static void Main(String[] args) {
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(SecLarg(arr));
    }

    public static int SecLarg(int[] arr) {

        HashSet<int> set = new HashSet<int>(arr);
        int[] temp = new int[set.Count];

        int x = 0;
        foreach (int i in set) {
            temp[x] = i;
            x++;
        }

        Array.Sort(temp);


        if (temp.Length < 2) {
            return -1;
        }
        return temp[temp.Length-2];
    }

}