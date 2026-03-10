using System;

class LargestNumberMatrix {
    public static void Main(String[] args) {
        int[,] matrix = {
            {3,7,2},
            {9,22,5},
            {4,6,8}
        };

        int max = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                max = Math.Max(max, matrix[i,j]);
            }
        }

        Console.WriteLine("Largest = " + max);
    }
}