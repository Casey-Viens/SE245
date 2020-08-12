// Casey Viens
// 7/25/2020
// This program accepts info from user then calculates a letter and average grade to print to the user
using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, grade1s, grade2s, grade3s, grade4s, lettergrade;
            Double grade1, grade2, grade3, grade4, totalgrade;

            Console.WriteLine("Welcome to the Grade Average Program.");
            // Gathers info from the user for the Students name and grades
            Console.Write("Please enter the students name: ");
            name = Console.ReadLine();
            Console.Write("Please enter the first grade: ");
            grade1s = Console.ReadLine();
            Console.Write("Please enter the second grade: ");
            grade2s = Console.ReadLine();
            Console.Write("Please enter the third grade: ");
            grade3s = Console.ReadLine();
            Console.Write("Please enter the fourth grade: ");
            grade4s = Console.ReadLine();
            // Converts the grades from strings to doubles
            grade1 = Convert.ToDouble(grade1s);
            grade2 = Convert.ToDouble(grade2s);
            grade3 = Convert.ToDouble(grade3s);
            grade4 = Convert.ToDouble(grade4s);
            // Calculates the total grade average with weighting
            totalgrade = (grade1 * .2) + (grade2 * .2) + (grade3 * .25) + (grade4 * .35);
            // Finds the letter grade based off the total grade
            if(totalgrade >= 100)
            {
                lettergrade = "A+";
            }
            else if(totalgrade >= 94)
            {
                lettergrade = "A";
            }
            else if(totalgrade >= 90)
            {
                lettergrade = "A-";
            }
            else if(totalgrade >= 87)
            {
                lettergrade = "B+";
            }
            else if(totalgrade >= 83)
            {
                lettergrade = "B";
            }
            else if(totalgrade >= 80)
            {
                lettergrade = "B-";
            }
            else if(totalgrade >= 77)
            {
                lettergrade = "C+";
            }
            else if(totalgrade >= 73)
            {
                lettergrade = "C";
            }
            else if(totalgrade >= 70)
            {
                lettergrade = "C-";
            }
            else if(totalgrade >= 67)
            {
                lettergrade = "D+";
            }
            else if(totalgrade >= 63)
            {
                lettergrade = "D";
            }
            else if(totalgrade >= 60)
            {
                lettergrade = "D-";
            }
            else
            {
                lettergrade = "F";
            }
            // Print response to user with all info from program
            Console.WriteLine($"\n\n{name} achieved a(n) {lettergrade} with an average of {totalgrade}% after getting the grades {grade1s}, {grade2s}, {grade3s}, {grade4s}.");
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }
    }
}
