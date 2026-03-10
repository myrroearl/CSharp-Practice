using System;

class CountEvenNumbersMatrix {
    public static void Main(String[] args) {
        int[,] matrix = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        int ctr = 0;
        Console.Write("Even Numbers: ");
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                if (matrix[i,j] % 2 == 0) {
                    Console.Write(matrix[i,j] + " ");
                    ctr++;
                }
            }
        }

        Console.WriteLine("Total even numbers = " + ctr);
    }
}