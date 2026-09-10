public class Solution {

    public string Encode(IList<string> strs) {
        
        if (strs.Count == 0)
            return string.Empty;
        
        var sb = new StringBuilder();
        foreach(var str in strs)
        {
            sb.Append(str.Length).Append('#').Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        //5#Hello5#World
        
        if(string.IsNullOrEmpty(s))
            return new List<string>();
        
        var res = new List<string>();
        int i=0;

        while(i < s.Length)
        {
            int delimiterIndex = s.IndexOf('#', i);//this give the first index of # from start index i
            int length = int.Parse(s.Substring(i, delimiterIndex - i));// find the length of the word
            string word = s.Substring(delimiterIndex + 1, length);// find the word
            i = delimiterIndex + 1 + length; // move on to next number

            res.Add(word);
        }

        return res;
   }
}
