using System;

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
        Student[] students = new Student[10];
        int count = 0;
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("==============================");
	    Console.WriteLine("   STUDENT RECORD SYSTEM");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");

            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                if (count < 10)
                {
                    Console.Write("Enter Student Number: ");
                    students[count].StudentNumber = Console.ReadLine();

                    Console.Write("Enter Name: ");
                    students[count].Name = Console.ReadLine();

                    Console.Write("Enter Program: ");
                    students[count].Program = Console.ReadLine();

                    Console.Write("Enter Year Level: ");
                    students[count].YearLevel = int.Parse(Console.ReadLine());

                    count++;

                    Console.WriteLine("Student added!");
                }
                else
                {
                    Console.WriteLine("The student list is full.");
                }
            }

            else if (choice == "2")
            {
                if (count == 0)
                {
                    Console.WriteLine("No students found.");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Student Number: " + students[i].StudentNumber);
                        Console.WriteLine("Name: " + students[i].Name);
                        Console.WriteLine("Program: " + students[i].Program);
                        Console.WriteLine("Year Level: " + students[i].YearLevel);
                    }
                }
            }

            else if (choice == "3")
            {
                Console.Write("Enter Student Number: ");
                string number = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Student Found!");
                        Console.WriteLine("Student Number: " + students[i].StudentNumber);
                        Console.WriteLine("Name: " + students[i].Name);
                        Console.WriteLine("Program: " + students[i].Program);
                        Console.WriteLine("Year Level: " + students[i].YearLevel);

                        found = true;
                    }
                }

                if (found == false)
                {
                    Console.WriteLine("Student not found.");
                }
            }

            else if (choice == "4")
            {
                Console.Write("Enter Student Number: ");
                string number = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < count; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        Console.Write("Enter New Name: ");
                        students[i].Name = Console.ReadLine();

                        Console.Write("Enter New Program: ");
                        students[i].Program = Console.ReadLine();

                        Console.Write("Enter New Year Level: ");
                        students[i].YearLevel = int.Parse(Console.ReadLine());

                        Console.WriteLine("Student updated!");

                        found = true;
                    }
                }

                if (found == false)
                {
                    Console.WriteLine("Student not found.");
                }
            }

            else if (choice == "5")
            {
                Console.Write("Enter Student Number: ");
                string number = Console.ReadLine();

                int position = -1;

                for (int i = 0; i < count; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        position = i;
                    }
                }

                if (position != -1)
                {
                    for (int i = position; i < count - 1; i++)
                    {
                        students[i] = students[i + 1];
                    }

                    count--;

                    Console.WriteLine("Student deleted!");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }

            else if (choice == "6")
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
