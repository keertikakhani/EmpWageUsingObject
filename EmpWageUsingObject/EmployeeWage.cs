using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingObject
{
    public class EmployeeWage
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        
        public void ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalWorkingDays < numOfWorkingDays && totalEmpHrs <= maxHoursPerMonth)
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

            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total employee wage for company : " + company + " is : " + totalEmpWage);

        }
    }
}
