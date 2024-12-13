namespace MoveEstimatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateFee_Click(object sender, EventArgs e)
        {
            int PER_MOVE = 200;
            int PER_HOUR = 150;
            int PER_MILE = 2;

            double hoursMoving = Convert.ToDouble(hoursInput.Text);
            double milesMoving = Convert.ToDouble(milesInput.Text);

            double totalCost = PER_MOVE + (PER_HOUR * hoursMoving) + (PER_MILE * milesMoving);

            finalFeeDisplay.Text = totalCost.ToString("C");

            finalFeeDisplay.Visible = true;
        }
        /* 
   int PER_MOVE = 200;
   int PER_HOUR = 150;
   int PER_MILE = 2;

   Console.Write("How many hours will the trip take? ");
   double hoursMoving = Convert.ToDouble(Console.ReadLine());
   Console.Write("How many miles will the trip be? ");
   double milesMoving = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine($"Total moving fee: {PER_MOVE+(PER_HOUR*hoursMoving)+(PER_MILE*milesMoving):C}");
*/

    }
}
