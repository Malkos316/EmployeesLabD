using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Entities
{
    /// <summary>
    /// Represents a part-time employee
    /// </summary>
    /// <remarks>Author:Markus Luthi</remarks>
    /// <remarks>Date:Feb 23rd, 2023</remarks>
    internal class PartTime : Employee
    {
		// TODO: Add remaining fields, properties, and constructor parameters for part-time employee.

        //Fields
        private double rate;
        private double hours;

        //Properties
        public double Rate { get { return rate; } }
        public double Hours { get { return hours; } }

        //Constructor
        public PartTime(string id, string name, string address, double rate, double hours)
        {
            // Set in instance of inherited Employee
            this.id = id;
            this.name = name;
            this.address = address;
            // Set in instance of this class
            this.rate = rate;
            this.hours = hours;
        }

        public override double CalcWeeklyPay()
        {
            double weeklyPay = 0;

            weeklyPay += this.rate * this.hours;

            return weeklyPay;
        }
    }
}
