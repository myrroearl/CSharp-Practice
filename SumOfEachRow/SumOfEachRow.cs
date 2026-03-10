using System;

class SumOfEachRow {
    public static void Main(String[] args) {
        int[,] matrix = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        for (int i = 0; i < matrix.GetLength(0); i++) {
            int total = 0;

            for (int j = 0; j < matrix.GetLength(1); j++) {
                total += matrix[i,j];
            }

            Console.WriteLine("Row " + i + " Sum = " + total);
        }
    }
}