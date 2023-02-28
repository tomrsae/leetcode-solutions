public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length > haystack.Length) return -1;
        
        int needleIdx = 0;
        for (int i = 0; i < haystack.Length; i++) {
            if (haystack[i] == needle[needleIdx]) {
                if (needleIdx < needle.Length - 1) needleIdx++;
                else return i - needleIdx;
            } else {
                if (needleIdx > 0) {
                    i -= needleIdx;
                    needleIdx = 0;
                }
            }
        }
        
        return -1;
    }
}