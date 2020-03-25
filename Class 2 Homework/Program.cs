using System;

namespace Class_2_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 
            //RealCalculator

            Console.WriteLine("Enter the first number:");
            string num1 = Console.ReadLine();
            int cno1 = 0;
            bool convertedNum1 = int.TryParse(num1, out cno1);
            Console.WriteLine("Enter the second number:");
            string num2 = Console.ReadLine();
            int cno2 = 0;
            bool convertedNum2 = int.TryParse(num2, out cno2);
            Console.WriteLine("Enter the required operation:");
            string operation = Console.ReadLine();
            char convertedoperation = '0';
            bool checkoperation = char.TryParse(operation, out convertedoperation);
            if (convertedNum1 && convertedNum2 && checkoperation)
            {
                if (convertedoperation == '+')
                {
                    Console.WriteLine(cno1 + cno2);
                }
                if (convertedoperation == '-')
                {
                    Console.WriteLine(cno1 - cno2);
                }
                if (convertedoperation == '*')
                {
                    Console.WriteLine(cno1 * cno2);
                }
                if (convertedoperation == '/')
                {
                    Console.WriteLine(cno1 / cno2);
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
            #endregion


            #region Task 2 
            ////AverageNumber

            Console.WriteLine("Enter the first number:");
            string no1 = Console.ReadLine();
            int input1 = 0;
            bool convNo1 = int.TryParse(no1, out input1);
            Console.WriteLine("Enter the second number:");
            string no2 = Console.ReadLine();
            int input2 = 0;
            bool convNo2 = int.TryParse(no2, out input2);
            Console.WriteLine("Enter the third number:");
            string no3 = Console.ReadLine();
            int input3 = 0;
            bool convNo3 = int.TryParse(no3, out input3);
            Console.WriteLine("Enter the fourth number:");
            string no4 = Console.ReadLine();
            int input4 = 0;
            bool convNo4 = int.TryParse(no4, out input4);
            if (convNo1 && convNo2 && convNo3 && convNo4)
            {
                double result = ((input1 + input2 + input3 + input4) / 4);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error!");
            }

            #endregion

            #region Task 3
            // SwapNumbers

            Console.WriteLine("Enter the first number:");
            string firstNum = Console.ReadLine();
            int cnvFn = 0;
            bool swapping1 = int.TryParse(firstNum, out cnvFn);
            Console.WriteLine("Enter the second number:");
            string secondNum = Console.ReadLine();
            int cnvSn = 0;
            bool swapping2 = int.TryParse(secondNum, out cnvSn);
            if(swapping1 && swapping2)
            {
                int swaped1 = cnvSn;
                int swaped2 = cnvFn;
                Console.WriteLine("The first number now is" + " " + swaped1 + ", and the second number is now" + " " + swaped2);
            }
            else
            {
                Console.WriteLine("Error!");
            }


            #endregion


        }
    }
}
