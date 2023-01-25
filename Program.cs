using System;

namespace deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300:");

            try
            {

            decimal grade = decimal.Parse(Console.ReadLine());

            string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your grade is " + letter);

                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("your grade is " + letter);
                }

                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your grade is " + letter);
                }

                else if (grade >= 60 && grade < 70)
                {

                    letter = "D";
                    Console.WriteLine("your grade is " + letter);

                }

                else if (grade >= 50 && grade < 60)
                {

                    letter = "F";
                    Console.WriteLine("your grade is " + letter);

                }
            }
            catch
            {
                Console.WriteLine("Enter another number");

            }
        }
    }
}
                