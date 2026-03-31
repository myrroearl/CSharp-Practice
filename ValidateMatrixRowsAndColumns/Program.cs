using System;
using System.Collections.Generic;

public class Program {
    public static void Main(String[] args) {
        int[][] arr = [[1, 2, 3],
                       [1, 2, 3],
                       [2, 3, 1]];

            
        Console.WriteLine(ValidateMatrix(arr));
    }

    public static bool ValidateMatrix(int[][] arr) {

        
        for (int i = 0; i < arr.Length; i++) {
            HashSet<int> setx = new HashSet<int>();
            HashSet<int> sety = new HashSet<int>();
            for (int j = 0; j < arr.Length; j++) {

                if (setx.Contains(arr[i][j])) {
                    return false;
                }
                else {
                    setx.Add(arr[i][j]);
                }
                
                if (sety.Contains(arr[j][i])) {
                    return false;
                }
                else {
                    sety.Add(arr[j][i]);
                }
                

            }
            
        }

        return true;
    }
}