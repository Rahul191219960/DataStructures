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
            BinaryTree<Employee> bst = new BinaryTree<Employee>();
            bst.AddChild(employees[4]);
            bst.AddChild(employees[0]);
            bst.AddChild(employees[7]);
            bst.AddChild(employees[8]);
            bst.AddChild(employees[6]);
            bst.AddChild(employees[5]);
            bst.AddChild(employees[9]);
            bst.AddChild(employees[10]);
            bst.AddChild(employees[3]);
            bst.AddChild(employees[1]);
            bst.AddChild(employees[2]);

            bool isPresent = bst.Search(employees[1]);
            bool isPr = bst.Search(new Employee(0, "Rahul"));

            var x = bst.GetParent(employees[4]);
            x = bst.GetParent(employees[0]);
            x = bst.GetParent(employees[7]);
            x = bst.GetParent(employees[8]);
            x = bst.GetParent(employees[6]);
            x = bst.GetParent(employees[5]);
            x = bst.GetParent(employees[9]);
            x = bst.GetParent(employees[10]);
            x = bst.GetParent(employees[3]);
            x = bst.GetParent(employees[1]);
            x = bst.GetParent(employees[2]);
        }
    }
}