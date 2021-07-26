using System;
using System.Collections.Generic;
using System.Text;

namespace employewage
{
    class Employeewage
    {
        public void Employewage()
        {
            int employeehr = 0;
            int Perhrs = 20;
            int no_of_days = 20;
            int Total_working_hours_in_month = 100;
            int total_working_ds = 0;
            int Employeeinmonth = 0;
            while (Employeeinmonth <= Total_working_hours_in_month && total_working_ds <= no_of_days)
            {
                total_working_ds++;
                Random random = new Random();
                int employeecheck = random.Next(0, 2);
                switch (employeecheck)
                {
                    case 0:
                        employeehr = 8;
                        break;
                    default:
                        employeehr = 4;
                        break;
                }
                Employeeinmonth = Employeeinmonth + employeehr;
            }
            int wages_per_month;
            wages_per_month = Perhrs * Employeeinmonth;
            Console.WriteLine("wagespermonth : " + wages_per_month);
        }
    }
}
