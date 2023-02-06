using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Entities
{
    /// <summary>
    /// Represents a waged employee
    /// </summary>
    /// <remarks>Author:Markus Luthi</remarks>
    /// <remarks>Date:Feb 23rd, 2023</remarks>
    internal class Waged : Employee
    {
		// TODO: Add remaining fields, properties, and constructor parameters for waged employee.

        //Fields
        private double rate;
        private double hours;

        //Properties
        public double Rate { get { return rate; } }
        public double Hours { get { return hours; } }

        //Constructor
        public Waged(string id, string name, string address, double rate, double hours)
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
            if (this.hours < 40)
            {
                weeklyPay = this.hours * this.rate;
            }
            else
            {
                double overtimeHours = this.hours - 40;

                weeklyPay = 40 * this.rate;

                double overtimePay = overtimeHours * (this.rate * 1.5);
                
                weeklyPay += overtimeHours;

            }
            return weeklyPay;
        }
    }
}
