using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_Method
{
    public class Employee
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private string Department;
        private double Salary;
        private JobTitle jobTitle { get; set; }


        public Employee(int id, string firstName, string lastName, string dept, double salary, JobTitle jobTitle)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Department = dept;
            Salary = salary;

        }
        public int id
        {
            get => Id;set => Id = value;
        }
        public string firstName
        {
            get => FirstName; set => FirstName = value;
        }
        public string lastName
        {
            get => LastName; set => LastName = value;
        }
        public string dept
        {
            get => Department; set => Department = value;
        }
        public double salary
        {
            get => Salary; set => Salary = value;
        }
    }
    
}
