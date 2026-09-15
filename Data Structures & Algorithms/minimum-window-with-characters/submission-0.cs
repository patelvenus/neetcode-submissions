public class Solution {
    public string MinWindow(string s, string t) {
        if(string.IsNullOrEmpty(t)) return "";
        
        var mapT = new Dictionary<char, int>();
        var mapS = new Dictionary<char, int>();

        foreach(char c in t){
            mapT.TryAdd(c, 0);
            mapT[c]++;
        }

        int have = 0, need = mapT.Count;
        int l=0;
        int[] res = { -1, -1 };
        int resLen = int.MaxValue;

        for (int r = 0;r < s.Length; r++)
        {
            char c = s[r];
            mapS.TryAdd(c, 0);
            mapS[c]++;

            if(mapT.ContainsKey(c) && mapS[c] == mapT[c])
            {
                have++;
            }

            while(have==need)
            {
                if ((r - l + 1) < resLen)
                {
                    resLen = r - l + 1;
                    res[0] = l;
                    res[1] = r;
                }

                char leftChar = s[l];
                mapS[leftChar]--;
                
                if(mapT.ContainsKey(leftChar) && mapS[leftChar] < mapT[leftChar])
                {
                    have--;
                }
                l++;
            }
        }

        return resLen == int.MaxValue ? "" : s.Substring(res[0], resLen);
    }
}
//look at the video for the solution explaination.
//Example string to run S = "ADOBECOREBANC"


// Algorithm
// If t is empty, return "".
// Build a frequency map countT for characters in t.
// Initialize:
// window as an empty map for the current window counts.
// have = 0 = how many characters currently meet the required count.
// need = len(countT) = how many distinct characters we need to match.
// res = [-1, -1] and resLen = infinity to store the best window.
// Use a right pointer r to expand the window over s:
// Add s[r] to window.
// If s[r] is in countT and its count in window matches countT, increment have.
// When have == need, the window is valid:
// Update the best result if the current window is smaller.
// Then shrink from the left:
// Decrease the count of s[l] in window.
// If s[l] is in countT and its count in window falls below countT, decrement have.
// Move l right.
// After the loop, return the substring defined by res if found; otherwise, return "".