using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
     static List<string> GetEmployees()
    {
      // creates new list of employees
      List<string> employees = new List<string>();
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
        // add employee (userInput) to employees List
        employees.Add(input);
      }
      return employees;
    }
    static void PrintEmployees(List<string> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        Console.WriteLine(employees[i]);
      }
    }
    static void Main(string[] args) // entry point
    {
      // This is our employee-getting code now
      List<string> employees = GetEmployees();
      PrintEmployees(employees);
    }
  }
}