namespace DSA_CourseSheet.Patterns
{
    public class MyPatterns
    {
        public void Patter1(int n)
        {
            string printOutput = new string('*', n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(printOutput);
            }
            Console.WriteLine("---------------------Output--------------------------");

            //*****
            //*****
            //*****
            //*****
            //*****
        }
        public void Patter2(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(new string('*', i + 1));
            }
            Console.WriteLine("---------------------Output--------------------------");

            //*
            //**
            //***
            //****
            //*****
        }
        public void Patter3(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(string.Join(" ", Enumerable.Range(1, i + 1)));
            }
            Console.WriteLine("---------------------Output--------------------------");

            //1
            //1 2
            //1 2 3
            //1 2 3 4
            //1 2 3 4 5
        }
        public void Patter4(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(new string(Convert.ToChar(i.ToString()), i + 1));
            }
            Console.WriteLine("---------------------Output--------------------------");

            //1
            //22
            //333
            //4444
            //55555
        }
        public void Patter5(int n)
        {
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(new string('*', i));
            }
            Console.WriteLine("---------------------Output--------------------------");

            //****
            //***
            //**
            //*
        }
        public void Patter6(int n)
        {

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(string.Join(" ", Enumerable.Range(1, i)));
            }
            Console.WriteLine("---------------------Output--------------------------");

            //1 2 3 4 5
            //1 2 3 4
            //1 2 3
            //1 2
            //1
        }
        public void Patter7(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    /*Print leading spaces-->*/new string(' ', n - i - 1)
                    /*Concate the to strings*/ +
                    /*Print Starts -->*/ new string('*', 2 * i + 1)
                );
            }
            Console.WriteLine("---------------------Output--------------------------");

            //    *
            //   ***
            //  *****
            // *******
            //*********
        }
        public void Pattern8(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(
                    /*Print leading spaces-->*/new string(' ', n - i)
                    /*Concate the to strings*/ +
                    /*Print Starts -->*/ new string('*', 2 * i - 1)
                 );
            }
            Console.WriteLine("---------------------Output--------------------------");

            // *********
            //  *******
            //   *****
            //    ***
            //     *
        }
        public void Pattern9(int n)
        {
            // Half of the diamond (Adjust this value to change the size of the diamond)

            for (int i = 0; i < n * 2 - 1; i++)
            {
                int spaces = Math.Abs(n - i - 1);
                int stars = n * 2 - 1 - 2 * spaces;

                Console.Write(new string(' ', spaces));
                Console.Write(new string('*', stars));
                Console.WriteLine();
            }

            Console.WriteLine("---------------------Output--------------------------");
            /* 
                *
               ***
              *****
             *******
            *********
             *******
              *****
               ***
                * 
             */


        }
        public void Pattern10(int n)
        {
            for (int i = 1; i <= n * 2 - 1; i++)
            {
                int count = i <= n ? i : n * 2 - i;
                Console.WriteLine(new string('*', count));
            }
            Console.WriteLine("---------------------Output--------------------------");
            /*
            *
            **
            ***
            ****
            *****
            ****
            ***
            **
            *
            */
        }
        public void Pattern11(int n)//Wrong Correct
        {
            for (int i = 1; i <= n; i++)
            {
                // Forming the string with 0s and 1s using a string constructor
                string rowString = new string((i % 2 == 0) ? '0' : '1', i);

                Console.WriteLine(rowString);
            }
            Console.WriteLine("---------------------Output--------------------------");
            /*
            1
            01
            101
            0101
            10101
            */
        }
        public void Pattern12(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                // Print the increasing sequence
                Console.Write(string.Join("", Enumerable.Range(1, i)));

                // Print spaces between the two sequences
                Console.Write(new string(' ', 2 * (n - i)));

                // Print the decreasing sequence
                Console.WriteLine(string.Join("", Enumerable.Range(1, i).Reverse()));
            }
            Console.WriteLine("---------------------Output--------------------------");
            //1        1
            //12      21
            //12     321
            //1234  4321
            //1234554321
        }
        public void Pattern13(int n)
        {
            int currenNumber = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(string.Join("  ", Enumerable.Range(currenNumber, i)));
                currenNumber += i;
            }
            Console.WriteLine("---------------------Output--------------------------");
            //1
            //2  3
            //4  5  6
            //7  8  9  10
            //11  12  13  14  15
            //16  17  18  19  20  21
        }
        public void Pattern14(int n)
        {
            char ch = 'A';

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", Enumerable.Range(0, i + 1).Select(_ => ch++)));
            }
            Console.WriteLine("---------------------Output--------------------------");
            //A
            //A B
            //A B C
            //A B C D
            //A B C D E
            //A B C D E F
        }
        public void Pattern15(int n)
        {
            for (int i = n; i > 0; i--)
            {
                char ch = 'A';
                Console.WriteLine(string.Join(" ", Enumerable.Range(0, i).Select(_ => ch++)));
            }

            Console.WriteLine("---------------------Output--------------------------");
            //A B C D E
            //A B C D
            //A B C
            //A B
            //A
        }
        public void Pattern16(int n)
        {
            char ch = 'A';

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", Enumerable.Range(0, i + 1).Select(_ => ch)));
                ch++;
            }


            Console.WriteLine("---------------------Output--------------------------");
            //A
            //B B
            //C C C
            //D D D D
            //E E E E E

        }
        public void Pattern20(int n)//Wrong Output
        {
            for (int i = -n + 1; i < n; i++)
            {
                int spaces = Math.Abs(i);
                int asterisks = 2 * (n - spaces) - 1;

                Console.Write(new string(' ', spaces));

                Console.WriteLine(new string('*', asterisks));
            }
            Console.WriteLine("---------------------Output--------------------------");
            //*    *
            //**  **
            //******
            //**  **
            //*    *
        }
        public void Pattern21(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.WriteLine(new string('*', n));
                }
                else
                {
                    Console.WriteLine("*" + new string(' ', n - 2) + "*");
                }
            }
            Console.WriteLine("---------------------Output--------------------------");

            //*****
            //*   *
            //*   *
            //*   *
            //*****
        }
    }
}
