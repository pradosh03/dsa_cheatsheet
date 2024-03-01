using DSA_CourseSheet.BasicMaths;
using DSA_CourseSheet.Generic;
using c=DSA_CourseSheet.LogicProblems;
using DSA_CourseSheet.Patterns;
using static DSA_CourseSheet.Delegates.DelegateSample;

namespace DSA_CourseSheet
{
    public class MainClass
    {
        public static void Main(string[] args)
        {

            /*     Pattern        */
            //patternCallMethod();


            /*Striver pattern*/
            striversPatternCallMethod();


            /*     Generic Type Collections         */
            //genericCallMethod();

            /*     Basic Maths         */
            //BasicMathsProgram basicMath = new();
            //int output = basicMath.Reverse(-1534236469);

            /*     Delegates         */
            //helloWorld obj = add;
            //obj += sub;
            //int output = obj(1, 3);
            //Console.WriteLine(obj(1, 3));




            Console.ReadKey();
        }
        public static void patternCallMethod()
        {
            MyPatterns pattern = new();
            int n = 10;
            pattern.Patter1(n);
            pattern.Patter2(n);
            pattern.Patter3(n);
            //pattern.Patter4(n);
            //pattern.Patter5(n);
            //pattern.Patter6(n);
            pattern.Patter7(n);
            pattern.Pattern8(n);
            pattern.Pattern9(n);
            pattern.Pattern10(n);
            //pattern.Pattern11(n);//--Wrong Pattern
            //pattern.Pattern12(n);
            //pattern.Pattern13(n);
            //pattern.Pattern14(n);
            pattern.Pattern15(n);
            pattern.Pattern16(n);


            ////pattern.Pattern20(n);--Wrong Pattern
            pattern.Pattern21(n);

        }
        public static void striversPatternCallMethod()
        {
            StriverPattern striverPattern = new();
            int n = 5;
            //striverPattern.pattern1(n);
            //striverPattern.pattern2(n);
            //striverPattern.pattern3(n);
            //striverPattern.pattern4(n);
            //striverPattern.pattern5(n);

            //for (int i = 0; i < 10; i++)
            //{
                striverPattern.pattern5(5);

            //}


        }
        public static void genericCallMethod()
        {
            GenericCollection obj = new();
            obj.genericTypeMethod();
        }
    }

}