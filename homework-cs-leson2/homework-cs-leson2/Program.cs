using System;

namespace homework_cs_leson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 55, 6, 33 };
            Task9(arr);
        }

        #region Task 1
        //1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
        public static void Task1(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine($"{n} divided into 3 and 7");
            }
            else
            {
                Console.WriteLine($"{n} is not divided into 3 and 7");
            }
        }

        #endregion

        #region Task 2

        //2) n və m ədədləri verilir.Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

        //first edit of task2:

        //public static void Task2(int n, int m)
        //{
        //    int count = 0;

        //    if (n % 2 == 0)
        //    {
        //        if (m % 2 == 0)
        //        {
        //            count = n + m;
        //            Console.WriteLine(count);
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{m} is not even number");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{n} is not even number");
        //    }

        public static void Task2(int n, int m)
        {
            int count = 0;

            if (n % 2 == 0)
            {
                
            }
            else
            {
                Console.WriteLine($"{n} is not even number");
                return;
            }

            if (m % 2 == 0)
            {
                count = n + m;
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine($"{m} is not even number");
            }
        }
        #endregion

        #region Task 3

        //3) Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin sayini tapin.

        public static void Task3(int n, int m)
        {
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        #endregion

        #region Task 4  

        //4) Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin cemini tapin.
        public static void Task4(int n, int m)
        {
            int sum = 0;

            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 1)
                {
                    sum=sum+i;
                }
            }
            Console.WriteLine(sum);
        }

        #endregion

        #region Task 5
 
        //5)Verilmish arrayin icindeki tek ededlerin cemini tapin.

        public static int Task5(int[] arr)
        {
            Console.WriteLine("5)Verilmish arrayin icindeki tek ededlerin cemini tapin");

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr [i] % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        #endregion

        #region Task 6

        //6)Verilmish arrayin icindeki cut ededlerin sayini tapin.

        public static int Task6(int [] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                   count++;
                }
            }
            return count;
        }
        #endregion

        #region Task 7

        //7) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

        public static string Task7(int n)
        {
            string result1 = $"{n} is simple number";
            string result2 = $"{n} is complex number";
            if (n % 2 == 0 && n % 3 == 0 && n % 5 == 0 && n % 7 == 0)
            {
                return result2;
            }

            else
            {
                return result1;
            }
        }
        #endregion

        //n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.Meselen: Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.

        #region Task9
        //9)Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes([1,3,55,6,33], cavab : 18).

        public static void Task9(int[] arr)
        {
            int mult = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < 20)
                {
                    mult = mult * arr[i];
                }
            }
            Console.WriteLine(mult);
        }

        #endregion


        //10)Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.
         
        public static void Task10(int[] arr)
        {
            int sum = 0;
            int mult = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    mult = sum * i;
                }
                Console.WriteLine(mult);
            }
        }

    }
}