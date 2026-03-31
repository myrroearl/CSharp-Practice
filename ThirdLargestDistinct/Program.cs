using System; 

public class Program {

    public static void Main(String[] args) {

        int[] arr = {5, 5, 3};
        // 1 2 3 5
        Console.WriteLine(ThirdLargest(arr));
    }

    public static int ThirdLargest(int[] arr) {

        Array.Sort(arr);
        List<int> list = new List<int>();

        for (int i = 0; i < arr.Length; i++) {
            if (!list.Contains(arr[i])) {
                list.Add(arr[i]);
            }
        }

        if (list.Count < 3) {
            return list[list.Count - 1];
        }
        
        
        return list[list.Count - 3];
    }

}