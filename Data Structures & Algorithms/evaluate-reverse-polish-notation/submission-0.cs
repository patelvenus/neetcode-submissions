public class Solution {
    private int PerformOperation(int a, int b, string op)
    {
         switch (op)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                return a / b;
            default:
                throw new NotSupportedException($"Operator {op} is not supported.");
        }
    }

    public int EvalRPN(string[] tokens) {
        var st = new Stack<int>();
        
        foreach(string c in tokens)
        {
            int n; 
            int result;

            if(Int32.TryParse(c, out n))
                st.Push(n);
            else
            {
                int b = st.Pop();
                int a = st.Pop();

                result = PerformOperation(a, b, c);

                st.Push(result);
            }
        }

        return st.Peek();
    }
}