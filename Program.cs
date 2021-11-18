using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
   static void Main(string[] args)
    {
      Console.WriteLine("Would you like to fetch employees from an API or manually add them? Answer: API or ADD");
      string answer = Console.ReadLine();
      if (answer == "API" || answer == "api") {
        List<Employee> employees = new List<Employee>();
          employees = PeopleFetcher.GetFromApi();
           Util.MakeCSV(employees);
           Util.MakeBadges(employees);
      } else if (answer == "ADD" || answer == "add") {
          List<Employee> employees = new List<Employee>();
          employees = PeopleFetcher.GetEmployees();
          Util.MakeCSV(employees);
          Util.MakeBadges(employees);
      } else {
        Console.WriteLine("Wrong input, try again");
      }    
    }
  }
}