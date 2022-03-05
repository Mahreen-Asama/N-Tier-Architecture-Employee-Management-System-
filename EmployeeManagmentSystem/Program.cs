using System;
using PL;

namespace EmployeeManagmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--EMS--");
            EmployeeView view = new EmployeeView();
            for (int i = 0; i < 3; i++)
            {
                view.InputData();
                Console.WriteLine("Employee added\n");
            }
            Console.WriteLine("\n--Employees data is--\n");
            view.OutputData();
        }
    }
}
