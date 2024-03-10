using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepositoryPattern.BL;
using TestRepositoryPattern.DA;

namespace TestRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksBusiness BooksBusiness = new BooksBusiness(new BooksRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Books> _listBooks = BooksBusiness.Get();
                        Console.WriteLine("List of Books:");
                        Console.WriteLine("ID   |   Name  ");
                        foreach (Books _Books in _listBooks)
                        {
                            Console.WriteLine(_Books.BookId + "  |   " + _Books.BookName + "  |   " );
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a customer:");
                        string id = Console.ReadLine();
                        Books aBooks = BooksBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aBooks.BookId + ". " + aBooks.BookName  );
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Books aBooks = new Books();
                        aBooks.BookId = Convert.ToInt32(id);
                        aBooks.BookName = name;
                        
                        bool isExecuted = BooksBusiness.Add(aBooks);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Books aBooks = new Books();
                        aBooks.BookId = Convert.ToInt32(id);
                        aBooks.BookName = name;
                       
                        bool isExecuted = BooksBusiness.Update(aBooks);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = BooksBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            //Console.Read();
        }
    }
}
