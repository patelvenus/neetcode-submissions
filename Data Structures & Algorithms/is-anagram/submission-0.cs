public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s==t) 
            return true;
        if(s.Length != t.Length) 
            return false;
        
        var charCount = new Dictionary<char, int>();

        for(int i= 0; i< s.Length; i++)
        {
            charCount.TryAdd(s[i], 0);
            charCount.TryAdd(t[i], 0);


            charCount[s[i]] = charCount[s[i]] + 1;
            charCount[t[i]] = charCount[t[i]]- 1;
        }

        return charCount.Values.All(t=>t==0);


    }
}
