namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text + " " + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            double y = Convert.ToDouble(textBox3.Text);
            label6.Text = label6.Text + (x + y); //直接串接即可
        }
    }
}
