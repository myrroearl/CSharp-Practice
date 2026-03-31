using System;


public class Program {
    public static void Main(String[] args) {

        int[] nums = [4,4,4,1,1,2,2,2,3];
        int k = 2;

        List<int> list = TopKFreq(nums, k);

        foreach (int i in list) {
            Console.Write(i + " ");
        }

    }

    public static List<int> TopKFreq(int[] nums, int k) {

        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> list = new List<int>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length / 2; i++) {
            int temp = nums[i];
            nums[i] = nums[nums.Length - i - 1];
            nums[nums.Length - i - 1] = temp;
        }

        int max = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (map.ContainsKey(nums[i])) {
                map[nums[i]]++;
            }
            else {
                map[nums[i]] = 1;
            }

        }

        foreach (var pair in map) {
            if (pair.Value >= max) {
                max = pair.Value;
                list.Add(pair.Key);
            } 

            if (list.Count > k) {
                list.Remove(list[0]);
            }
        }

        list.Reverse();
        return list;

    }
}