public class Solution {
    public bool IsValid(string s) {
        var st =  new Stack<char>();

        foreach(char c in s)
        {
            if(c =='(') { st.Push(')'); continue;}
            if(c =='{') { st.Push('}'); continue;}
            if(c =='[') { st.Push(']'); continue;}
            if(st.Count == 0 || st.Pop() != c) return false;
        }
        return st.Count == 0;
    }
}