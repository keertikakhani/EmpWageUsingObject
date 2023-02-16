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
        const int EMP_RATE_PER_HR = 20;
        const int WORKING_DAYS = 20;
        const int MAX_WOKING_HRS = 100;
        public void CheckEmployee()
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0, totalEmpHrs = 0, totalWokingDays = 0;

            while (totalWokingDays < WORKING_DAYS && totalEmpHrs <= MAX_WOKING_HRS)
            {

                Random random = new Random();
                int employeeCheck = random.Next(3);

                switch (employeeCheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Full Time Employee is present");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("PartTime Employee is present");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;

                }

                empWage = empHrs * EMP_RATE_PER_HR;
                totalEmpWage = totalEmpWage + empWage;
                totalEmpHrs = totalEmpHrs + empHrs;
        
                totalWokingDays++;

            }
            Console.WriteLine("total wage for {0} days :{1} ", totalWokingDays, totalEmpWage);
            Console.WriteLine("total working hours: " + totalEmpHrs);

        }
    }
}
