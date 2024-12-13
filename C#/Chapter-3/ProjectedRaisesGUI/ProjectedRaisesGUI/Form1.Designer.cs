namespace ProjectedRaisesGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculateButton = new Button();
            employee1Salary = new Label();
            employee2Salary = new Label();
            employee3Salary = new Label();
            employee1SalaryInput = new TextBox();
            employee2SalaryInput = new TextBox();
            employee3SalaryInput = new TextBox();
            employee3DescLabel = new Label();
            employee2DescLabel = new Label();
            employee1DescLabel = new Label();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(131, 93);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(100, 23);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // employee1Salary
            // 
            employee1Salary.AutoSize = true;
            employee1Salary.Location = new Point(12, 9);
            employee1Salary.Name = "employee1Salary";
            employee1Salary.Size = new Size(113, 15);
            employee1Salary.TabIndex = 1;
            employee1Salary.Text = "Employee 1's Salary:";
            // 
            // employee2Salary
            // 
            employee2Salary.AutoSize = true;
            employee2Salary.Location = new Point(12, 38);
            employee2Salary.Name = "employee2Salary";
            employee2Salary.Size = new Size(113, 15);
            employee2Salary.TabIndex = 2;
            employee2Salary.Text = "Employee 2's Salary:";
            // 
            // employee3Salary
            // 
            employee3Salary.AutoSize = true;
            employee3Salary.Location = new Point(12, 67);
            employee3Salary.Name = "employee3Salary";
            employee3Salary.Size = new Size(113, 15);
            employee3Salary.TabIndex = 3;
            employee3Salary.Text = "Employee 3's Salary:";
            // 
            // employee1SalaryInput
            // 
            employee1SalaryInput.Location = new Point(131, 6);
            employee1SalaryInput.Name = "employee1SalaryInput";
            employee1SalaryInput.Size = new Size(100, 23);
            employee1SalaryInput.TabIndex = 5;
            // 
            // employee2SalaryInput
            // 
            employee2SalaryInput.Location = new Point(131, 35);
            employee2SalaryInput.Name = "employee2SalaryInput";
            employee2SalaryInput.Size = new Size(100, 23);
            employee2SalaryInput.TabIndex = 6;
            // 
            // employee3SalaryInput
            // 
            employee3SalaryInput.Location = new Point(131, 64);
            employee3SalaryInput.Name = "employee3SalaryInput";
            employee3SalaryInput.Size = new Size(100, 23);
            employee3SalaryInput.TabIndex = 7;
            // 
            // employee3DescLabel
            // 
            employee3DescLabel.AutoSize = true;
            employee3DescLabel.Location = new Point(429, 134);
            employee3DescLabel.MaximumSize = new Size(200, 0);
            employee3DescLabel.Name = "employee3DescLabel";
            employee3DescLabel.Size = new Size(69, 15);
            employee3DescLabel.TabIndex = 8;
            employee3DescLabel.Text = "Placeholder";
            employee3DescLabel.Visible = false;
            // 
            // employee2DescLabel
            // 
            employee2DescLabel.AutoSize = true;
            employee2DescLabel.Location = new Point(225, 134);
            employee2DescLabel.MaximumSize = new Size(200, 0);
            employee2DescLabel.Name = "employee2DescLabel";
            employee2DescLabel.Size = new Size(69, 15);
            employee2DescLabel.TabIndex = 9;
            employee2DescLabel.Text = "Placeholder";
            employee2DescLabel.Visible = false;
            // 
            // employee1DescLabel
            // 
            employee1DescLabel.AutoSize = true;
            employee1DescLabel.Location = new Point(12, 134);
            employee1DescLabel.MaximumSize = new Size(200, 0);
            employee1DescLabel.Name = "employee1DescLabel";
            employee1DescLabel.Size = new Size(69, 15);
            employee1DescLabel.TabIndex = 10;
            employee1DescLabel.Text = "Placeholder";
            employee1DescLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 450);
            Controls.Add(employee1DescLabel);
            Controls.Add(employee2DescLabel);
            Controls.Add(employee3DescLabel);
            Controls.Add(employee3SalaryInput);
            Controls.Add(employee2SalaryInput);
            Controls.Add(employee1SalaryInput);
            Controls.Add(employee3Salary);
            Controls.Add(employee2Salary);
            Controls.Add(employee1Salary);
            Controls.Add(calculateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private Label employee1Salary;
        private Label employee2Salary;
        private Label employee3Salary;
        private TextBox employee1SalaryInput;
        private TextBox employee2SalaryInput;
        private TextBox employee3SalaryInput;
        private Label employee3DescLabel;
        private Label employee2DescLabel;
        protected Label employee1DescLabel;
    }
}
