using System;
using DataStructures;
using System.Collections.Generic;
namespace Heaps
{
    using EmployeeN;
    public class MaxHeaps<T> where T : Employees
    {
        public MaxHeaps(T myEmp)
        {
            this._Data = Build_MaxHeap(myEmp);
        }
        private T _Data { get; set; }
        private void Max_Heapify(T myEmp, int index)
        {
            if (index >= myEmp.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of bound");
            }
            else
            {
                if (((index * 2) + 2) < myEmp.Length)  // right child is present
                {
                    Employee right = new Employee();
                    Employee left = new Employee();
                    // Employee largest = new Employee();
                    int Largest;

                    if (myEmp[index * 2 + 2] < myEmp[index * 2 + 1])
                    {
                        Largest = index * 2 + 1;
                        Employee temp = new Employee();
                        temp = myEmp[index * 2 + 1];
                        myEmp[index * 2 + 1] = myEmp[index];
                        myEmp[index] = temp;
                    }
                    else
                    {
                        Largest = index * 2 + 2;
                        Employee temp = new Employee();
                        temp = myEmp[index * 2 + 2];
                        myEmp[index * 2 + 2] = myEmp[index];
                        myEmp[index] = temp;
                    }
                    Max_Heapify(myEmp, Largest);
                }
                else if ((index * 2 + 1) < myEmp.Length && myEmp[index] < myEmp[index * 2 + 1]) // only left child is present
                {
                    Employee left = new Employee();
                    left = myEmp[index * 2 + 1];
                    Employee temp = new Employee();
                    temp = myEmp[index * 2 + 1];
                    myEmp[index * 2 + 1] = myEmp[index];
                    myEmp[index] = temp;
                }
            }
        }


        private T Build_MaxHeap(T myEmp)
        {
            for (int i = myEmp.Length / 2; i >= 0; i--)
            {
                Max_Heapify(myEmp, i);
            }
            return myEmp;
        }

        public Employee Extract_Max()
        {
            return this._Data.EmployeeList[0];
        }
    }
}