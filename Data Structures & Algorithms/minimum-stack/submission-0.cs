public class MinStack {
    Stack<int> stack = null;
    Stack<int> minStack = null;
    int minValue = 0;
    
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    public void Push(int val) {
        if(stack.Count == 0)
        {
            minValue = val;
        }
        stack.Push(val);
        minValue = Math.Min(minValue, val);
        minStack.Push(minValue);
    }
    public void Pop() {
        stack.Pop();
        minStack.Pop();
        if(minStack.Count > 0)
        {
            minValue = minStack.Peek();
        }
    }
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minValue;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */