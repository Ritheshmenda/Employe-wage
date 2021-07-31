using System;
using System.Collections.Generic;
using System.Text;

namespace employewage
{
   public class Employebuild
    {
        public int employeehr;
        public int total_working_ds = 0;
        public int Employeehrsinmonth = 0;
        public int wages_per_month;
        public string companyname;
        public int Perhrs;
        public int no_of_working_days;
        public int Total_working_hours_in_month;
        public Employebuild(string companyname ,int Perhrs, int no_of_working_days, int Total_working_hours_in_month)
        {
            this.companyname = companyname;
            this.Perhrs = Perhrs;
            this.no_of_working_days = no_of_working_days;
            this.Total_working_hours_in_month = Total_working_hours_in_month;
        }
        public void Employewage()
        {
            while (Employeehrsinmonth <= Total_working_hours_in_month && total_working_ds <= no_of_working_days)
            {  
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
                total_working_ds++;
            }
            wages_per_month = Perhrs * Employeehrsinmonth;
        }

        public void showresult()
        {
            Console.WriteLine("name of the company : " + companyname);
            Console.WriteLine("wagespermonth : " + wages_per_month);
        }
    }

}
