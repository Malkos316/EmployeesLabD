using Employees.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    /// <summary>
    /// CPRG211 - Lab Inheritance
    /// </summary>
    /// <remarks>Author:Markus Luthi </remarks>
    /// <remarks>Date:Feb 4th, 2023 </remarks>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create list that holds Employee instances
            List<Employee> employeeList = new List<Employee>();

            // Must be a relative path
            string filePath = "employees.txt";

            // Converts lines in file into an array of strings
            string[] employeeFilelines = File.ReadAllLines(filePath);

            // Loop through each line
            foreach (string line in employeeFilelines)
            {
                // Split line into parts or cells.
                string[] cells = line.Split(':');

                // The first 3 cells are the ID, name, and address.
                string id = cells[0];
                string name = cells[1];
                string address = cells[2];
                string phone = cells[3];
                string sin = cells[4];
                string dateofbirth = cells[5];
                string department = cells[6];
				
				// TODO: Get remaining employee info from cells

                // Extract the first digit of the ID.
                string firstDigit = id.Substring(0, 1);

                // Convert first digit from string to int.
                int firstDigitInt = int.Parse(firstDigit);

                // Check range of first digit
                if (firstDigitInt >= 0 && firstDigitInt <= 4)
                {
                    // Salaried
                    string salary = cells[7];

                    // Convert salary from string to double.
                    double salaryDouble = double.Parse(salary);

                    // Create Salaried instance
                    Salaried salaried = new Salaried(id, name, address, salaryDouble);

                    // Add to list of employees.
                    employeeList.Add(salaried);
                }
                else if (firstDigitInt >= 5 && firstDigitInt <= 7)
                {
                    // Wage
                    string rate = cells[7];
                    string hours = cells[8];

                    // Convert rate and hours from string to double
                    double rateDouble = double.Parse(rate);
                    int hoursInt = int.Parse(hours);

                    // Create Wages instance
                    Waged wages = new Waged(id, name, address, rateDouble, hoursInt);

                    // Add to list of employees.
                    employeeList.Add(wages);
                }
                else if (firstDigitInt >= 8 && firstDigitInt <= 9)
                {
                    // Part time
                    string rate = cells[7];
                    string hours = cells[8];

                    // Convert rate and hours from string to double
                    double rateDouble = double.Parse(rate);
                    double hoursDouble = double.Parse(hours);

                    // Create PartTime instance
                    PartTime partTime = new PartTime(id, name, address, rateDouble, hoursDouble);

                    // Add to list of employees
                    employeeList.Add(partTime);

                }
                /**
                 * TODO:
                 *  - Determine average weekly pay of all employees.
                 *  - Determine highest paid waged employee.
                 *  - Determine lowest paid salaried employee.
                 *  - Determine percentage of employees that are salaried, waged, and part-time.
                 */
                
            }
            double weeklyPaySum = 0;

            // It's okay to use loop through employees multiple times.
            foreach (Employee employee in employeeList)
            {
                double weeklyPay = employee.CalcWeeklyPay();

                weeklyPaySum += weeklyPay;
            }
            double averageWeeklyPay = weeklyPaySum / employeeList.Count;

            Console.WriteLine("Average weekly pay: " + averageWeeklyPay);
            Console.ReadLine();
        }
    }
}
