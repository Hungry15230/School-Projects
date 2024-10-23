using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            sum = num1 + num2;
            labelAnswer.Text = "Sum is " + sum;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
