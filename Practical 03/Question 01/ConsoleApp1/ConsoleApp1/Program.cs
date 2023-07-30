using System;

namespace EmployeeInfo
{
    class Employee
    {
        private int empID;
        private string empName;
        private string empDesignation;

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        public string EmpDesignation
        {
            get { return empDesignation; }
            set { empDesignation = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Information");

            Employee emp = new Employee();

            Console.Write("Enter Employee ID: ");
            emp.EmpID = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            emp.EmpName = Console.ReadLine();

            Console.Write("Enter Employee Designation: ");
            emp.EmpDesignation = Console.ReadLine();

            string message = $"Hello {emp.EmpName}, Your Employee ID is {emp.EmpID} and You are a {emp.EmpDesignation}.";
            Console.WriteLine(message);
        }
    }
}
