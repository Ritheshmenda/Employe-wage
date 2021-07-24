using System;
using System.Collections.Generic;
using System.Text;

namespace employewage
{
    class Employeewage
    {
        public void Employewage()
        {
            Random random = new Random();
            int employeecheck = random.Next(0, 2);
            if (employeecheck == 0)
                Console.WriteLine("Employee is absent");
            else
                Console.WriteLine("employee is present");
        }
    }
}
