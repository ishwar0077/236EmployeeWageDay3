using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageDay3
{
    public class Employee
    {
        public static void EmployeeAttendance()
        {
            int IS_PRESENT = 1;

            Random rand = new Random();
            int empCheck = rand.Next(2);
            if (empCheck == 1)
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
