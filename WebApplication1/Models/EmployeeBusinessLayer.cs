using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();

            emp.FirstName = "johnson";
            emp.LastName = "fernandes";
            emp.Salary = 14000;
            employees.Add(emp);

            emp.FirstName = "richard";
            emp.LastName = "rixham";
            emp.Salary = 60000;
            employees.Add(emp);

            return employees;
        }
    }
}
