using System;
using System.Collections.Generic;

namespace Day01_EF
{
    internal class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public int Salary { get; set; }
        }
       
        static void Main(string[] args)
        {
            #region Note + Problem 1
            ////remember there is no diff in the output but object will cause boxing (poor memory optimization)
            //var num = 1;
            //object num2 = 2;
            //Console.WriteLine(num.GetType());
            //Console.WriteLine(num2.GetType());

            ////problem 1
            //var num1 = 10;
            //var str = "Mariam";
            //var doublee = 2.5;
            //var result = true;
            //var arr = new[] { 1, 2, 3, 4 };

            //Console.WriteLine(num1.GetType());
            //Console.WriteLine(str.GetType());
            //Console.WriteLine(doublee.GetType());
            //Console.WriteLine(result.GetType());
            //Console.WriteLine(arr.GetType()); 
            #endregion

            #region Problem 2
            //int age = 20;
            //string name = "Mariam";
            //double salary = 5000.50;
            //bool isStudent = true;

            //var age1 = 20;
            //var name1 = "Mariam";
            //var salary1 = 5000.50;
            //var isStudent1 = true;

            ////explicit: the compiler already knows the type
            ////var: var is resolved at compile time from the assigned value 
            #endregion

            #region Problem 3
            //var result = new
            //{
            //    Name = "Phone",
            //    Price = 20000,
            //    Quantity = 10
            //};
            //Console.WriteLine(result); 
            #endregion

            #region Problem 4
            //var arrOfEmployees = new[]
            //{
            //    new {Name="Mariam" , Grade=100 },
            //    new {Name="Nadin" , Grade=98 },
            //    new {Name="Malak" , Grade=80 }
            //};

            //foreach(var employee in arrOfEmployees)
            //{
            //    Console.WriteLine(employee);
            //} 
            #endregion

            #region Problem 6
            //Console.WriteLine(StringExtension.IsPalindrome("Mariam"));
            //Console.WriteLine("Mariam".IsPalindrome());
            //Console.WriteLine("maram".IsPalindrome());
            //Console.WriteLine("abcdcba".IsPalindrome());
            #endregion

            #region Problem 7
            //Console.WriteLine(1.IsPrime());
            //Console.WriteLine(2.IsPrime());
            //Console.WriteLine(3.IsPrime());
            //Console.WriteLine(4.IsPrime()); 
            #endregion

            #region Problem 9
            //List<string> list = new List<string> { "Mariam", "Ayman", "nada", "sara", "mohamed", "mohamed" };

            //list.Add("salem");
            //list.Remove("Mariam");

            //bool found = false;
            //foreach(string Name in list)
            //{
            //    if(Name == "nada")
            //    {
            //        found= true; break;
            //    }
            //}
            //Console.WriteLine(found);

            //foreach(string Name in list)
            //{
            //    Console.WriteLine(Name);
            //} 
            #endregion

            #region Problem 10
            //List<Employee> list = new List<Employee>()
            //{
            //    new Employee {Name="Mariam" , Salary=10000 },
            //    new  Employee {Name="Nadin" , Salary=20000 },
            //    new  Employee{Name="Malak" , Salary=6000 }
            //};
            //foreach (Employee e in list)
            //{
            //    if(e.Salary> 6000)
            //        Console.WriteLine(e.Name);
            //} 
            #endregion

        }
    }
}
