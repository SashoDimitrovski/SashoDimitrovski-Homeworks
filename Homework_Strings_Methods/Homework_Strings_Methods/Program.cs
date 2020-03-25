using System;

namespace Homework_Strings_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            while (true)
            {
                string greeting = "Hello from SEDC Codecademy v7.0";
                int stringLength = greeting.Length;
                Console.WriteLine($"Please enter a number between 1 and {stringLength}");
                string userInput = Console.ReadLine();
                int n = 0;
                bool parsedNum = int.TryParse(userInput, out n);

                if (parsedNum)
                {
                    if (!(n > 1 && n < greeting.Length))
                    {
                        Console.WriteLine($"You must enter a number between 1 and {stringLength} ");
                    }
                    else
                    {
                        string subString = greeting.Substring(0, n);

                        Console.WriteLine(subString);
                        Console.WriteLine(stringLength);
                    }
                    Console.WriteLine(@"Press ""y"" to try again, otherwise, press any other key.");
                    string tryAgain = Console.ReadLine();
                    if (tryAgain.ToLower() == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Good bye!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You must enter a number");
                }
                continue;
            }
            Console.ReadLine();


            #endregion

        }

    }
}
