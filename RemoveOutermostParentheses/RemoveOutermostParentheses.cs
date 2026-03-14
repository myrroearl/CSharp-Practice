using System;

class RemoveOutermostParentheses {
    public static void Main(String[] args) {
        
        string parenthesis = "((())()())()()((()))";

        Console.WriteLine(RemoveOuterParentheses(parenthesis));

    }

    public static string RemoveOuterParentheses(string s) {
        
        int ctr = -1;
        string rem = "";
        string valid = "";

        for (int i = 0; i < s.Length; i++) {
            rem += s[i];
            if (s[i] == '(') {
                
                ctr++;
            }
            else {
                ctr--;
                if (ctr == -1) {
                    rem = rem.Remove(rem.Length-1,1);
                    rem = rem.Remove(0,1);
                    
                    valid += rem;
                    
                    rem = "";
                    
                }
            }
           
        }

        return valid;
    }
}