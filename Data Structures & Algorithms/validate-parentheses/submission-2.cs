public class Solution {
    public bool IsValid(string s) {
        
        var stack = new Stack<char>();

        foreach(char c in s)
        {
            if( c == '(' || c == '{' || c == '[' )
                stack.Push(c);
            else
            {
                if(stack.Count<=0)
                    return false;
                
                var p = stack.Peek();
                
                if(c == ']' && p!= '[') return false;
                else if(c == '}' && p!= '{') return false;
                else if(c == ')' && p!= '(') return false;
                stack.Pop();
            }
        }
        return stack.Count == 0;
    }
}
