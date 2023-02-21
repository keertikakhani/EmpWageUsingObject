using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingObject
{
    public class EmployeeWage
    {
       public const int IS_FULL_TIME = 1;
       public const int IS_PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void ComputeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

                while (totalWorkingDays < this.numOfWorkingDays && totalEmpHrs <= this.maxHoursPerMonth)
                {

                     Random random = new Random();
                     int employeeCheck = random.Next(3);

                        switch (employeeCheck)
                        {
                            case IS_FULL_TIME:
                               Console.WriteLine("\nFull Time Employee is present");
                               empHrs = 8;
                                break;
                            case IS_PART_TIME:
                               Console.WriteLine("\nPartTime Employee is present");
                               empHrs = 4;
                               break;
                            default:
                               Console.WriteLine("\nEmployee is absent");
                               empHrs = 0;
                               break;
                        }
                   totalEmpHrs = totalEmpHrs + empHrs;
                   totalWorkingDays++;
                  Console.WriteLine("Day:" +totalWorkingDays + " Emp Hrs : " +empHrs);
                }

            totalEmpWage = totalEmpHrs * this.empRatePerHour;
        }

        public string ToString()
        {
            return "Total Emp Wage for company : " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
