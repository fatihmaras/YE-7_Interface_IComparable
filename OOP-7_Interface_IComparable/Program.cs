﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_7_Interface_IComparable
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id =1,
                    FullName= "Ahmet Aslan",
                    Salary=9500
                },
                 new Employee()
                {
                    Id =2,
                    FullName= "Aslan Yıldırım",
                    Salary=13250
                },
                  new Employee()
                {
                    Id =3,
                    FullName= "Merve Dağ",
                    Salary=4250
                },
                   new Employee()
                {
                    Id =4,
                    FullName= "Züleyha Çan",
                    Salary=7500
                },
                    new Employee()
                {
                    Id =5,
                    FullName= "Çakır Büyüküstün",
                    Salary=12000
                },
                     new Employee()
                {
                    Id =6,
                    FullName= "Birol Baş",
                    Salary=3500
                },

            };

            employees.Sort();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();

        }
    }
}

