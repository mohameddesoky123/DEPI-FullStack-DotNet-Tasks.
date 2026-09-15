using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daye06_OOP01
{
    internal struct Employee
    {
        private int empId;
        private string Name;
        private decimal salary;

        public Employee(int id, string name, decimal salary)
        {
            empId = id;
            Name = name;
            this.salary = salary;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
        
        public decimal GetSalary()
        {
            return salary;
        }

        public void SetSalary(decimal salary)
        {
            this.Salary = salary;
        } 
        public int GetEmpId()
        {
            return empId;
        }
        public void SetEmpId(int id)
        {
            empId = id;
        }

      

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }


        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }


    }
}
