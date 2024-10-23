
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.buttonJesse = new System.Windows.Forms.Button();
            this.labelJesse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEnterNumber = new System.Windows.Forms.Label();
            this.labelEnterNumber2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonJesse
            // 
            this.buttonJesse.Location = new System.Drawing.Point(15, 103);
            this.buttonJesse.Name = "buttonJesse";
            this.buttonJesse.Size = new System.Drawing.Size(85, 28);
            this.buttonJesse.TabIndex = 0;
            this.buttonJesse.Text = "Click to add.";
            this.buttonJesse.UseVisualStyleBackColor = true;
            this.buttonJesse.Click += new System.EventHandler(this.buttonAdd);
            // 
            // labelJesse
            // 
            this.labelJesse.AutoSize = true;
            this.labelJesse.Location = new System.Drawing.Point(12, 9);
            this.labelJesse.Name = "labelJesse";
            this.labelJesse.Size = new System.Drawing.Size(88, 13);
            this.labelJesse.TabIndex = 1;
            this.labelJesse.Text = "Welcome, Jesse.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.AutoSize = true;
            this.labelEnterNumber.Location = new System.Drawing.Point(42, 41);
            this.labelEnterNumber.Name = "labelEnterNumber";
            this.labelEnterNumber.Size = new System.Drawing.Size(82, 13);
            this.labelEnterNumber.TabIndex = 3;
            this.labelEnterNumber.Text = "Enter a number:";
            // 
            // labelEnterNumber2
            // 
            this.labelEnterNumber2.AutoSize = true;
            this.labelEnterNumber2.Location = new System.Drawing.Point(12, 69);
            this.labelEnterNumber2.Name = "labelEnterNumber2";
            this.labelEnterNumber2.Size = new System.Drawing.Size(112, 13);
            this.labelEnterNumber2.TabIndex = 4;
            this.labelEnterNumber2.Text = "Enter another number:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(130, 103);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(0, 13);
            this.labelAnswer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 156);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelEnterNumber2);
            this.Controls.Add(this.labelEnterNumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelJesse);
            this.Controls.Add(this.buttonJesse);
            this.Name = "Form1";
            this.Text = "Addition Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJesse;
        private System.Windows.Forms.Label labelJesse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelEnterNumber;
        private System.Windows.Forms.Label labelEnterNumber2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelAnswer;
    }
}

