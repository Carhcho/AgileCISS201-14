namespace dropbox14
{
    partial class PayrollMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNewEmployeeButton = new System.Windows.Forms.Button();
            this.addHoursWorkedButton = new System.Windows.Forms.Button();
            this.displayAllButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNewEmployeeButton
            // 
            this.addNewEmployeeButton.Location = new System.Drawing.Point(200, 134);
            this.addNewEmployeeButton.Name = "addNewEmployeeButton";
            this.addNewEmployeeButton.Size = new System.Drawing.Size(91, 73);
            this.addNewEmployeeButton.TabIndex = 0;
            this.addNewEmployeeButton.Text = "&Add New Employee";
            this.addNewEmployeeButton.UseVisualStyleBackColor = true;
            this.addNewEmployeeButton.Click += new System.EventHandler(this.addNewEmployeeButton_Click);
            // 
            // addHoursWorkedButton
            // 
            this.addHoursWorkedButton.Location = new System.Drawing.Point(511, 134);
            this.addHoursWorkedButton.Name = "addHoursWorkedButton";
            this.addHoursWorkedButton.Size = new System.Drawing.Size(91, 73);
            this.addHoursWorkedButton.TabIndex = 1;
            this.addHoursWorkedButton.Text = "Add &Hours Worked";
            this.addHoursWorkedButton.UseVisualStyleBackColor = true;
            this.addHoursWorkedButton.Click += new System.EventHandler(this.addHoursWorkedButton_Click);
            // 
            // displayAllButton
            // 
            this.displayAllButton.Location = new System.Drawing.Point(200, 272);
            this.displayAllButton.Name = "displayAllButton";
            this.displayAllButton.Size = new System.Drawing.Size(91, 85);
            this.displayAllButton.TabIndex = 2;
            this.displayAllButton.Text = "&Display All";
            this.displayAllButton.UseVisualStyleBackColor = true;
            this.displayAllButton.Click += new System.EventHandler(this.displayAllButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(511, 272);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 85);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee Payroll System";
            // 
            // PayrollMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayAllButton);
            this.Controls.Add(this.addHoursWorkedButton);
            this.Controls.Add(this.addNewEmployeeButton);
            this.Name = "PayrollMenuForm";
            this.Text = "Payroll Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewEmployeeButton;
        private System.Windows.Forms.Button addHoursWorkedButton;
        private System.Windows.Forms.Button displayAllButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

