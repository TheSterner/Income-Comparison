using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            int perOneHourlyRate = 25;
            int perOneHoursWorkedPerWeek = 40;
            int salaryPerOne = (perOneHourlyRate * perOneHoursWorkedPerWeek) * 52;
            Console.WriteLine(perOneHourlyRate);
            Console.WriteLine(perOneHoursWorkedPerWeek);
            Console.ReadLine();
            Console.WriteLine("Person 2");
            int perTwoHourlyRate = 27;
            int perTwoHoursWorkedPerWeek = 45;
            int salaryPerTwo = (perTwoHourlyRate * perTwoHoursWorkedPerWeek) * 52;
            Console.WriteLine(perTwoHourlyRate);
            Console.WriteLine(perTwoHoursWorkedPerWeek);
            Console.ReadLine();
            Console.WriteLine("Annual salary of Person 1: " + salaryPerOne);
            Console.WriteLine("Annual salary of Person 2: " + salaryPerTwo);
            Console.ReadLine();
            bool comparison = salaryPerOne > salaryPerTwo;
            Console.WriteLine(comparison);
            Console.ReadLine();

        }
    }
}
