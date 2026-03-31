using System;
using System.Text;
using System.Collections.Generic;

public class Program {
    public static void Main(String[] args) {

        int x = 123;

        Console.WriteLine(ToWords(x));
    }

    public static string ToWords(int x) {
        string temp = Convert.ToString(x);
        string s = "";

        Dictionary<int, string> map = new Dictionary<int, string>();

        map.Add(1, "One");
        map.Add(2, "Two");
        map.Add(3, "Three");
        map.Add(4, "Four");
        map.Add(5, "Five");
        map.Add(6, "Six");
        map.Add(7, "Seven");
        map.Add(8, "Eight");
        map.Add(9, "Nine");
        map.Add(10, "Ten");

        map.Add(11, "Eleven");
        map.Add(12, "Twelve");
        map.Add(13, "Thirteen");
        map.Add(14, "Fourteen");
        map.Add(15, "Fifteen");
        map.Add(16, "Sixteen");
        map.Add(17, "Seventeen");
        map.Add(18, "Eighteen");
        map.Add(19, "Nineteen");

        map.Add(20, "Twenty");
        map.Add(30, "Thirty");
        map.Add(40, "Fourty");
        map.Add(50, "Fifty");
        map.Add(60, "Sixty");
        map.Add(70, "Seventy");
        map.Add(80, "Eighty");
        map.Add(90, "Ninety");

        int ctr = 1;
        int dig = 1;


        for (int i = temp.Length - 1; i >= 0; i--) {
            if (ctr == 3) {
                s = "Hundred " + s;
                dig = 0;
            }
            else if (ctr == 4) {
                s = "Thousand " + s;
                dig = 0;
            }
            else if (ctr == 7) {
                s = "Million " + s;
                dig = 0;
            }

            if (dig == 1 || dig == 0) {
                int getValInt = Convert.ToInt32(temp[i] - '0');

                string w = map[getValInt];
                s = w + " " + s;
            }
            else if (dig == 2) {
                if (temp[i] == '1') {
                    int getValInt = Convert.ToInt32(temp[i] - '0');
                    getValInt *= 10;

                    int getValIntNext = Convert.ToInt32(temp[i + 1] - '0');
                    getValInt += getValIntNext;

                    string w = map[getValInt];
                    s = w + " " + s;
                }
                else {
                    int getValInt = Convert.ToInt32(temp[i] - '0');
                    getValInt *= 10;
                    string w = map[getValInt];
                    s = w + " " + s;
                }
            }
            

            dig++;
            ctr++;
        }

        return s;
    }
}