namespace MakeChangeGUI
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
            dollarsInput = new TextBox();
            dollarsLabel = new Label();
            calculateButton = new Button();
            twentiesLabel = new Label();
            twentiesOutput = new Label();
            tensOutput = new Label();
            tensLabel = new Label();
            fivesOutput = new Label();
            fivesLabel = new Label();
            onesOutput = new Label();
            onesLabel = new Label();
            SuspendLayout();
            // 
            // dollarsInput
            // 
            dollarsInput.Location = new Point(64, 12);
            dollarsInput.Name = "dollarsInput";
            dollarsInput.Size = new Size(100, 23);
            dollarsInput.TabIndex = 0;
            // 
            // dollarsLabel
            // 
            dollarsLabel.AutoSize = true;
            dollarsLabel.Location = new Point(12, 15);
            dollarsLabel.Name = "dollarsLabel";
            dollarsLabel.Size = new Size(46, 15);
            dollarsLabel.TabIndex = 1;
            dollarsLabel.Text = "Dollars:";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(64, 41);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(100, 23);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // twentiesLabel
            // 
            twentiesLabel.AutoSize = true;
            twentiesLabel.Location = new Point(3, 67);
            twentiesLabel.Name = "twentiesLabel";
            twentiesLabel.Size = new Size(55, 15);
            twentiesLabel.TabIndex = 3;
            twentiesLabel.Text = "Twenties:";
            // 
            // twentiesOutput
            // 
            twentiesOutput.AutoSize = true;
            twentiesOutput.Location = new Point(64, 67);
            twentiesOutput.Name = "twentiesOutput";
            twentiesOutput.Size = new Size(69, 15);
            twentiesOutput.TabIndex = 4;
            twentiesOutput.Text = "Placeholder";
            twentiesOutput.Visible = false;
            // 
            // tensOutput
            // 
            tensOutput.AutoSize = true;
            tensOutput.Location = new Point(64, 82);
            tensOutput.Name = "tensOutput";
            tensOutput.Size = new Size(69, 15);
            tensOutput.TabIndex = 5;
            tensOutput.Text = "Placeholder";
            tensOutput.Visible = false;
            // 
            // tensLabel
            // 
            tensLabel.AutoSize = true;
            tensLabel.Location = new Point(3, 82);
            tensLabel.Name = "tensLabel";
            tensLabel.Size = new Size(33, 15);
            tensLabel.TabIndex = 6;
            tensLabel.Text = "Tens:";
            // 
            // fivesOutput
            // 
            fivesOutput.AutoSize = true;
            fivesOutput.Location = new Point(64, 97);
            fivesOutput.Name = "fivesOutput";
            fivesOutput.Size = new Size(69, 15);
            fivesOutput.TabIndex = 7;
            fivesOutput.Text = "Placeholder";
            fivesOutput.Visible = false;
            // 
            // fivesLabel
            // 
            fivesLabel.AutoSize = true;
            fivesLabel.Location = new Point(3, 97);
            fivesLabel.Name = "fivesLabel";
            fivesLabel.Size = new Size(36, 15);
            fivesLabel.TabIndex = 8;
            fivesLabel.Text = "Fives:";
            // 
            // onesOutput
            // 
            onesOutput.AutoSize = true;
            onesOutput.Location = new Point(64, 112);
            onesOutput.Name = "onesOutput";
            onesOutput.Size = new Size(69, 15);
            onesOutput.TabIndex = 9;
            onesOutput.Text = "Placeholder";
            onesOutput.Visible = false;
            // 
            // onesLabel
            // 
            onesLabel.AutoSize = true;
            onesLabel.Location = new Point(3, 112);
            onesLabel.Name = "onesLabel";
            onesLabel.Size = new Size(37, 15);
            onesLabel.TabIndex = 10;
            onesLabel.Text = "Ones:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(176, 141);
            Controls.Add(onesLabel);
            Controls.Add(onesOutput);
            Controls.Add(fivesLabel);
            Controls.Add(fivesOutput);
            Controls.Add(tensLabel);
            Controls.Add(tensOutput);
            Controls.Add(twentiesOutput);
            Controls.Add(twentiesLabel);
            Controls.Add(calculateButton);
            Controls.Add(dollarsLabel);
            Controls.Add(dollarsInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dollarsInput;
        private Label dollarsLabel;
        private Button calculateButton;
        private Label twentiesLabel;
        private Label twentiesOutput;
        private Label tensOutput;
        private Label tensLabel;
        private Label fivesOutput;
        private Label fivesLabel;
        private Label onesOutput;
        private Label onesLabel;
    }
}
