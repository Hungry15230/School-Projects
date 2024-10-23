namespace TestsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int grade1 = Convert.ToInt16(test1Input.Text);
            int grade2 = Convert.ToInt16(test2Input.Text);
            int grade3 = Convert.ToInt16(test3Input.Text);
            int grade4 = Convert.ToInt16(test4Input.Text);
            int grade5 = Convert.ToInt16(test5Input.Text);
            int gradeAverage = (grade1 + grade2 + grade3 + grade4 + grade5)/5;
            gradeAverageOutput.Text = Convert.ToString(gradeAverage);
            gradeAverageOutput.Visible = true;
        }
    }
}
