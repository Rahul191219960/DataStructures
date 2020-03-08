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
            for (int i = 0; i < 10; i++)
            {
                Employee temp = new Employee();
                temp.EmpId = i + 1;
                temp.EmployeeName = i.ToString() + "EMP";
                emp.Add(temp);
            }
            Employees employees = new Employees(10, emp);
            Heaps<Employees> heap = new Heaps<Employees>();
            Employees heapOfEMp = heap.Build_MaxHeap(employees);
            Employee max = heap.Extract_Max(heapOfEMp);
            Console.WriteLine("EMmployee id = {0} and Employee Name = {1} ",max.EmpId,max.EmployeeName);
        }
    }
}
