using System;
using System.Collections.Generic;
using BLL;
using BO;

namespace PL
{
    public class EmployeeView
    {
        public void InputData()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter salary: ");
            decimal sal = decimal.Parse(Console.ReadLine());

            EmployeeBO empBO = new EmployeeBO();
            empBO.Name = name;
            empBO.Age = age;
            empBO.Salary = sal;

            EmployeeManager empMang = new EmployeeManager();
            empMang.SaveEmployee(empBO);
        }
        public void OutputData()
        {
            EmployeeManager empMang = new EmployeeManager();
            List<EmployeeBO> empList = empMang.ReadEmployees();
            foreach(EmployeeBO empBO in empList)
            {
                Console.WriteLine("\nName: " + empBO.Name);
                Console.WriteLine("Age: " + empBO.Age);
                Console.WriteLine("Salary: " + empBO.Salary);
                Console.WriteLine("Tax: " + empBO.Tax);
            }
        }
    }
}
