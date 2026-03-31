using System; 
using System.Collections.Generic;

public class Program {

    public static void Main(String[] args) {

        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++) {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int target = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(isExist(arr, target));

    }

    public static string isExist(int[] arr, int target) {

        HashSet<int> set = new HashSet<int>();

        int sum = 0;
        for (int i = 0; i < arr.Length; i++) {

            if (set.Contains(sum - target)) {
                return "YES";
            }
            else {
                set.Add(arr[i]);
                sum += arr[i];
            }

        }

        return "NO";
    }


}