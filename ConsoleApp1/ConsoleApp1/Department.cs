using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public Employee[] Employees { get; private set; }

        private Employee[] employees;
        private int employeeCount = 0;
        public Department(string name, int employeeLimit)
        {
            Name=name;
            EmployeeLimit=employeeLimit;
            Employees = new Employee[EmployeeLimit];
        }



        public void AddEmployee(Employee employee)
        {
            if (employeeCount < EmployeeLimit)
            {
                Employees[employeeCount]=employee;
                employeeCount++;
                Console.WriteLine($"İşçi {employee.Name} departmenta əlavə olundu.");

            }
            else
            {
                Console.WriteLine("İşçi sayı limitini keçdi! Yeni işçi əlavə edilə bilməz.");
            }
        }

    }
}
