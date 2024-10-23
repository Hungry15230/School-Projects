namespace MonthNamesGUI
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
            monthNumberInput = new TextBox();
            monthNumberLabel = new Label();
            calculate = new Button();
            desiredMonthLabel = new Label();
            desiredMonthOutput = new Label();
            SuspendLayout();
            // 
            // monthNumberInput
            // 
            monthNumberInput.Location = new Point(111, 12);
            monthNumberInput.Name = "monthNumberInput";
            monthNumberInput.Size = new Size(100, 23);
            monthNumberInput.TabIndex = 0;
            // 
            // monthNumberLabel
            // 
            monthNumberLabel.AutoSize = true;
            monthNumberLabel.Location = new Point(12, 15);
            monthNumberLabel.Name = "monthNumberLabel";
            monthNumberLabel.Size = new Size(93, 15);
            monthNumberLabel.TabIndex = 1;
            monthNumberLabel.Text = "Month Number:";
            // 
            // calculate
            // 
            calculate.Location = new Point(111, 41);
            calculate.Name = "calculate";
            calculate.Size = new Size(100, 23);
            calculate.TabIndex = 2;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // desiredMonthLabel
            // 
            desiredMonthLabel.AutoSize = true;
            desiredMonthLabel.Location = new Point(12, 73);
            desiredMonthLabel.Name = "desiredMonthLabel";
            desiredMonthLabel.Size = new Size(88, 15);
            desiredMonthLabel.TabIndex = 4;
            desiredMonthLabel.Text = "Desired Month:";
            // 
            // desiredMonthOutput
            // 
            desiredMonthOutput.AutoSize = true;
            desiredMonthOutput.Location = new Point(111, 73);
            desiredMonthOutput.Name = "desiredMonthOutput";
            desiredMonthOutput.Size = new Size(71, 15);
            desiredMonthOutput.TabIndex = 5;
            desiredMonthOutput.Text = "PlaceHolder";
            desiredMonthOutput.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 107);
            Controls.Add(desiredMonthOutput);
            Controls.Add(desiredMonthLabel);
            Controls.Add(calculate);
            Controls.Add(monthNumberLabel);
            Controls.Add(monthNumberInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox monthNumberInput;
        private Label monthNumberLabel;
        private Button calculate;
        private Label desiredMonthLabel;
        private Label desiredMonthOutput;
    }
}
