using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingObject
{
    public class EmployeeWage
    {
        public void CheckEmployee()
        {
            const int IS_PRESENT = 1;
            const int EMP_RATE_PER_HR = 20;

            int empHrs = 0, empWage = 0;

            Random random = new Random();
            int employeeCheck = random.Next(2);

            if (employeeCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee daily wage is : " + empWage);

        }
    }
}
