using System;
using DataStructures;
using System.Collections.Generic;
namespace Heaps
{
    using EmployeeN;
    public class Heaps<T> where T : Employees
    {
        private void Max_Heapify(T myEmp, int index)
        {
            if (index >= myEmp.Length)
            {
                throw new IndexOutOfRangeException("Index out of bound");
            }
            else
            {
                if ((index * 2 + 1) < myEmp.Length && myEmp[index] <= myEmp[2 * index + 1])
                {
                    Employee temp = new Employee();
                    temp = myEmp[2 * index + 1];
                    myEmp[2 * index + 1] = myEmp[index];
                    myEmp[index] = temp;
                }
                if (((index * 2) + 2) < myEmp.Length && myEmp[index] < myEmp[2 * index + 2])
                {
                    Employee temp = new Employee();
                    temp = myEmp[2 * index + 2] ;
                    myEmp[2 * index + 2] = myEmp[index];
                    myEmp[index] = temp;
                }
            }
        }

        public T Build_MaxHeap( T myEmp)
        {
            for(int i = myEmp.Length / 2 ; i >=0 ; i --)
            {
                Max_Heapify(myEmp,i);
            }
            return myEmp;
        }

        public Employee Extract_Max(T myEmp)
        {
            return myEmp[0];
        }
    }
}