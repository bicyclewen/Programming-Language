namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //攝氏textbox
        {
            textBox1.BackColor = Color.White;
            label1.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //華氏textbox
        {
            textBox2.BackColor = Color.White;
            label2.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e) //攝氏轉華氏按鈕
        {
            textBox2.Text = ""; //清空前一筆輸出
            double C = Convert.ToDouble(textBox1.Text);
            double F = (9.0 * C) / 5.0 + 32.0;
            textBox2.Text = F.ToString("F2");
            textBox2.BackColor = Color.Gold;
            label2.BackColor = Color.Gold;
        }

        private void button2_Click(object sender, EventArgs e) //華氏轉攝氏按鈕
        {
            textBox1.Text = "";
            double F = Convert.ToDouble(textBox2.Text);
            double C = (5.0 / 9.0) * (F - 32);
            textBox1.Text = C.ToString("F2");
            textBox1.BackColor = Color.Gold;
            label1.BackColor = Color.Gold;
        }
    }
}
