using static System.Console;

namespace DSA_CourseSheet.Patterns
{
    public class StriverPattern
    {
        public void pattern1(int n)
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
        public void pattern2(int n)
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
        public void pattern3(int n)
        {
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Write(j +" ");
                }
                WriteLine("");
            }
        }
        public void pattern4(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for(int j =1; j <= i; j++)
                {
                    Write(i + " ");
                }
                WriteLine("");
            }
        }
        public void pattern5(int n)
        {
            for (int i=0;i<=n;i++)
            {
                for (int j=0;j < n-i+1;j++)
                {
                    Write("* ");
                }
                WriteLine("");
            }
        }
        public void pattern6(int n)
        {
            for (int i = 0; i <= n; i++)
            {

            }
        }
    }
}
