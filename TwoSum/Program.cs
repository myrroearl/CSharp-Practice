using System;
using System.Collections.Generic;

public class Program {
    public static void Main(String[] args) {

        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int target = Convert.ToInt32(Console.ReadLine());
        int[] TwoArr = TwoSum(arr, target);

        if (TwoArr.Length != 0) {
            Console.WriteLine(TwoArr[0] + " " + TwoArr[1]);
        }
        
    }

    public static int[] TwoSum(int[] arr, int target) {

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++) {
            map.Add(target - arr[i], i);

            if (map.ContainsKey(target -arr[i])) {
                return [map[arr[i]], i];
            }
        }

        return [];
    }
}