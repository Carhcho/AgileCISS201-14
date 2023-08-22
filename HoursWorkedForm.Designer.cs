namespace dropbox14
{
    partial class HoursWorkedForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeAndSaveButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.hoursWorkedTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hours Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours worked:";
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(391, 221);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(156, 20);
            this.hoursWorkedTextBox.TabIndex = 5;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(123, 379);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "&Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(338, 379);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeAndSaveButton
            // 
            this.closeAndSaveButton.Location = new System.Drawing.Point(563, 379);
            this.closeAndSaveButton.Name = "closeAndSaveButton";
            this.closeAndSaveButton.Size = new System.Drawing.Size(115, 23);
            this.closeAndSaveButton.TabIndex = 3;
            this.closeAndSaveButton.Text = "Close and &Save";
            this.closeAndSaveButton.UseVisualStyleBackColor = true;
            this.closeAndSaveButton.Click += new System.EventHandler(this.closeAndSaveButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idLabel.Location = new System.Drawing.Point(388, 45);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(159, 23);
            this.idLabel.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameLabel.Location = new System.Drawing.Point(388, 136);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(159, 23);
            this.nameLabel.TabIndex = 7;
            // 
            // HoursWorkedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeAndSaveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "HoursWorkedForm";
            this.Text = "HoursWorkedForm";
            this.Load += new System.EventHandler(this.HoursWorkedForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeAndSaveButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
    }
}