using System;

class MatrixRotate90Degress {
    public static void Main(String[] args) {
        int[,] matrix = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        int[,] transposedArr = new int[matrix.GetLength(1),matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                transposedArr[j,i] = matrix[i,j];
            }
        }

        for (int i = 0; i < transposedArr.GetLength(0); i++) {
            for (int j = 0; j < transposedArr.GetLength(1); j++) {
                Console.Write(transposedArr[i,j] + " ");
            }
            Console.WriteLine();
        }
        
        for (int i = 0; i < transposedArr.GetLength(0); i++) {
            for (int j = 0; j < transposedArr.GetLength(1) / 2; j++) {
                int temp = transposedArr[i, j];
                transposedArr[i,j] = transposedArr[i,transposedArr.GetLength(1) - j - 1];
                transposedArr[i, transposedArr.GetLength(1) - j - 1] = temp;
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < transposedArr.GetLength(0); i++) {
            for (int j = 0; j < transposedArr.GetLength(1); j++) {
                Console.Write(transposedArr[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}