using System;
using BO;
using System.IO;
using System.Collections.Generic;

namespace DAL
{
    public class EmployeeDAL
    {
        public void SaveEmployee(EmployeeBO empBO)
        {
            string data=empBO.Name+","+
                empBO.Age+","+
                empBO.Salary+","+
                empBO.Tax;
            StreamWriter sw = new StreamWriter("f1.txt", append: true);
            sw.WriteLine(data);
            sw.Close();
        }

        public List<EmployeeBO> ReadEmployees()
        {
            List<EmployeeBO> empList = new List<EmployeeBO>();
            FileStream fout = new FileStream("f1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fout);
            string line;
            while ((line=sr.ReadLine()) != null)
            {
                EmployeeBO empBO = new EmployeeBO();
                string[] arr = line.Split(",");
                //Console.WriteLine(arr[0] + " " + arr[1] + " " + arr[2] + " " + arr[3]);
                empBO.Name = arr[0];
                empBO.Age = int.Parse(arr[1]);
                empBO.Salary = decimal.Parse(arr[2]);
                empBO.Tax = decimal.Parse(arr[3]);
                empList.Add(empBO);
            }
            sr.Close();
            fout.Close();
            return empList;
        }
    }
}
