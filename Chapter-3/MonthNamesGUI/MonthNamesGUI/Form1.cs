namespace MonthNamesGUI
{
    public partial class Form1 : Form
    {
        enum Month
        {
            JANUARY = 1, FEBRUARY, MARCH , APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            /*
            Console.Write("Month number: ");
            int monthNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"That month is {(Month)monthNum}.");
            */
            int monthNum = Convert.ToInt16(monthNumberInput.Text);
            desiredMonthOutput.Text = Convert.ToString((Month)monthNum);
            desiredMonthOutput.Visible = true;
        }
    }
}
