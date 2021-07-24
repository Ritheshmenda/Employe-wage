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
            int no_of_hours_full = 8;
            int no_of_hours_part = 4;
            int no_of_workingdays = 20;
            int employeecheck = random.Next(0, 3);
            switch (employeecheck)
            {
                case 0:
                    Console.WriteLine("employee is present full day");
                    Console.WriteLine("employe salary per day is" + PERHRS * no_of_hours_full);
                    Console.WriteLine("employe salary per month is" + PERHRS * no_of_hours_full * no_of_workingdays);
                    break;
                case 1:
                    Console.WriteLine("employee is present for part time");
                    Console.WriteLine("employe salary is " + PERHRS * no_of_hours_part * no_of_workingdays);
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }
        }
    }
}
