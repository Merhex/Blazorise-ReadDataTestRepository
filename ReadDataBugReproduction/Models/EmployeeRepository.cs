using Blazorise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadDataBugReproduction.Models
{
    public static class EmployeeRepository
    {
        private static List<Employee> Employees =>
            new List<Employee>
            {
                        new Employee { Name = "Employee 1" },
                        new Employee { Name = "Employee 2" },
                        new Employee { Name = "Employee 3" },
                        new Employee { Name = "Employee 4" },
                        new Employee { Name = "Employee 5" },
                        new Employee { Name = "Employee 6" },
                        new Employee { Name = "Employee 7" },
                        new Employee { Name = "Employee 8" },
                        new Employee { Name = "Employee 9" },
                        new Employee { Name = "Employee 10" },
                        new Employee { Name = "Employee 11" },
                        new Employee { Name = "Employee 12" },
                        new Employee { Name = "Employee 13" },
                        new Employee { Name = "Employee 14" },
                        new Employee { Name = "Employee 15" },
            };

        public static async Task<List<Employee>> GetEmployees(int page = 1, int pageSize = 5, SortDirection sortDirection = SortDirection.None)
        {
            Console.WriteLine($"EmployeeRepository: Making a fake HTTP call to fetch employees with page: {page}, page size: {pageSize} and sort direction: {sortDirection}");

            await Task.Delay(50);

            return Employees
                .Skip(pageSize * (page - 1))
                .Take(pageSize)
                .ToList();
        }


        public static async Task<int> GetTotalCount()
        {
            await Task.Delay(50);
            return Employees.Count;
        }
    }
}
