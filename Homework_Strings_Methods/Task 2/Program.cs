using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please enter a sentence!");
                string sentenceString = Console.ReadLine();
                Console.WriteLine("Now, please enter any character!");
                string character = Console.ReadLine();
                char ch = '0';
                bool chParsed = char.TryParse(character, out ch);
                int k = sentenceString.Length;
                char[] sentenceCharacters = sentenceString.ToCharArray();
                int count = 0;
                if (chParsed)
                {
                    foreach (char c in sentenceCharacters)
                    {
                        if (c == ch)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"The character that you entered appears: {count} times.");
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
                Console.ReadLine();
                
                
                


            }
            
        }
    }
}
