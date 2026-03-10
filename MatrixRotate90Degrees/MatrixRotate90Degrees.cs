using System;

class MatrixRotate90Degrees {
    public static void Main(String[] args) {
        /*To do this problem we should do 2 step
        1. Transposed the given array
        2. Reverse the row of the transposed array
        = To get the Rotated90Degrees of the given array
        */
        int[,] matrix = {
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12}
        };

        int[,] transposedArr = new int[matrix.GetLength(1),matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                transposedArr[j,i] = matrix[i,j];
            }
        }

        Console.WriteLine("Transposed Array:");

        for (int i = 0; i < transposedArr.GetLength(0); i++) {
            for (int j = 0; j < transposedArr.GetLength(1); j++) {
                Console.Write(transposedArr[i,j] + " ");
            }
            Console.WriteLine();
        }

        //reverse rows
        for (int i = 0; i < transposedArr.GetLength(0); i++) {
            for (int j = 0; j < transposedArr.GetLength(1)/2; j++) {
                int temp = transposedArr[i,j];
                transposedArr[i,j] = transposedArr[i,j+transposedArr.GetLength(1)-1];
                transposedArr[i,j+transposedArr.GetLength(1)-1] = temp;
            }
        }

        Console.WriteLine("Rotate 90 Degrees Array:");
        for (int i = 0; i < transposedArr.GetLength(0); i++) {
            for (int j = 0; j < transposedArr.GetLength(1); j++) {
                Console.Write(transposedArr[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}