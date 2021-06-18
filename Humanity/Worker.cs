using System;
using System.Text;

namespace Humanity
{
    class Worker : Human
    {
        private const decimal MinWeekSalary = 10;
        private const int MinWorkingHoursPerDay = 1;
        private const int MaxWorkingHoursPerDay = 12;

        private decimal weekSalary;
        private decimal WeekSalary
        {
            set
            {
                if (value <= MinWeekSalary)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(weekSalary)}");
                }

                weekSalary = value;
            }
        }
        private double workHoursPerDay;
        private double WorkHoursPerDay
        {
            set
            {
                if (value < MinWorkingHoursPerDay || value > MaxWorkingHoursPerDay)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: {nameof(workHoursPerDay)}");
                }

                this.workHoursPerDay = value;
            }
        }
        private static int counter;
        // A read-only static property:
        public static int Counter
        {
            get { return counter; }
        }

        public Worker(string firstName, string lastName, Gender gender, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName, gender)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;

            ++counter;
        }        

        private decimal GetSalaryPerHour()
        {
            var salaryPerDay = this.weekSalary / 5;
            return salaryPerDay / (decimal)this.workHoursPerDay;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.weekSalary:F2}")
                .AppendLine($"Hours per day: {this.workHoursPerDay:F2}")
                .AppendLine($"Salary per hour: {this.GetSalaryPerHour():F2}");

            return sb.ToString();
        }
    }
}
