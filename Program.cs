using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
     static List<Employee> GetEmployees()
    {
      // creates new list of employees
      List<Employee> employees = new List<Employee>();
      // Collects user values until the value is an empty string
      while (true)
      {
        Console.WriteLine("Please enter a name: (leave empty to exit)");
         // ask user for input
        string firstName = Console.ReadLine();
        if (firstName == "")
        {
          // Break if the user hits ENTER without typing a name
          break;
        }

        // add a Console.readline for each value
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter employee ID: ");
        int id = Int32.Parse(Console.ReadLine());

        Console.Write("Enter photo URL: ");
        string photoUrl = Console.ReadLine();
        // Create a new employee instance
        Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
        // add employee (userInput) to employees List
        employees.Add(currentEmployee);
      }
      return employees;
    }
    static void Main(string[] args) // entry point
    {
      // This is our employee-getting code now
      List<Employee> employees = GetEmployees();
      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
    }
  }
}