using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public struct Employee
    {
        private const int DATE_TIME_NUMBERS_COUNT = 3;
        public string Name { get; set; }
        public Vacansiec Vacancy { get; set; }
        public int Salary { get; set; }
        private int[] employmentDate;

        public void SetEmploymentDate(int day, int month, int year)
        {
            if (employmentDate == null) employmentDate = new int[DATE_TIME_NUMBERS_COUNT] { day, month, year };
            else
            {
                employmentDate[0] = day;
                employmentDate[1] = month;
                employmentDate[2] = year;
            }
        }
        public void SetEmploymentDate(DateTime time)
        {
            employmentDate[0] = time.Day;
            employmentDate[1] = time.Month;
            employmentDate[2] = time.Year;
        }
        public int[] GetemploymentDate()
        {
            return employmentDate;
        }

        public Employee(string name, Vacansiec vacancy, int salary, int day, int month, int year)
        {
            Name = name;
            Vacancy = vacancy;
            Salary = salary;
            employmentDate = new int[DATE_TIME_NUMBERS_COUNT] { day, month, year };
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(string.Format("Name: {0}\nVacancy: {1}\nSalary: {2}\nEmploymentDate: ", Name, Vacancy, Salary));

            stringBuilder.Append(employmentDate[0].ToString() + ":");
            stringBuilder.Append(employmentDate[1].ToString() + ":");
            stringBuilder.Append(employmentDate[2].ToString());

            return stringBuilder.ToString();
        }
    }
}
