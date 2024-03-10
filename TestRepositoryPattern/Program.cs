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
            CourseManagement ac = new CourseManagement(new CourseRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, " +
                        "'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Course> _listCourse = ac.Get();
                        Console.WriteLine("List of courses:");
                        Console.WriteLine("ID   |   Name    |   Trainer");
                        foreach (Course _courses in _listCourse)
                        {
                            Console.WriteLine(_courses.Id + "  |   " + _courses.Name + "  |   " + _courses.Trainer);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a course:");
                        string id = Console.ReadLine();
                        Course acourse= ac.Get(Convert.ToInt32(id));
                        Console.WriteLine(acourse.Id + ". " + acourse.Name + " -- " + acourse.Trainer);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a Coursename:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a Trainer:");
                        string trainer = Console.ReadLine();
                        Course ss = new Course();
                        ss.Id = Convert.ToInt32(id);
                        ss.Name = name;
                        ss.Trainer = trainer;
                        bool isExecuted = ac.Add(ss);
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
                        Console.WriteLine("Input a course name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a trainer:");
                        string trainer = Console.ReadLine();
                        Course astu = new Course();
                        astu.Id = Convert.ToInt32(id);
                        astu.Name = name;
                        astu.Trainer = trainer;
                        bool isExecuted =ac.Update(astu);
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
                        bool isExecuted =ac.Delete(Convert.ToInt32(id));
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
