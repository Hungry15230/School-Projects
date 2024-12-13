namespace InchesToCentimetersGUI
{
    public partial class InchesToCentimeters : Form
    {
        public InchesToCentimeters()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double inches;
            double centimeters;

            inches = Convert.ToDouble(inchesInput.Text);
            centimeters = inches * 2.54;

            centimetersOutput.Text = centimeters.ToString("f");
        }
    }
}
