using System;
using System.Collections.Generic;
using System.Text;
using BO;
using DAL;

namespace BLL
{
    public class EmployeeManager
    {
        public void SaveEmployee(EmployeeBO empBO)
        {
            empBO.Tax = CalculateTax(empBO.Salary);
            EmployeeDAL empDAL = new EmployeeDAL();
            empDAL.SaveEmployee(empBO);
        }
        public List<EmployeeBO> ReadEmployees()
        {
            EmployeeDAL empDAL = new EmployeeDAL();
            return empDAL.ReadEmployees();                      //returning employees list
        }
        private decimal CalculateTax(decimal sal)
        {
            if (sal > 1000)
            {
                return sal * 0.2M;      //20% tax 
            }
            else
            {
                return sal * 0.1M;      //10% tax
            }
        }
    }
}
