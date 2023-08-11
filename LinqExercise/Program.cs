using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //DONE: Print the Sum of numbers

            Console.WriteLine("Sum of numbers array:");
            var sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.WriteLine("-----");

            //DONE: Print the Average of numbers

            Console.WriteLine("Average of numbers array:");
            var average = numbers.Average();
            Console.WriteLine(average);
            Console.WriteLine("-----");

            //DONE: Order numbers in ascending order and print to the console

            Console.WriteLine("Ascending order of numbers array:");
            var asc = numbers.OrderBy(num => num);
            foreach (var num in asc) Console.WriteLine(num);
            Console.WriteLine("-----");

            //DONE: Order numbers in descending order and print to the console

            Console.WriteLine("Descending order of numbers array:");
            var desc = numbers.OrderByDescending(num => num);
            foreach (var num in desc) Console.WriteLine(num);
            Console.WriteLine("-----");

            //DONE: Print to the console only the numbers greater than 6

            Console.WriteLine("Only numbers greater than 6:");
            var greaterThanSix = numbers.Where(num => num > 6);
            foreach (var num in greaterThanSix) Console.WriteLine(num);
            Console.WriteLine("-----");

            //DONE: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Only four from numbers array in descending order:");
            var onlyFour = numbers.OrderByDescending(num => num);
            foreach (var num in onlyFour.Take(4)) Console.WriteLine(num);
            Console.WriteLine("-----");

            //DONE: Change the value at index 4 to your age, then print the numbers in descending order

            Console.WriteLine("Replace 5 with 39 and print numbers array in descending order:");
            numbers[4] = 39;
            var descending = numbers.OrderByDescending(num => num);
            foreach (var num in descending) Console.WriteLine(num);
            Console.WriteLine("-----");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //DONE: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("Full names in ascending order where first name starts with C or S:");
            var fullNameList = employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S').OrderBy(x => x.FirstName);
            foreach (var person in fullNameList) Console.WriteLine(person.FullName);
            Console.WriteLine("-----");

            //DONE: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Full names and age over 26:");
            var fullNamePlusAge = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var person in fullNamePlusAge) Console.WriteLine($"{person.FullName} {person.Age}");
            Console.WriteLine("-----");

            //DONE: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("Sum of employees' years of experience:");
            var sumYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 5).Sum(x => x.YearsOfExperience);
            Console.WriteLine(sumYOE);
            Console.WriteLine("Average of employees' years of experience:");
            var avgYOE = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 5).Average(x => x.YearsOfExperience);
            Console.WriteLine(avgYOE);
            Console.WriteLine("-----");

            //DONE: Add an employee to the end of the list without using employees.Add()

            Console.WriteLine("Add employee:");
            employees = employees.Append(new Employee { FirstName = "Jon", LastName = "Claxton", Age = 39, YearsOfExperience = 8 }).ToList();
            var newEmployee = employees.Where(x => x.FirstName == "Jon");
            foreach (var employee in newEmployee) Console.WriteLine($"{employee.FullName} {employee.Age} {employee.YearsOfExperience}");
            Console.WriteLine("-----");

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
