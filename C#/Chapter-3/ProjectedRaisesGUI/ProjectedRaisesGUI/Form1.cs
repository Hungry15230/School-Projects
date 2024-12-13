namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double NEXT_YEARS_RAISE = 1.04;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double employee1Salary = Convert.ToDouble(employee1SalaryInput.Text);
            double employee2Salary = Convert.ToDouble(employee2SalaryInput.Text);
            double employee3Salary = Convert.ToDouble(employee3SalaryInput.Text);

            string employee1Desc = $"Employee 1 just joined this year, he currently has a salary per hour of {employee1Salary:C}." +
                $"\nHis good work ethic warrants him to recieve the company-wide raise of 4% for a {employee1Salary * NEXT_YEARS_RAISE:C} salary";
            string employee2Desc = $"Employee 2 has been at the company for 5 years now and has a salary of {employee2Salary:C}." +
                $"\nThis employee might be promoted to manager soon but is eligible for the 4% raise and his new salary will be {employee2Salary * NEXT_YEARS_RAISE:C}.";
            string employee3Desc = $"Employee 3 has been here for many years and is an invaluable asset as well as a manager for the company, current salary is {employee3Salary:C}." +
                $"\nOf course, Employee 3 is eligible for the same 4% raise and his new salary will be {employee3Salary * NEXT_YEARS_RAISE:C}.";

            employee1DescLabel.Text = employee1Desc;
            employee2DescLabel.Text = employee2Desc;
            employee3DescLabel.Text = employee3Desc;

            employee1DescLabel.Visible = true;
            employee2DescLabel.Visible = true;
            employee3DescLabel.Visible = true;
        }
    }
}
