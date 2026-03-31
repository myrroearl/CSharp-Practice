using System;
using System.Collections.Generic;

public class Program {
    public static void Main(String[] args) {

        int[] arr = {1, 2, 2, 3, 3};

        Console.WriteLine(MostFreq(arr));

    }

    public static int MostFreq(int[] arr) {
        int max = 0;
        int num = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        Array.Sort(arr);

        for (int i = 0; i < arr.Length; i++) {
            if (map.ContainsKey(arr[i])) {
                map[arr[i]]++;
            }
            else {
                map[arr[i]] = 1;
            }

            
            if (map[arr[i]] > max) {
                num = arr[i];
                max = map[arr[i]];
            }
            
            
        }

        return num;
    }
}