using System;
using System.Collections.Generic;

struct Operation
{
    public string Action;
    public string StudentNumber;
    public string StudentName;
}

class Program
{
    static void Main()
    {
        Stack<Operation> operationHistory = new Stack<Operation>();

        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("==============================");
            Console.WriteLine("     OPERATION HISTORY");
            Console.WriteLine("==============================");
            Console.WriteLine("1. View History");
            Console.WriteLine("2. View Last Operation");
            Console.WriteLine("3. Remove Last Operation");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No operations found.");
                }
                else
                {
                    int number = 1;

                    foreach (Operation op in operationHistory)
                    {
                        Console.WriteLine(
                            number + ". " +
                            op.Action + " - " +
                            op.StudentName);

                        number++;
                    }
                }
            }

            else if (choice == "2")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No operations found.");
                }
                else
                {
                    Operation op = operationHistory.Peek();

                    Console.WriteLine("Last Operation:");
                    Console.WriteLine("Action: " + op.Action);
                    Console.WriteLine("Student: " + op.StudentName);
                }
            }

            else if (choice == "3")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No operations found.");
                }
                else
                {
                    operationHistory.Pop();

                    Console.WriteLine("Last operation removed!");
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

