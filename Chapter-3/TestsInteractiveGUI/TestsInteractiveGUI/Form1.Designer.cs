namespace TestsInteractiveGUI
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
            test1Input = new TextBox();
            test1Label = new Label();
            test2Input = new TextBox();
            test3Input = new TextBox();
            test4Input = new TextBox();
            test5Input = new TextBox();
            test2Label = new Label();
            test3Label = new Label();
            test4Label = new Label();
            test5Label = new Label();
            calculateButton = new Button();
            gradeAverageOutput = new Label();
            gradeAverageLabel = new Label();
            SuspendLayout();
            // 
            // test1Input
            // 
            test1Input.Location = new Point(91, 12);
            test1Input.Name = "test1Input";
            test1Input.Size = new Size(100, 23);
            test1Input.TabIndex = 0;
            // 
            // test1Label
            // 
            test1Label.AutoSize = true;
            test1Label.Location = new Point(12, 15);
            test1Label.Name = "test1Label";
            test1Label.Size = new Size(73, 15);
            test1Label.TabIndex = 1;
            test1Label.Text = "Test 1 Grade:";
            // 
            // test2Input
            // 
            test2Input.Location = new Point(91, 41);
            test2Input.Name = "test2Input";
            test2Input.Size = new Size(100, 23);
            test2Input.TabIndex = 2;
            // 
            // test3Input
            // 
            test3Input.Location = new Point(91, 70);
            test3Input.Name = "test3Input";
            test3Input.Size = new Size(100, 23);
            test3Input.TabIndex = 3;
            // 
            // test4Input
            // 
            test4Input.Location = new Point(91, 99);
            test4Input.Name = "test4Input";
            test4Input.Size = new Size(100, 23);
            test4Input.TabIndex = 4;
            // 
            // test5Input
            // 
            test5Input.Location = new Point(91, 128);
            test5Input.Name = "test5Input";
            test5Input.Size = new Size(100, 23);
            test5Input.TabIndex = 5;
            // 
            // test2Label
            // 
            test2Label.AutoSize = true;
            test2Label.Location = new Point(12, 44);
            test2Label.Name = "test2Label";
            test2Label.Size = new Size(73, 15);
            test2Label.TabIndex = 6;
            test2Label.Text = "Test 2 Grade:";
            // 
            // test3Label
            // 
            test3Label.AutoSize = true;
            test3Label.Location = new Point(12, 73);
            test3Label.Name = "test3Label";
            test3Label.Size = new Size(73, 15);
            test3Label.TabIndex = 7;
            test3Label.Text = "Test 3 Grade:";
            // 
            // test4Label
            // 
            test4Label.AutoSize = true;
            test4Label.Location = new Point(12, 102);
            test4Label.Name = "test4Label";
            test4Label.Size = new Size(73, 15);
            test4Label.TabIndex = 8;
            test4Label.Text = "Test 4 Grade:";
            // 
            // test5Label
            // 
            test5Label.AutoSize = true;
            test5Label.Location = new Point(12, 131);
            test5Label.Name = "test5Label";
            test5Label.Size = new Size(73, 15);
            test5Label.TabIndex = 9;
            test5Label.Text = "Test 5 Grade:";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(91, 157);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(100, 23);
            calculateButton.TabIndex = 10;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // gradeAverageOutput
            // 
            gradeAverageOutput.AutoSize = true;
            gradeAverageOutput.Location = new Point(105, 183);
            gradeAverageOutput.Name = "gradeAverageOutput";
            gradeAverageOutput.Size = new Size(71, 15);
            gradeAverageOutput.TabIndex = 11;
            gradeAverageOutput.Text = "PlaceHolder";
            gradeAverageOutput.Visible = false;
            // 
            // gradeAverageLabel
            // 
            gradeAverageLabel.AutoSize = true;
            gradeAverageLabel.Location = new Point(12, 183);
            gradeAverageLabel.Name = "gradeAverageLabel";
            gradeAverageLabel.Size = new Size(87, 15);
            gradeAverageLabel.TabIndex = 12;
            gradeAverageLabel.Text = "Grade Average:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 219);
            Controls.Add(gradeAverageLabel);
            Controls.Add(gradeAverageOutput);
            Controls.Add(calculateButton);
            Controls.Add(test5Label);
            Controls.Add(test4Label);
            Controls.Add(test3Label);
            Controls.Add(test2Label);
            Controls.Add(test5Input);
            Controls.Add(test4Input);
            Controls.Add(test3Input);
            Controls.Add(test2Input);
            Controls.Add(test1Label);
            Controls.Add(test1Input);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox test1Input;
        private Label test1Label;
        private TextBox test2Input;
        private TextBox test3Input;
        private TextBox test4Input;
        private TextBox test5Input;
        private Label test2Label;
        private Label test3Label;
        private Label test4Label;
        private Label test5Label;
        private Button calculateButton;
        private Label gradeAverageOutput;
        private Label gradeAverageLabel;
    }
}
