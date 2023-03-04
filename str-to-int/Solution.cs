public class Solution {
    public int MyAtoi(string s) {
        s = s.Trim();
        if (s.Length < 1) return 0;

        bool isNegative = s[0] == '-';
        bool hasSign = isNegative || s[0] == '+';

        int integer = 0;
        for (int i = hasSign ? 1 : 0; i < s.Length; i++) {
            if (!char.IsNumber(s[i])) break;

            int num = s[i] - '0';
            int newInteger = integer * 10 + num;

            if ((newInteger - num) / 10 != integer)
                return isNegative
                    ? Int32.MinValue
                    : Int32.MaxValue;
            else integer = newInteger;
        }

        if (isNegative) integer *= -1;
        return integer;
    }
}