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
            int PERHRS = 20;
            int NO_OF_HOURS_FULL = 8;
            int NO_OF_HOURS_PART = 4;
            int employeecheck = random.Next(0, 3);
            if (employeecheck == 0)
            {
                Console.WriteLine("employee is present full day");
                Console.WriteLine("employe salary is" + PERHRS * NO_OF_HOURS_FULL);
            }
            else if (employeecheck == 1)
            {
                Console.WriteLine("employee is present for part time");
                Console.WriteLine("employe salary is " + PERHRS * NO_OF_HOURS_PART);
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
