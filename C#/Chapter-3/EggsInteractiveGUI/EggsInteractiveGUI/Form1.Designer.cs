namespace EggsInteractiveGUI
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
            chicken1Label = new Label();
            chicken2Label = new Label();
            chicken3Label = new Label();
            chicken4Label = new Label();
            chicken5Label = new Label();
            chicken1Input = new TextBox();
            chicken2Input = new TextBox();
            chicken3Input = new TextBox();
            chicken4Input = new TextBox();
            chicken5Input = new TextBox();
            calculateEggs = new Button();
            dozensOfEggsLabel = new Label();
            singleEggsLabel = new Label();
            dozensOfEggsDisplay = new Label();
            SingleEggsDisplay = new Label();
            SuspendLayout();
            // 
            // chicken1Label
            // 
            chicken1Label.AutoSize = true;
            chicken1Label.Location = new Point(12, 9);
            chicken1Label.Name = "chicken1Label";
            chicken1Label.Size = new Size(131, 15);
            chicken1Label.TabIndex = 0;
            chicken1Label.Text = "Chicken 1 eggs/month:";
            // 
            // chicken2Label
            // 
            chicken2Label.AutoSize = true;
            chicken2Label.Location = new Point(12, 38);
            chicken2Label.Name = "chicken2Label";
            chicken2Label.Size = new Size(131, 15);
            chicken2Label.TabIndex = 1;
            chicken2Label.Text = "Chicken 2 eggs/month:";
            // 
            // chicken3Label
            // 
            chicken3Label.AutoSize = true;
            chicken3Label.Location = new Point(12, 67);
            chicken3Label.Name = "chicken3Label";
            chicken3Label.Size = new Size(131, 15);
            chicken3Label.TabIndex = 2;
            chicken3Label.Text = "Chicken 3 eggs/month:";
            // 
            // chicken4Label
            // 
            chicken4Label.AutoSize = true;
            chicken4Label.Location = new Point(12, 96);
            chicken4Label.Name = "chicken4Label";
            chicken4Label.Size = new Size(131, 15);
            chicken4Label.TabIndex = 3;
            chicken4Label.Text = "Chicken 4 eggs/month:";
            // 
            // chicken5Label
            // 
            chicken5Label.AutoSize = true;
            chicken5Label.Location = new Point(12, 125);
            chicken5Label.Name = "chicken5Label";
            chicken5Label.Size = new Size(131, 15);
            chicken5Label.TabIndex = 4;
            chicken5Label.Text = "Chicken 5 eggs/month:";
            // 
            // chicken1Input
            // 
            chicken1Input.Location = new Point(149, 6);
            chicken1Input.Name = "chicken1Input";
            chicken1Input.Size = new Size(100, 23);
            chicken1Input.TabIndex = 5;
            // 
            // chicken2Input
            // 
            chicken2Input.Location = new Point(149, 35);
            chicken2Input.Name = "chicken2Input";
            chicken2Input.Size = new Size(100, 23);
            chicken2Input.TabIndex = 6;
            // 
            // chicken3Input
            // 
            chicken3Input.Location = new Point(149, 64);
            chicken3Input.Name = "chicken3Input";
            chicken3Input.Size = new Size(100, 23);
            chicken3Input.TabIndex = 7;
            // 
            // chicken4Input
            // 
            chicken4Input.Location = new Point(149, 93);
            chicken4Input.Name = "chicken4Input";
            chicken4Input.Size = new Size(100, 23);
            chicken4Input.TabIndex = 8;
            // 
            // chicken5Input
            // 
            chicken5Input.Location = new Point(149, 122);
            chicken5Input.Name = "chicken5Input";
            chicken5Input.Size = new Size(100, 23);
            chicken5Input.TabIndex = 9;
            // 
            // calculateEggs
            // 
            calculateEggs.Location = new Point(149, 151);
            calculateEggs.Name = "calculateEggs";
            calculateEggs.Size = new Size(100, 23);
            calculateEggs.TabIndex = 10;
            calculateEggs.Text = "Calculate";
            calculateEggs.UseVisualStyleBackColor = true;
            calculateEggs.Click += calculateEggs_Click;
            // 
            // dozensOfEggsLabel
            // 
            dozensOfEggsLabel.AutoSize = true;
            dozensOfEggsLabel.Location = new Point(12, 183);
            dozensOfEggsLabel.Name = "dozensOfEggsLabel";
            dozensOfEggsLabel.Size = new Size(131, 15);
            dozensOfEggsLabel.TabIndex = 11;
            dozensOfEggsLabel.Text = "Dozens of eggs/month:";
            // 
            // singleEggsLabel
            // 
            singleEggsLabel.AutoSize = true;
            singleEggsLabel.Location = new Point(12, 212);
            singleEggsLabel.Name = "singleEggsLabel";
            singleEggsLabel.Size = new Size(111, 15);
            singleEggsLabel.TabIndex = 12;
            singleEggsLabel.Text = "Single eggs/month:";
            // 
            // dozensOfEggsDisplay
            // 
            dozensOfEggsDisplay.AutoSize = true;
            dozensOfEggsDisplay.Location = new Point(149, 183);
            dozensOfEggsDisplay.Name = "dozensOfEggsDisplay";
            dozensOfEggsDisplay.Size = new Size(69, 15);
            dozensOfEggsDisplay.TabIndex = 13;
            dozensOfEggsDisplay.Text = "Placeholder";
            dozensOfEggsDisplay.Visible = false;
            // 
            // SingleEggsDisplay
            // 
            SingleEggsDisplay.AutoSize = true;
            SingleEggsDisplay.Location = new Point(149, 212);
            SingleEggsDisplay.Name = "SingleEggsDisplay";
            SingleEggsDisplay.Size = new Size(69, 15);
            SingleEggsDisplay.TabIndex = 14;
            SingleEggsDisplay.Text = "Placeholder";
            SingleEggsDisplay.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 244);
            Controls.Add(SingleEggsDisplay);
            Controls.Add(dozensOfEggsDisplay);
            Controls.Add(singleEggsLabel);
            Controls.Add(dozensOfEggsLabel);
            Controls.Add(calculateEggs);
            Controls.Add(chicken5Input);
            Controls.Add(chicken4Input);
            Controls.Add(chicken3Input);
            Controls.Add(chicken2Input);
            Controls.Add(chicken1Input);
            Controls.Add(chicken5Label);
            Controls.Add(chicken4Label);
            Controls.Add(chicken3Label);
            Controls.Add(chicken2Label);
            Controls.Add(chicken1Label);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label chicken1Label;
        private Label chicken2Label;
        private Label chicken3Label;
        private Label chicken4Label;
        private Label chicken5Label;
        private TextBox chicken1Input;
        private TextBox chicken2Input;
        private TextBox chicken3Input;
        private TextBox chicken4Input;
        private TextBox chicken5Input;
        private Button calculateEggs;
        private Label dozensOfEggsLabel;
        private Label singleEggsLabel;
        private Label dozensOfEggsDisplay;
        private Label SingleEggsDisplay;
    }
}
