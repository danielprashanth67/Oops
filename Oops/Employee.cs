using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class Employee:Person
    {
        int Salary;
        Employee(int sal)
        {
            String FullName = FirstName + LastName;
            sal = Salary;
            Console.WriteLine("Employee " + FullName + "Salary is" + sal.ToString());
        }
        Employee()
        {
            String FullName = FirstName + LastName;
            Salary = 50;
            Console.WriteLine("Employee " + FullName + "Salary is" + Salary);
        }
    }
}
