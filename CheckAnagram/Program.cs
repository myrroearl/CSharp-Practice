using System;
using System.Collections.Generic;
public class Program {
    public static void Main(String[] args) {

        string x = "hello";
        string y = "world";

        CheckAnagram(x, y);
    }

    public static void CheckAnagram(string x, string y) {

        bool flag = true;
        Dictionary<char, int> mapX = new Dictionary<char, int>();
        Dictionary<char, int> mapY = new Dictionary<char, int>();

        for (int i = 0; i < x.Length; i++) {
            if (mapX.ContainsKey(x[i])) {
                mapX[x[i]]++;
            }
            else {
                mapX[x[i]] = 1;
            }

            if (mapY.ContainsKey(y[i])) {
                mapY[y[i]]++;
            }
            else {
                mapY[y[i]] = 1;
            }
        }

        foreach (var pair in mapX) {
            char c = pair.Key;

            if (mapY.ContainsKey(c)) {
                if (mapY[c] != mapX[c]) {
                    flag = false;
                }
            }
            else {
                flag = false;
                break;
            }
        }

        if (flag == true) {
            Console.WriteLine("YES");
        }
        else {
            Console.WriteLine("NO");
        }
    }
}