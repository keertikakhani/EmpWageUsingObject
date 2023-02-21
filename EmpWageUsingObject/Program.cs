using System;

namespace EmpWageUsingObject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation program");

            EmployeeWage obj = new EmployeeWage("DMart", 20, 20, 100);
            EmployeeWage obj1 = new EmployeeWage("Reliance", 10, 15, 70);
            obj.ComputeEmpWage();
            Console.WriteLine(obj.ToString());
            obj1.ComputeEmpWage();
            Console.WriteLine(obj1.ToString());

            Console.ReadLine();
        }
    }
}
