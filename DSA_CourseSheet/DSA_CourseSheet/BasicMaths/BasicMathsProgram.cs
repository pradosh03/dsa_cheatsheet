namespace DSA_CourseSheet.BasicMaths
{
    public class BasicMathsProgram
    {
        public int Reverse(int x)
        {
            bool flag = true;
            if (x <= int.MinValue || x >= int.MaxValue) return 0;
            int reversed = 0;
            int maxValue = int.MaxValue / 10;
            int minValue = int.MinValue / 10;
            if (x < 0)
            {
                x = Math.Abs(x);
                flag = false;
            }

            while (x != 0)
            {
                if (reversed > maxValue || reversed < minValue) return 0;
                reversed = reversed * 10 + (x % 10);
                x /= 10;
            }
            if (!flag) return -1 * reversed;
            return reversed;
        }
    }
}
