namespace MoveEstimatorGUI
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
            label1 = new Label();
            label2 = new Label();
            hoursInput = new TextBox();
            milesInput = new TextBox();
            finalFeeLabel = new Label();
            finalFeeDisplay = new Label();
            calculateFee = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 0;
            label1.Text = "Hours required to move:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 43);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 1;
            label2.Text = "Miles required to move:";
            // 
            // hoursInput
            // 
            hoursInput.Location = new Point(154, 6);
            hoursInput.Name = "hoursInput";
            hoursInput.Size = new Size(100, 23);
            hoursInput.TabIndex = 2;
            // 
            // milesInput
            // 
            milesInput.Location = new Point(154, 40);
            milesInput.Name = "milesInput";
            milesInput.Size = new Size(100, 23);
            milesInput.TabIndex = 3;
            // 
            // finalFeeLabel
            // 
            finalFeeLabel.AutoSize = true;
            finalFeeLabel.Location = new Point(43, 113);
            finalFeeLabel.Name = "finalFeeLabel";
            finalFeeLabel.Size = new Size(105, 15);
            finalFeeLabel.TabIndex = 4;
            finalFeeLabel.Text = "Final Moving Fees:";
            // 
            // finalFeeDisplay
            // 
            finalFeeDisplay.AutoSize = true;
            finalFeeDisplay.Location = new Point(154, 113);
            finalFeeDisplay.Name = "finalFeeDisplay";
            finalFeeDisplay.Size = new Size(69, 15);
            finalFeeDisplay.TabIndex = 5;
            finalFeeDisplay.Text = "Placeholder";
            finalFeeDisplay.Visible = false;
            // 
            // calculateFee
            // 
            calculateFee.Location = new Point(154, 78);
            calculateFee.Name = "calculateFee";
            calculateFee.Size = new Size(100, 23);
            calculateFee.TabIndex = 6;
            calculateFee.Text = "Calculate Fee";
            calculateFee.UseVisualStyleBackColor = true;
            calculateFee.Click += calculateFee_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 155);
            Controls.Add(calculateFee);
            Controls.Add(finalFeeDisplay);
            Controls.Add(finalFeeLabel);
            Controls.Add(milesInput);
            Controls.Add(hoursInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox hoursInput;
        private TextBox milesInput;
        private Label finalFeeLabel;
        private Label finalFeeDisplay;
        private Button calculateFee;
    }
}
