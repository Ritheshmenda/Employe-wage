using System;

namespace employewage
{
    class Program
    {
        static void Main(string[] args)
        {
            Employebuild companyA = new Employebuild("Company A", 30, 15, 103);
            companyA.Employewage();
            companyA.showresult();
            Employebuild companyb = new Employebuild("companyB", 70, 40, 120);
            companyb.Employewage();
            companyb.showresult();
            Employebuild companyc = new Employebuild("CompanyC", 70, 40, 120);
            companyc.Employewage();
            companyc.showresult();
        }
    }
}
