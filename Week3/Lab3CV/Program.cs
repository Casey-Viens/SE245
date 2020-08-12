//Casey Viens
//Lab3~~~x number of students with 5 grades each, calculate average and letter grade for each student and average for each lab across all students.
//Additionally, this lab makes use of functions to complete some of its tasks
//Referencing Libraries
using System;
using System.Collections.Generic;

namespace Lab3CV
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
        static void Pause()
        {
            //pauses for the user to read the info
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }
        static void DisplayfromList(List<Student> students)
        {
            //Prints each students name, lettergrade,average and lab grades
            foreach (Student p in students)
            {
                Console.WriteLine($"\nStudent {p.name} earned a(n) {p.lettergrade} with an average of {p.average} with the grades {p.labs[0]}, {p.labs[1]}, {p.labs[2]}, {p.labs[3]}, and {p.labs[4]}.");
            }
        }

        static List<double> AvgCalc(List<Student> students)
        {
            Double lab1total = 0, lab2total = 0, lab3total = 0, lab4total = 0, lab5total = 0;
            List<double> labAverages = new List<double>();
            foreach (Student p in students)
            {
                //creates a total for each #lab grade as the program loops through every student
                lab1total += p.labs[0];
                lab2total += p.labs[1];
                lab3total += p.labs[2];
                lab4total += p.labs[3];
                lab5total += p.labs[4];
            }
            //calculates the average for each #lab and appends the data to the list
            labAverages.Add(lab1total / students.Count);
            labAverages.Add(lab2total / students.Count);
            labAverages.Add(lab3total / students.Count);
            labAverages.Add(lab4total / students.Count);
            labAverages.Add(lab5total / students.Count);
            //Returns the list of averages for each #lab to the main program
            return labAverages;
        }

        static void StoreToTheList(Student p, double grade, ref double totalgrade)
        {
            //stores the grade to the lab list and tallies the total for the students total grade
            p.labs.Add(grade);
            totalgrade += grade;
        }

        static bool IsValidDouble(String grades)
        {
            //creates a boolean for if the data the user entered can be a double or not
            return Double.TryParse(grades, out _);
        }
        static void Main(string[] args)
        {

            //Creating a list for the student structure
            List<Student> students = new List<Student>();
            String name;
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
                    Double totalgrade = 0;
                    //loop to ask the user for each lab grade
                    for (int i = 1; i <= 5; i++)
                    {
                        Double grade;
                        //forces the user to only enter a valid grade for the student
                        while (true)
                        {
                            Console.Write($"Please enter {name}'s Lab{i} grade: ");
                            String grades = Console.ReadLine();
                            if (IsValidDouble(grades))
                            {
                                grade = Convert.ToDouble(grades);
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"\n\nSorry, but you did not enter a valid Lab{i} grade for {name}, please try again");
                            }
                        }
                        StoreToTheList(p, grade, ref totalgrade);
                    }
                    //Calculates the student's average grade
                    Double gradeaverage;
                    gradeaverage = totalgrade / 5;
                    p.average = gradeaverage;
                    //Uses the student's average grade to find their letter grade
                    String letter;
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
            DisplayfromList(students);
            List<double> labAverages = new List<double>();
            labAverages = AvgCalc(students);
            //prints the average for each #lab
            Console.WriteLine($"\n\nThe lab averages are, \nLab 1: {labAverages[0]} \nLab 2: {labAverages[1]} \nLab 3: {labAverages[2]} \nLab 4: {labAverages[3]} \nLab 5: {labAverages[4]}");
            Pause();
        }
    }
}
