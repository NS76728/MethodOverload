using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
             int sum = num1 + num2;
            return sum;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            decimal sum = num1 + num2;
            return sum;
        }
        public static string Add(int num1, int num2, bool isEqual)
        {
            if (isEqual==true)
            {
                int sum = num1 + num2;
                if(sum==1)
                {
                    return sum + " dollar";
                }
                else
                {
                    return sum + " dollars";
                }
            }
            else
            {
                int sum = num1 + num2;
                return +sum+"";
            }
        }


        static void Main(string[] args)
        {
            
           bool isEqual = true;

           int num1 = 5;
           int num2 = 2;

           decimal decNum = 0.5m;
           decimal decNum2 = 0.5m;


            Console.WriteLine(Add(num1, num2));


            Console.WriteLine(Add(decNum, decNum2));


           Console.WriteLine(Add(num1, num2, isEqual));





        }
    }
}
