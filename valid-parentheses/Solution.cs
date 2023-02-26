public class Solution {
    private readonly Dictionary<char, char> _correspondingOpening = new Dictionary<char, char>() {
        { ')', '(' },
        { ']', '[' },
        { '}', '{' }
    };

    private bool IsClosingParentheses(char c) => _correspondingOpening.ContainsKey(c);

    public bool IsValid(string s) {
        if (s.Length % 2 != 0 ||
            IsClosingParentheses(s[0]) ||
            !IsClosingParentheses(s[s.Length - 1])
        ) {
            return false;
        }

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++) {
            if (IsClosingParentheses(s[i])) {
                if (!stack.TryPop(out char c) || c != _correspondingOpening[s[i]]) return false;
            }
            else stack.Push(s[i]);
        }

        return stack.Count < 1;
    }
}