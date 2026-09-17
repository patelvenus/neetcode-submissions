public class Solution {
    public int[] DailyTemperatures(int[] t) {
        var res = new int[t.Length];
        var st = new Stack<int[]>(); // store temparature and index of the temprature.
        st.Push(new int[] {t[0], 0});
        
        for(int i=1 ;i<t.Length;i++)
        {
            while(st.Count > 0 && t[i] > st.Peek()[0])    
            {
                int[] pair = st.Pop();
                res[pair[1]] = i - pair[1];
            }
            st.Push(new int[] {t[i], i});
        }

        return res;
    }
}
