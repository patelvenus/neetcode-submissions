public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        // create dictionary <string, List<string>()>
        // iterate each string from input
        // Convert each string to chart array and short the array and covert to string and store to dictionary as key.
        // if same key present then add string to that key list.
        // finally return the values of dictionary.

        var dict = new Dictionary<string, List<string>>();

        for(int i=0; i < strs.Length; i++)
        {
            var arr = strs[i].ToCharArray();
            Array.Sort(arr);
            var key = new string(arr);// remember to take new memory = new string(); object or else it will try to edit the same into memory

            if (dict.ContainsKey(key))
            {
                dict[key].Add(strs[i]);
            }
            else
            {
                dict.Add(key, new List<string>(){strs[i]});
            }
        }

        return dict.Values.ToList<List<string>>();   
    }
}
