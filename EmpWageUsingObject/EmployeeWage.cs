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
            Random random = new Random();
            int employeeCheck = random.Next(2);

            if (employeeCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}
