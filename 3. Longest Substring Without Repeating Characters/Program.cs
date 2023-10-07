using System.Diagnostics.Metrics;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> h = new HashSet<char>();
        int max = 0;
        int tracker = -1;
        for (int i = 0; i < s.Length; i++)
        {
            if (h.Count > 0 && h.ElementAt(tracker + 1) == s[i])
            {
                tracker++;
                h.Clear();
                i = tracker;
                continue;
            }
            else h.Add(s[i]);
            max = Math.Max(h.Count, max);
        }
        return max;
    }

    static void Main()
    {
        Solution solution = new Solution();
        solution.LengthOfLongestSubstring("abcabcbb");
        solution.LengthOfLongestSubstring("aab");
        solution.LengthOfLongestSubstring("pwwkew");
        solution.LengthOfLongestSubstring("pwwkew pwwkew pwwkewpwwkew");
    }


}