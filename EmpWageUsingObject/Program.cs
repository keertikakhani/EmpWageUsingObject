using System;

namespace EmpWageUsingObject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation program");

            EmployeeWage obj = new EmployeeWage();
            obj.CheckEmployee();

            Console.ReadLine();
        }
    }
}
