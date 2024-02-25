namespace DSA_CourseSheet.Delegates
{
    public class DelegateSample
    {
        public delegate int helloWorld(int a, int b);
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int sub(int a, int b)
        {
            return a - b;
        }
        public static int mul(int a)
        {
            return a * a;
        }
    }

    public abstract class Shape
    {
        public abstract int getArea();
    }
    public class Square : Shape
    {
        int num;
        public Square(int a)
        {
            num = a;
        }

        public override int getArea()
        {
            Nullable<Int32> i = 89;
            return num;
        }
    }
}
