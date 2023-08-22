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
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            payRateTextBox.Clear();
            idTextBox.Focus();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw= File.AppendText("employee.txt"))
            {
                if(!((string.IsNullOrWhiteSpace(idTextBox.Text)) ||
                    (string.IsNullOrWhiteSpace(nameTextBox.Text)) ||
                    (string.IsNullOrWhiteSpace(payRateTextBox.Text))))
                {
                    //save the textboxes content to the file
                    sw.WriteLine(idTextBox.Text);
                    sw.WriteLine(nameTextBox.Text);
                    sw.WriteLine("40.00");
                    sw.WriteLine(payRateTextBox.Text);                    
                    //clear the textboxes
                    clearButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("All fields must be filled.");
                }
            }
        }
    }
}
