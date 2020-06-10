﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp_DotNET.Book.Session_7
{
    class CodeSnippet_5
    {
        int _empId = 1;
        string _empName = "James Anderson";
        int _age = 25;

        public void Display()
        {
            Console.WriteLine("EmployeeID: "+_empId);
            Console.WriteLine("Employee Name: "+_empName);
        }
    }

    class Department:CodeSnippet_5
    {
        int _deptId = 501;
        string _deptName = "Sales";
        new void Display()
        {
            base.Display();
            Console.WriteLine("Department ID: "+_deptId);
            Console.WriteLine("Department Name: "+_deptName);
        }
    }
}
