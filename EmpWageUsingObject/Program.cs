using System;

namespace EmpWageUsingObject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation program");

            EmployeeWage obj = new EmployeeWage();
            obj.ComputeEmpWage("DMart", 20, 20, 100);
            obj.ComputeEmpWage("Reliance", 10, 15, 70);

            Console.ReadLine();
        }
    }
}
