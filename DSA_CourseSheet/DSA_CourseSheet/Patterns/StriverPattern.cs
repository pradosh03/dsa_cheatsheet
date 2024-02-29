using static System.Console;

namespace DSA_CourseSheet.Patterns
{
    public class StriverPattern
    {
        public void Pattern1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Write("* ");    
                }
                WriteLine("");
            }
        }
        public void Pattern2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Write("* ");
                }
                WriteLine("");
            }
        }
    }
}
