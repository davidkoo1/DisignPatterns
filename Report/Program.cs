using System;
using System.Collections.Generic;

namespace Reporter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new()
            {
                new Employee { Name = "Igor", Salary = 700 },
                new Employee { Name = "Alex", Salary = -300 }
            };

            var builder = new EmployeeReportBuilder(employees);

            var director = new EmployeeReportDirector(builder);

            director.Build();

            var report = builder.GetReport();

            Console.WriteLine(report);
        }
    }
}
