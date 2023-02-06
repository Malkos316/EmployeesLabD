using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Entities
{
    /// <summary>
    /// Represents an Employee
    /// </summary>
    /// <remarks>Author:Markus Luthi</remarks>
    /// <remarks>Date:Feb 4th, 2023</remarks>
    internal class Employee
    {
        //Fields/Attributes - These define what an Employee is comprised of in our program. like a blueprint
        protected string id;
        protected string name;
        protected string address;
        protected string phone;
        protected long sin;
        protected string dateofbirth;
        protected string department;

        //Constructor - A special method created inside of a class that gets called when you Create an object of that particular class

        public Employee() { }
        public Employee(string id, string name, string address, string phone, long sin, string dateofbirth, string department)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.sin = sin;
            this.dateofbirth = dateofbirth;    
            this.department = department;
        }
        public double CalcWeeklyPay()
        {
            return 0;
        }

        //Properties - the information that populated the fields. Generally named the same as the field/attribute, but with a capital
        //Getters - Allows for protected/private information to be accessed using the new name.
        //Setters - Allows us to set the field/attribute with specific options.
        public string ID { get { return id; } }
        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public string Phone { get { return phone; } }
        public long Sin { get { return sin; } }
        public string Dateofbirth { get { return dateofbirth; } }
        public string Department { get { return department; } }
    }
}
