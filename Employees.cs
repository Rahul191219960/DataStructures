using System;
using System.Collections.Generic;
namespace EmployeeN
{

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmployeeName { get; set; }

        public Employee(int id, string name)
        {
            this.EmployeeName = name;
            this.EmpId = id;
        }
        public Employee()
        {
            
        }

        public static bool operator ==(Employee e1, Employee e2)
        {
            if (e1.EmpId == e2.EmpId && e1.EmployeeName == e2.EmployeeName)
                return true;
            return false;
        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            if (e1.EmpId != e2.EmpId || e1.EmployeeName != e2.EmployeeName)
                return true;
            return false;
        }
        public static bool operator <(Employee e1, Employee e2)
        {
            if (e1.EmpId < e2.EmpId)
                return true;
            return false;
        }

        public static bool operator >(Employee e1, Employee e2)
        {
            if (e1.EmpId > e2.EmpId)
                return true;
            return false;
        }

        public static bool operator <=(Employee e1, Employee e2)
        {
            if (e1.EmpId <= e2.EmpId)
                return true;
            return false;
        }

        public static bool operator >=(Employee e1, Employee e2)
        {
            if (e1.EmpId >= e2.EmpId)
                return true;
            return false;
        }
    }
}
namespace DataStructures
{
    using EmployeeN;

    public class Employees
    {
        public List<Employee> EmployeeList { get; set; }
        public readonly int Length;
        public Employees(int Length, List<Employee> empList)
        {
            if (Length != empList.Count)
            {
                throw new Exception("Length and the Number of element in the list should be equal");
            }
            this.Length = Length;
            this.EmployeeList = new List<Employee>();
            foreach (var i in empList)
            {
                this.EmployeeList.Add(i);
            }
        }

        public Employee this[int index]
        {
            get
            {
                if (index > Length - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException("Index out of bound");
                }
                return EmployeeList[index];
            }
            set
            {
                if (index > Length - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException("Index out of bound");
                }
                EmployeeList[index] = value;
            }
        }
    }
}