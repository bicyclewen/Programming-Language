namespace 打NET作業5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double general = Convert.ToDouble(textBox1.Text);
            double mid = Convert.ToDouble(textBox2.Text);
            double final = Convert.ToDouble(textBox3.Text);

            double overall = general * 0.3 + mid * 0.3 + final * 0.4;
            label5.Text = Math.Round(overall, 2).ToString();
            label5.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3; //輸入分數不超過三位數
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 3;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 3;
        }
    }
}
