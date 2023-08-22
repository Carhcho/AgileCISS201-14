using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox14
{
    class Employee
    {
        //fields
        private string employeeId;
        private string employeeName;
        private double hoursWorked;
        private decimal payRate;
        //properties
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }
        public decimal PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }
        //constructor
        public Employee(string employeeId, string employeeName, decimal payRate)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.payRate = payRate;
        }
        public Employee(string employeeId, string employeeName, double hoursWorked, decimal payRate)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.hoursWorked = hoursWorked;
            this.payRate = payRate;
        }
        //method
        public decimal GetPayAmount()
        {
            decimal payAmount;
            payAmount = (decimal)HoursWorked * PayRate;
            return payAmount;
        }
        //ToString method
        public override string ToString()
        {
            string str;
            str = string.Format("Employee Id: {0} Employee Name: {1} Pay Amount: {2:C}", EmployeeId, EmployeeName, GetPayAmount());
            return str;
        }
    }
}
