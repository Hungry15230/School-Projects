using System.Security.Cryptography;

namespace MakeChangeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int dollars = Convert.ToInt16(dollarsInput.Text);
            int startingDollars = dollars;
            int twenties = dollars / 20;
            dollars = dollars % 20;
            int tens = dollars / 10;
            dollars = dollars % 10;
            int fives = dollars / 5;
            dollars = dollars % 5;
            int ones = dollars / 1;
            dollars = dollars % 1;

            twentiesOutput.Text = Convert.ToString(twenties);
            tensOutput.Text = Convert.ToString(tens);
            fivesOutput.Text = Convert.ToString(fives);
            onesOutput.Text = Convert.ToString(ones);

            twentiesOutput.Visible = true;
            tensOutput.Visible = true;
            fivesOutput.Visible = true;
            onesOutput.Visible = true;
        }
    }
}
