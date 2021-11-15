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
        string input = Console.ReadLine();
        if (input == "")
        {
          // Break if the user hits ENTER without typing a name
          break;
        }
        // Create a new employee instance
        Employee currentEmployee = new Employee(input, "McFadden");
        // add employee (userInput) to employees List
        employees.Add(currentEmployee);
      }
      return employees;
    }
    static void PrintEmployees(List<Employee> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        Console.WriteLine(employees[i].GetName());
      }
    }
    static void Main(string[] args) // entry point
    {
      // This is our employee-getting code now
      List<Employee> employees = GetEmployees();
      PrintEmployees(employees);
    }
  }
}