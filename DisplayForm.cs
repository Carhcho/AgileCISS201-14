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

namespace dropbox14
{
    public partial class DisplayForm : Form
    {
        //a list that includes all employees
        List<Employee> allEmployee = new List<Employee>();
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("employee.txt"))
            {
                using (StreamReader sr = new StreamReader("employee.txt"))
                {
                    string id;
                    int i = 0;
                    while ((id = sr.ReadLine()) != null)
                    {
                        string name = sr.ReadLine();
                        double hours = double.Parse(sr.ReadLine());
                        decimal pay = decimal.Parse(sr.ReadLine());
                        //create the employee
                        Employee s = new Employee(id, name, hours, pay);
                        //add the employee to the list
                        allEmployee.Add(s);
                        //add the employee to the listbox
                        allEmployeesListBox.Items.Add(s);
                        Console.WriteLine(allEmployee[i]);
                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Missing employee.txt");
                Close();
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //print a header
            e.Graphics.DrawString("Employee Report", new Font("Courier New", 24, FontStyle.Bold), Brushes.Black, 200, 100);
            //print date and time
            e.Graphics.DrawString(DateTime.Now.ToString(), new Font("Courier New", 10, FontStyle.Italic), Brushes.Black, 240, 150);
            //print each student in a loop
            int x = 100, y = 200;
            foreach (Employee s in allEmployee)
            {
                e.Graphics.DrawString(s.ToString(), new Font("Courier New", 10, FontStyle.Regular), Brushes.Black, x, y);
                y += 15;
            }

        }
    }
}
