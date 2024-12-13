namespace InchesToCentimetersGUI
{
    partial class InchesToCentimeters
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
            inchesInput = new TextBox();
            inchesLabel = new Label();
            convertButton = new Button();
            centimetersLabel = new Label();
            centimetersOutput = new Label();
            SuspendLayout();
            // 
            // inchesInput
            // 
            inchesInput.Location = new Point(92, 12);
            inchesInput.Name = "inchesInput";
            inchesInput.Size = new Size(121, 23);
            inchesInput.TabIndex = 0;
            // 
            // inchesLabel
            // 
            inchesLabel.AutoSize = true;
            inchesLabel.Location = new Point(42, 15);
            inchesLabel.Name = "inchesLabel";
            inchesLabel.Size = new Size(44, 15);
            inchesLabel.TabIndex = 1;
            inchesLabel.Text = "Inches:";
            // 
            // convertButton
            // 
            convertButton.Location = new Point(12, 41);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(201, 23);
            convertButton.TabIndex = 2;
            convertButton.Text = "Convert to centimeters";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // centimetersLabel
            // 
            centimetersLabel.AutoSize = true;
            centimetersLabel.Location = new Point(12, 73);
            centimetersLabel.Name = "centimetersLabel";
            centimetersLabel.Size = new Size(74, 15);
            centimetersLabel.TabIndex = 4;
            centimetersLabel.Text = "Centimeters:";
            // 
            // centimetersOutput
            // 
            centimetersOutput.AutoSize = true;
            centimetersOutput.Location = new Point(92, 73);
            centimetersOutput.Name = "centimetersOutput";
            centimetersOutput.Size = new Size(0, 15);
            centimetersOutput.TabIndex = 5;
            // 
            // InchesToCentimeters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 101);
            Controls.Add(centimetersOutput);
            Controls.Add(centimetersLabel);
            Controls.Add(convertButton);
            Controls.Add(inchesLabel);
            Controls.Add(inchesInput);
            Name = "InchesToCentimeters";
            Text = "In to cm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inchesInput;
        private Label inchesLabel;
        private Button convertButton;
        private Label centimetersLabel;
        private Label centimetersOutput;
    }
}
