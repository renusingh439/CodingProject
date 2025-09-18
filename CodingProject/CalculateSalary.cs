using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProject
{
    public class WorkLog
    {
        public string EmployeeName { get; set; }
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }
    }
    public class CalculateSalary
    {
        
        public static Dictionary<string, int> CalculateTotalSalaries(List<WorkLog> logs)
        {
            return logs
                .GroupBy(log => log.EmployeeName)
                .ToDictionary(
                    g => g.Key,
                    g => g.Sum(log => log.HoursWorked * log.HourlyRate)
                );
        }

        public static void SalaryData()
        {
            var logs = new List<WorkLog>();

            Console.Write("Enter number of work logs: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter {i + 1} details :");

                Console.Write("Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours Worked: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Hourly Rate: ");
                int rate = int.Parse(Console.ReadLine());

                logs.Add(new WorkLog { EmployeeName = name, HoursWorked = hours, HourlyRate = rate });
            }

            var calculatedSalaries = CalculateTotalSalaries(logs);

            Console.WriteLine("\nTotal Salaries:");
            foreach (var v in calculatedSalaries)
            {
                Console.WriteLine($"{v.Key}: {v.Value}");
            }
        }
    }
}
