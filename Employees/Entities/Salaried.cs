using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Entities
{
    /// <summary>
    /// Represents a salaried employee
    /// </summary>
    /// <remarks>Author:Markus Luthi</remarks>
    /// <remarks>Date:Feb 23rd, 2023</remarks>
    internal class Salaried : Employee
    {
		// TODO: Add remaining fields, properties, and constructor parameters for salaried employee.

        //Fields
        private double salary;

        //Properties
        public double Salary { get {  return salary; } }

        //Construtor
        public Salaried(string id, string name, string address, double salary)
        {
            // Set in instance of inherited Employee
            this.id = id;
            this.name = name;
            this.address = address;
            // Set in instance of this class
            this.salary = salary;
        }

        public double CalcWeeklyPay()
        {
            return salary;
        }
    }
}
