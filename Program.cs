using System;

namespace Deliverable_2___Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string letterGrade = "";
            
            Console.WriteLine("What total score out of 100 do you expect to get in ISM 4300? (Enter integer value, not %)");
            int expectedScore = Int32.Parse(Console.ReadLine());

            if (expectedScore >= 98 && expectedScore <= 100)
            {
                letterGrade = "A+";
            }
            else if (expectedScore >= 92 && expectedScore <= 97)
            {
                letterGrade = "A";
            }
            else if (expectedScore >= 90 && expectedScore <= 91)
            {
                letterGrade = "A-";
            }
            else if (expectedScore >= 88 && expectedScore <= 89)
            {
                letterGrade = "B+";
            }
            else if (expectedScore >= 82 && expectedScore <= 87)
            {
                letterGrade = "B";
            }
            else if (expectedScore >= 80 && expectedScore <= 81)
            {
                letterGrade = "B-";
            }
            else if (expectedScore >= 78 && expectedScore <= 79)
            {
                letterGrade = "C+";
            }
            else if (expectedScore >= 72 && expectedScore <= 77)
            {
                letterGrade = "C";
            }
            else if (expectedScore >= 70 && expectedScore <= 71)
            {
                letterGrade = "C-";
            }
            else if (expectedScore >= 68 && expectedScore <= 69)
            {
                letterGrade = "D+";
            }
            else if (expectedScore >= 62 && expectedScore <= 67)
            {
                letterGrade = "D";
            }
            else if (expectedScore >= 60 && expectedScore <= 61)
            {
                letterGrade = "D-";
            }
            else if (expectedScore <= 60)
            {
                letterGrade = "F";
            }
            else
            {
                Console.WriteLine("Error in user input");
            }

            Console.WriteLine("Your expected letter grade in this class is a " + letterGrade);
        }
    }
}
