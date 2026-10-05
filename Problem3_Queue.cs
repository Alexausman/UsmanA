using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Program
{
    static void Main()
    {
        Queue<StudentRequest> requests =
            new Queue<StudentRequest>();

        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("==============================");
            Console.WriteLine("    STUDENT REQUEST QUEUE");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                StudentRequest r;

                Console.Write("Enter Student Number: ");
                r.StudentNumber = Console.ReadLine();

                Console.Write("Enter Student Name: ");
                r.StudentName = Console.ReadLine();

                Console.Write("Enter Request Type: ");
                r.RequestType = Console.ReadLine();

                requests.Enqueue(r);

                Console.WriteLine("Request added!");
            }

            else if (choice == "2")
            {
                if (requests.Count == 0)
                {
                    Console.WriteLine("No pending requests.");
                }
                else
                {
                    Console.WriteLine("PENDING REQUESTS");

                    int number = 1;

                    foreach (StudentRequest r in requests)
                    {
                        Console.WriteLine(
                            number + ". " +
                            r.StudentName + " - " +
                            r.RequestType);

                        number++;
                    }
                }
            }

            else if (choice == "3")
            {
                if (requests.Count == 0)
                {
                    Console.WriteLine("No requests to process.");
                }
                else
                {
                    StudentRequest r = requests.Dequeue();

                    Console.WriteLine("Processing Request...");
                    Console.WriteLine("Student: " + r.StudentName);
                    Console.WriteLine("Request: " + r.RequestType);
                    Console.WriteLine("Request processed!");
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

