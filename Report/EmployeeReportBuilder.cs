using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport; //Отчет который получим

        private readonly IEnumerable<Employee> _employees;//Список сотрудников, которые получим в конструкторе

        //ctor - код снипет
        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new();
        }

        public IEmployeeReportBuilder BuildHeader()
        {
            _employeeReport.Header = $"EMPLOYEES REPORT ON DATE: {DateTime.Now}\n";

            _employeeReport.Header += "\n-----------------------------------------------------------------------------------------------------------\n";

            return this;
        }

        public IEmployeeReportBuilder BuildBody()
        {
            _employeeReport.Body = string.Join(Environment.NewLine, _employees.Select(x => $"Employee: {x.Name}\t\tSalary: {x.Salary}$"));

            return this;
        }

        public IEmployeeReportBuilder BuildFooter()
        {
            _employeeReport.Footer = "\n-----------------------------------------------------------------------------------------------------------\n";
            _employeeReport.Footer += $"\nTOTAL EMPLOYESS: {_employees.Count()}, TOTAL SALARY: {_employees.Sum(x => x.Salary)}$";

            return this;
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;

            _employeeReport = new();

            return employeeReport;
        }
    }
}
