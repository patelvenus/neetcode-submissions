public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == null || s.Length <= 0)
            return 0;
        
        if(s.Length <= 1)
            return 1;
        
        int i = 0; 
        int j = i+1;
        int res = 0;
        var map = new HashSet<char>();
        map.Add(s[i]);

        while(j < s.Length)
        {
            if(!map.Contains(s[j]))
            {
                map.Add(s[j]);
                j++;
            }
            else
            {
                map.Remove(s[i]);
                i++;
            }

            res = Math.Max(res, map.Count);
        }
        return res;
    }
}
