using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                int[] numbers = new int[6];
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Please enter a number");
                    string inputNum = Console.ReadLine();
                    int nums;
                    bool parseNums = int.TryParse(inputNum, out nums);
                    if (parseNums)
                    {
                        numbers[i] = nums;
                        if (numbers[i] % 2 == 0)
                        {
                            sum += numbers[i];
                        }
                    }
                    else
                    {
                        if (!parseNums)
                        {
                            Console.WriteLine("You didn't enter a real number. Please enter a real number!");
                            break;
                        }
                    }
                }
                Console.WriteLine("The sum of the even numbers in the array is: " + sum);
                Console.ReadLine();



            }
            
            
            
            

            




        }
    }
}
