namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateEggs_Click(object sender, EventArgs e)
        {
            double chicken1EggsPerMonth = Convert.ToDouble(chicken1Input.Text);
            double chicken2EggsPerMonth = Convert.ToDouble(chicken2Input.Text);
            double chicken3EggsPerMonth = Convert.ToDouble(chicken3Input.Text);
            double chicken4EggsPerMonth = Convert.ToDouble(chicken4Input.Text);
            double chicken5EggsPerMonth = Convert.ToDouble(chicken5Input.Text);

            double sumOfEggs = chicken1EggsPerMonth + chicken2EggsPerMonth + chicken3EggsPerMonth + chicken4EggsPerMonth + chicken5EggsPerMonth;
            double dozensOfEggs = sumOfEggs / 12;
            double singleEggs = sumOfEggs % 12;

            dozensOfEggsDisplay.Text = dozensOfEggs.ToString("f1");
            SingleEggsDisplay.Text = singleEggs.ToString("f1");

            dozensOfEggsDisplay.Visible = true;
            SingleEggsDisplay.Visible = true;
        }
    }
}
