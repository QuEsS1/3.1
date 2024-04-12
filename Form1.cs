namespace лаба_10_з1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = Convert.ToDouble(textBox1.Text);
            double b1 = Convert.ToDouble(textBox2.Text);
            double x1 = Convert.ToDouble(textBox3.Text);
            double rad = (x1 * Math.PI) / 180;
            double res = a1 * b1 * Math.Sin(rad);
            textBox4.Text = res.ToString();
        }
    }
}
