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
            int partDayHour = 4;
            int Full_day_wage = WagePerHour * FullDayHour;
            int part_time_wage = WagePerHour * partDayHour;
            int PartTimeWagePerMonth = part_time_wage * 20;
            int FullTimeWagePerMonth = Full_day_wage * 20;
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
            Console.WriteLine("Are you a Part Time or a Full Time");
            string PF = Console.ReadLine();
            // UC 4
            switch (PF)
            {
                // UC 3
                case "Part Time":
                    {
                        Console.WriteLine($"Wage per day part time: {part_time_wage}");
                        // UC 5
                        Console.WriteLine("Calculating Wages for a month");
                        Console.WriteLine($"Wage Per Month for Part Time = {PartTimeWagePerMonth}");
                        // UC 6
                        Console.WriteLine("Calculating Wages for a Year");
                        Console.WriteLine($"Wage Per Yearly for Part Time = {PartTimeWagePerMonth * 12}");
                        break;
                    }
                ;;
                // UC 2
                case "Full Time":
                    {
                        Console.WriteLine($"Wage per day full time: {Full_day_wage}");
                        // UC 5
                        Console.WriteLine("Calculating Wages for a month");
                        Console.WriteLine($"Wage Per Month for Part Time = {FullTimeWagePerMonth}");
                        // UC 6
                        Console.WriteLine("Calculating Wages for a Year");
                        Console.WriteLine($"Wage Per Yearly for Full Time = {FullTimeWagePerMonth * 12}");
                        break;
                    }
            }
        }
    }
}
