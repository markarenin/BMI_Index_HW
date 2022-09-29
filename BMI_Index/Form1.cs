namespace BMI_Index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(numericUpDown1.Value * 703) / Math.Pow(Convert.ToDouble(numericUpDown2.Value), 2);
            String status = "underweight";
            if (result >= 18.5 && result <= 25)
                status = "optimal";
            else if (result > 25)
                status = "overweight";

            label3.Text = $"BMI: {result:F2}";
            label4.Text = $"Status: {status}";
        }
    }
}