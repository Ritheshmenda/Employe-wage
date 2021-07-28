using System;
using System.Collections.Generic;
using System.Text;

namespace employewage
{
    class Employeewage
    {
        public static int  Employewage(string companyname ,int Perhrs, int no_of_working_days, int Total_working_hours_in_month)
        {
            int employeehr;
            int total_working_ds = 0;
            int Employeehrsinmonth = 0;
            int wages_per_month;
            while (Employeehrsinmonth <= Total_working_hours_in_month && total_working_ds <= no_of_working_days)
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
                Employeehrsinmonth = Employeehrsinmonth + employeehr;
            }
            wages_per_month = Perhrs * Employeehrsinmonth;
            Console.WriteLine("name of the company : " + companyname);
            Console.WriteLine("wagespermonth : " + wages_per_month);
            return wages_per_month;
        }
    }
}
