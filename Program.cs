using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_payroll_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            Random random_obj = new Random();
            int WagePerHour = 20;
            int FullDayHour = 8;
            int Full_day_wage = WagePerHour * FullDayHour;
            int EMP = random_obj.Next(0, 2);            
            // UC 1             
            if (EMP == 1)
            {
                Console.WriteLine("Present");
            }

            else
            {
                Console.WriteLine("Absent");
            }
            // UC2
            Console.WriteLine($"Wage per day {Full_day_wage}");
        }
    }
}
