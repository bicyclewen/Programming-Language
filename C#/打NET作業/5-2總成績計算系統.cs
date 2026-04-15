namespace 打NET作業6 //使用MessageBox
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
            string txt = "   您的總成績 = ";
            txt += Convert.ToString(overall);
            MessageBox.Show(txt, "成績計算系統", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
