public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1==s2) return true;
        if(s2.Length < s1.Length) return false;

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];
        
        for(int i=0; i<s1.Length; i++)
        {
            s1Count[s1[i]-'a']++;
            s2Count[s2[i]-'a']++;
        }

        for(int i=0; i < s2.Length - s1.Length; i++)
        {
            if (matches(s1Count, s2Count)) {
                return true;
            }
            // remove the left and add new right character
            s2Count[s2[i] - 'a']--;
            s2Count[s2[i + s1.Length] - 'a']++;
        }

        return matches(s1Count, s2Count);

    }

    public bool matches(int[] s1, int[] s2)
    {
        for (int i = 0; i < 26; i++) 
        {
            if (s1[i] != s2[i]) 
            {
                return false;
            }
        }
        return true;
    }
}
