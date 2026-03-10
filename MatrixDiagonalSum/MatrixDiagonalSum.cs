using System;

class MatrixDiagonalSum {
    public static void Main(String[] args) {
        int[,] matrix = {
            {1,2,10},
            {4,5,6},
            {7,8,9}
        };

        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            sum += matrix[i,i];
        }

        int diagSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) {
            diagSum += matrix[i,matrix.GetLength(0)-i-1];
        }

        Console.WriteLine("Diagonal Sum = " + sum);
        Console.WriteLine("Secondary Diagonal Sum = " + diagSum);
    }
}