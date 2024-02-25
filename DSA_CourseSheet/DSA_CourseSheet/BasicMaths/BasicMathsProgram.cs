namespace DSA_CourseSheet.BasicMaths
{
    public class BasicMathsProgram
    {
        public int Reverse(int x)
        {
            int reversed = 0;
            while (x != 0)
            {
                if (reversed > int.MaxValue / 10 || reversed < int.MinValue / 10)
                {
                    return 0;
                }
                reversed = reversed * 10 + (x % 10);
                x /= 10;
            }
            return reversed;
        }
    }
}
