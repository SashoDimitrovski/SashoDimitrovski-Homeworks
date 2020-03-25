using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] studentsG1 = { "Ivan", "Bojan", "Goran", "Saso", "Petar" };
                string[] studentsG2 = { "Vesna", "Marija", "Tanja", "Donka", "Ivana" };
                Console.WriteLine("Please enter 1 or 2 to select a group!");
                string input1or2 = Console.ReadLine();
                int user1or2 = 0;
                bool parseNumbers = int.TryParse(input1or2, out user1or2);
                if (parseNumbers)
                {

                    if (user1or2 == 1)
                    {
                        Console.WriteLine("The students in this group are: ");
                        foreach (var n in studentsG1)
                        {

                            Console.WriteLine(n);
                        }

                                        }
                    else
                    {
                        if (user1or2 == 2)
                        {
                            Console.WriteLine("The students in this group are: ");
                            foreach (var n in studentsG2)
                            {
                                Console.WriteLine(n);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2!");
                        }

                    }


                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("I said, enter 1 or 2!");
                }
            }
        }
    }
}
