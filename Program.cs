using System;
using System.IO;

namespace Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";
            string choice;
            do
            {
                // ask user a question
                Console.WriteLine("1) Read data from file.");
                Console.WriteLine("2) Create file from data.");
                Console.WriteLine("Enter anything else to quit");
                
                // input response
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // read data from file
                    if (File.Exists(file))
                    {
                        // read data from file
                        StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                                       //convert file to an array
                            string line = sr.ReadLine();
                            string[] arr = line.Split(',');

                            Console.WriteLine("TicketID: {0}, Summary: {1}, Status: {2}, Priority: {3}, Submitter: {4}, Assigned: {5}, Watching: {6}", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);        
                        }
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                }
                else if (choice == "2")
                {
                    // create file from data
                    StreamWriter sw = new StreamWriter(file);
                    for (int i = 0; i < 1; i++)
                    {
                        
                        Console.WriteLine("Enter the Ticket ID");
                        string TicketId = Console.ReadLine();
                        Console.WriteLine("Enter a Summary");
                        string Summary = Console.ReadLine();
                        Console.WriteLine("Enter the Status");
                        string Status = Console.ReadLine();
                        Console.WriteLine("Enter the Prioirty");
                        string Prioirty = Console.ReadLine();
                        Console.WriteLine("Enter the Submitter");
                        string Submitter = Console.ReadLine();
                        Console.WriteLine("Enter the Assigner");
                        string Assigner = Console.ReadLine();
                        Console.WriteLine("Enter who is Watching");
                        string Watching = Console.ReadLine();
                
                        sw.WriteLine("{0}|{1}", TicketId, Summary, Status, Prioirty, Submitter, Assigner, Watching);

                    
                    }
                    
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");
        }
    }
}