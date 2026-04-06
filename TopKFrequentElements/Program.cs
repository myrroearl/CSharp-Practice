using System;


public class Program {
    public static void Main(String[] args) {

        int[] nums = [4,4,4,1,1,2,2,2,3];
        int k = 2;

        int[] arr = TopKFreq(nums, k);

        for (int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }

    }

    public static int[] TopKFreq(int[] nums, int k) {

       int[] arr = new int[k];

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {

            if (map.ContainsKey(nums[i])) {
                map[nums[i]]++;
            }
            else {
                map[nums[i]] = 1;
            }
            
        }


        var temp = map.ToList();

        temp.Sort((a, b) => {
            if (a.Value != b.Value) {
                return b.Value.CompareTo(a.Value);
            }
            return a.Key.CompareTo(b.Key);
        });

        
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = temp[i].Key;
        }

       return arr;

    }
}