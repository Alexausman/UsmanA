using System;
using System.Collections.Generic;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Dictionary<string, Student> students =
            new Dictionary<string, Student>();

        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("==============================");
            Console.WriteLine("  STUDENT LOOKUP SYSTEM");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display Students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                Console.Write("Enter Student Number: ");
                string number = Console.ReadLine();

                if (students.ContainsKey(number))
                {
                    Console.WriteLine("Student number already exists.");
                }
                else
                {
                    Student s;

                    s.StudentNumber = number;

                    Console.Write("Enter Name: ");
                    s.Name = Console.ReadLine();

                    Console.Write("Enter Program: ");
                    s.Program = Console.ReadLine();

                    Console.Write("Enter Year Level: ");
                    s.YearLevel = int.Parse(Console.ReadLine());

                    students.Add(number, s);

                    Console.WriteLine("Student added!");
                }
            }

            else if (choice == "2")
            {
                Console.Write("Enter Student Number: ");
                string number = Console.ReadLine();

                if (students.ContainsKey(number))
                {
                    Student s = students[number];

                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Student Found!");
                    Console.WriteLine("Student Number: " + s.StudentNumber);
                    Console.WriteLine("Name: " + s.Name);
                    Console.WriteLine("Program: " + s.Program);
                    Console.WriteLine("Year Level: " + s.YearLevel);
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }

            else if (choice == "3")
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students found.");
                }
                else
                {
                    foreach (Student s in students.Values)
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Student Number: " + s.StudentNumber);
                        Console.WriteLine("Name: " + s.Name);
                        Console.WriteLine("Program: " + s.Program);
                        Console.WriteLine("Year Level: " + s.YearLevel);
                    }
                }
            }

            else if (choice == "4")
            {
                Console.WriteLine("Program ended.");
            }

            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine();
        }
    }
}


