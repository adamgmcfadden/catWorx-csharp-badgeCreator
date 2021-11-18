using System;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker {
    class PeopleFetcher
    {
        public static List<Employee> GetEmployees()
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
        
        public static List<Employee> GetFromApi() {
            List<Employee> employees = new List<Employee>();

            using (WebClient client = new WebClient())
            {
                // Image example
                string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");

                JObject json = JObject.Parse(response);

                foreach (JToken token in json.SelectToken("results")) {
                    // Parse JSON data
                    Employee emp = new Employee
                    (
                        token.SelectToken("name.first").ToString(),
                        token.SelectToken("name.last").ToString(),
                        Int32.Parse(token.SelectToken("id.value").ToString().Replace("-", "")),
                        token.SelectToken("picture.large").ToString()
                    );
                    employees.Add(emp);
                }
            }
            return employees;
        }
    }
}