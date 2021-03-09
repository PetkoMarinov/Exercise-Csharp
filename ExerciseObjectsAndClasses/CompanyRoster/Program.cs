using System;
using System.Collections.Generic;
using System.Linq;

class CompanyRoster
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();
        List<string> departments = new List<string>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            string name = input[0];
            double salary = double.Parse(input[1]);
            string department = input[2];
            var newEmployee = new Employee(name,salary,department);
            
            employees.Add(newEmployee);
            departments.Add(department);
        }
        //remove duplicates departments
         departments = departments.Distinct().ToList();

        string departmentHighestSalary = "";
        double highestAverageSalary = double.MinValue;

        foreach (string department in departments)
        {
            double averageSalary = employees
                .Where(e => e.Department == department)
                .Select(e => e.Salary)
                .Average();

            if (averageSalary > highestAverageSalary)
            {
                departmentHighestSalary = department;
                highestAverageSalary = averageSalary;
            }
        }

        Console.WriteLine($"Highest Average Salary: {departmentHighestSalary}");

        foreach (var employee in employees
            .Where(e => e.Department == departmentHighestSalary)
            .OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
        }
    }
}