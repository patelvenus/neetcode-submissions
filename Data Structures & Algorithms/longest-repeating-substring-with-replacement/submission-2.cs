public class Solution {
    public int CharacterReplacement(string s, int k) {
        int maxWindow = 0;
        int[] mapFrequency = new int[26];
        int i=0;
        int maxFrequency = 0;
        
        for(int j=0; j<s.Length; j++)
        {
            mapFrequency[s[j] - 'A']++;
            maxFrequency = Math.Max(maxFrequency, mapFrequency[s[j] - 'A']);

            int windowSize = j-i+1;

            if(windowSize - maxFrequency > k)
            {
                mapFrequency[s[i] - 'A']--;
                i++;
            }
            windowSize = j-i+1;
            maxWindow = Math.Max(maxWindow, windowSize);

        }
        
        return maxWindow;
    }
}
// #character_to_be_replaced = windowSize - maxFrequency;
// if character_to_be_replaced > K then move the left pointer else keep j moving to right until we capture maxwindow
// https://www.youtube.com/watch?v=ExY8svHF_Eo

