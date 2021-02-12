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
                        new Employee { Name = "Mladen" },
                        new Employee { Name = "Aaron" },
                        new Employee { Name = "Tierry" },
                        new Employee { Name = "Borus" },
                        new Employee { Name = "Charlie" },
                        new Employee { Name = "Eric" },
                        new Employee { Name = "Dirk" },
                        new Employee { Name = "Fennic" },
                        new Employee { Name = "Roze" },
                        new Employee { Name = "Walter" },
                        new Employee { Name = "Damon" },
                        new Employee { Name = "Benny" },
                        new Employee { Name = "Zlatan" },
                        new Employee { Name = "Amber" },
                        new Employee { Name = "Ivan" },
            };

        public static async Task<List<Employee>> GetEmployees(int page = 1, int pageSize = 5, SortDirection sortDirection = SortDirection.None)
        {
            Console.WriteLine($"EmployeeRepository: Making a fake HTTP call to fetch employees with page: {page}, page size: {pageSize} and sort direction: {sortDirection}");

            await Task.Delay(50);

            var employees = Employees.AsQueryable();

            _ = sortDirection switch
            {
                SortDirection.Ascending => employees = employees.OrderBy(x => x.Name),
                SortDirection.Descending => employees = employees.OrderByDescending(x => x.Name),
                _ => null
            };

            return employees
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
