using System;
using System.Collections.Generic;
using Heaps;
using EmployeeN;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            for (int i = 10; i >= 0; i--)
            {
                Employee temp = new Employee();
                temp.EmpId = i + 1;
                temp.EmployeeName = (i + 1).ToString() + "EMP";
                emp.Add(temp);
            }
            Employees employees = new Employees(11, emp);
            MaxHeaps<Employees> heap = new MaxHeaps<Employees>(employees);
            Employee max = heap.Extract_Max();
            var xx = heap.HeapSort();
        }
    }
}