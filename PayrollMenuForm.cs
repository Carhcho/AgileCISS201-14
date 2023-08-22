using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox14
{
    public partial class PayrollMenuForm : Form
    {
        public PayrollMenuForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewEmployeeButton_Click(object sender, EventArgs e)
        {
            //create an instance of NewEmployee
            NewEmployee entryForm = new NewEmployee();
            //call the showDialog method of NewEmployee
            entryForm.ShowDialog();
        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {
            //create an instance of DisplayForm
            DisplayForm displayForm = new DisplayForm();
            displayForm.ShowDialog();
        }

        private void addHoursWorkedButton_Click(object sender, EventArgs e)
        {
            //create a new instance of HousWorkedForm
            HoursWorkedForm hoursForm = new HoursWorkedForm();
            hoursForm.ShowDialog();
        }
    }
}
