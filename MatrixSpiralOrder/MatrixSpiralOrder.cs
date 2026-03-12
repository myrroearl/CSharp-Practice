using System;

class MatrixSpiralOrder {
    public static void Main(String[] args) {
        int[,] matrix = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        int[,] matrix2 = {
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12},
            {13,14,15,16},
        };

        int[,] matrix3 = {
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12},
        };

    }


    public static IList<int> SpiralOrder(int[][] matrix) {
        List<int> list = new List<int>();

        if (matrix[0].Length == 1) {
            for (int a = 0; a < matrix.Length; a++) {
                list.Add(matrix[a][0]);
            }

            return list;
        }

        list.Add(matrix[0][0]);
        int rowMin = 1;
        int rowMax = matrix.Length - 1;

        int colMin = 0;
        int colMax = matrix[0].Length - 1;

        int colToggleCounter = 0;
        int rowToggleCounter = 0;
        
        int ctr = 1;
        int i = 0;
        int j = 0;

        while (ctr != (matrix.Length * matrix[0].Length)) {
            if (colToggleCounter == rowToggleCounter) {
                if (colToggleCounter % 2 == 0) {
                    j++;
                    list.Add(matrix[i][j]);

                    if (j == colMax) {
                        colMax--;
                        colToggleCounter++;
                    }
                }
                else {
                    j--;
                    list.Add(matrix[i][j]);
                    
                    if (j == colMin) {
                        colMin++;
                        colToggleCounter++;
                    }
                }
                
            }
            else {
                if (rowToggleCounter % 2 == 0) {
                    i++;
                    list.Add(matrix[i][j]);
                    
                    if (i == rowMax) {
                        rowMax--;
                        rowToggleCounter++;
                    }
                }
                else {
                    i--;
                    list.Add(matrix[i][j]);

                    if (i == rowMin) {
                        rowMin++;
                        rowToggleCounter++;
                    }
                }
                
            }
            
            ctr++;
        }

        return list;
    }
}