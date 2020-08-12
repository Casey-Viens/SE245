//Casey Viens
//Lab2~~~x number of students with 5 grades each, calculate average and letter grade for each student and average for each lab across all students.
//Referencing Libraries
using System;
using System.Collections.Generic;

namespace Lab2CV
{
    class Program
    {
        //Creating a structure for each student
        public struct Student
        {
            public string name;
            public List<double> labs;
            public string lettergrade;
            public double average;
        }
        static void Main(string[] args)
        {
            //Variable intialization
            String name, grades, letter;
            Double grade, totalgrade = 0, gradeaverage, lab1total = 0, lab2total = 0, lab3total = 0, lab4total = 0, lab5total = 0, lab1average, lab2average, lab3average, lab4average, lab5average;
            //Creating a list for the student structure
            List<Student> students = new List<Student>();
            //A do while loop to allow the user to enter as many students as they want
            do
            {
                Console.Write("Please enter the students name, or a 0 if you are done.");
                name = Console.ReadLine();
                //Only adds data to variables/structures if user is inputing a student
                if (name != "0")
                {
                    Student p = new Student();
                    p.labs = new List<double>();
                    p.name = name;
                    //refreshes the totalgrade variable used to calculate each studetns grade average
                    totalgrade = 0;
                    //loop to ask the user for each lab grade
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.Write($"Please enter {name}'s Lab{i} grade: ");
                        grades = Console.ReadLine();
                        grade = Convert.ToDouble(grades);
                        p.labs.Add(grade);
                        totalgrade += grade;
                    }
                    //Calculates the student's average grade
                    gradeaverage = totalgrade / 5;
                    p.average = gradeaverage;
                    //Uses the student's average grade to find their letter grade
                    if (gradeaverage >= 100)
                    {
                        letter = "A+";
                    }
                    else if (gradeaverage >= 94)
                    {
                        letter = "A";
                    }
                    else if (gradeaverage >= 90)
                    {
                        letter = "A-";
                    }
                    else if (gradeaverage >= 87)
                    {
                        letter = "B+";
                    }
                    else if (gradeaverage >= 83)
                    {
                        letter = "B";
                    }
                    else if (gradeaverage >= 80)
                    {
                        letter = "B-";
                    }
                    else if (gradeaverage >= 77)
                    {
                        letter = "C+";
                    }
                    else if (gradeaverage >= 73)
                    {
                        letter = "C";
                    }
                    else if (gradeaverage >= 70)
                    {
                        letter = "C-";
                    }
                    else if (gradeaverage >= 67)
                    {
                        letter = "D+";
                    }
                    else if (gradeaverage >= 63)
                    {
                        letter = "D";
                    }
                    else if (gradeaverage >= 60)
                    {
                        letter = "D-";
                    }
                    else
                    {
                        letter = "F";
                    }
                    p.lettergrade = letter;
                    //Adds the data in the Student structure to the students lists
                    students.Add(p);
                }
            } while (name != "0");
            //references each student in the students list and prints their data
            foreach (Student p in students)
            {
                Console.WriteLine($"\nStudent {p.name} earned a(n) {p.lettergrade} with an average of {p.average} with the grades {p.labs[0]}, {p.labs[1]}, {p.labs[2]}, {p.labs[3]}, and {p.labs[4]}.");
                //creates a total for each #lab grade as the program loops through every student
                lab1total += p.labs[0];
                lab2total += p.labs[1];
                lab3total += p.labs[2];
                lab4total += p.labs[3];
                lab5total += p.labs[4];
            }
            //calculates the average for each #lab
            lab1average = lab1total / students.Count;
            lab2average = lab2total / students.Count;
            lab3average = lab3total / students.Count;
            lab4average = lab4total / students.Count;
            lab5average = lab5total / students.Count;
            //prints the average for each #lab
            Console.WriteLine($"\n\nThe lab averages are, \nLab 1: {lab1average} \nLab 2: {lab2average} \nLab 3: {lab3average} \nLab 4: {lab4average} \nLab 5: {lab5average}");
            //pauses for the user to read the info
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
    }
}
