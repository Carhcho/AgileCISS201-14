using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace dropbox14
{
    public partial class HoursWorkedForm : Form
    {
        List<Employee> allEmployee = new List<Employee>();
        public HoursWorkedForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Clear();
            hoursWorkedTextBox.Focus();
        }

        private void HoursWorkedForm_Load(object sender, EventArgs e)
        {
            if(File.Exists("employee.txt"))
            {
                using (StreamReader sr = new StreamReader("employee.txt"))
                {
                    string employeeId = "";
                    while((employeeId = sr.ReadLine()) != null)
                    {
                        Employee emp = new Employee(employeeId, sr.ReadLine(), decimal.Parse(sr.ReadLine()));
                        sr.ReadLine();
                        allEmployee.Add(emp);
                    }
                    //display first employee
                    if(allEmployee.Count > 0)
                    {
                        idLabel.Text = allEmployee[0].EmployeeId;
                        nameLabel.Text = allEmployee[0].EmployeeName;
                    }
                    else
                    {
                        MessageBox.Show("No employee in the file.");
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Missing employee.txt");
                Close();
            }
            
        }

        int count = 1;
        private void nextButton_Click(object sender, EventArgs e)
        {
            //add hours worked to the array
            allEmployee[count - 1].HoursWorked = double.Parse(hoursWorkedTextBox.Text);
            if(count < allEmployee.Count)
            {
                idLabel.Text = allEmployee[count].EmployeeId;
                nameLabel.Text = allEmployee[count].EmployeeName;
                count++;
            }
            else
            {
                MessageBox.Show("no more employees.");
            }
        }
        private void closeAndSaveButton_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw= File.CreateText("employee.txt"))
            {
                foreach(Employee emp in allEmployee)
                {
                    sw.WriteLine(emp.EmployeeId);
                    sw.WriteLine(emp.EmployeeName);
                    sw.WriteLine(emp.HoursWorked);
                    sw.WriteLine(emp.PayRate);
                }
            }
            Close();
        }
    }
}
