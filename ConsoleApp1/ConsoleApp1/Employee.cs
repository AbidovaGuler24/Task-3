using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {{ public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            Name=name;
            Salary=salary;
            if (name==null || name=="")
            {
                Console.WriteLine("Ad düzgün daxil edilməlidir!");
                return;
            }
            if (salary<=0)
            {
                Console.WriteLine("Maaş 0-dan böyük olmalıdır!");
                return;
            }
        }


        public void ShoowInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }
}
