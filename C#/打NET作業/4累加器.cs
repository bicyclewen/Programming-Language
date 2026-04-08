namespace 打NET作業4
{
    public partial class Form1 : Form
    {
        //初始值 //全域變數
        int count = 0, add = 1;
        double total = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "1";
            textBox3.Text = "0";
            textBox4.Text = "0";
            ListBox1.Items.Add("清單"); //想取個標題
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(textBox2.Text);

            //累加金額及項數
            count += 1;
            add += 1;
            total += price;
            textBox4.Text = "" + total;
            textBox1.Text = "" + add;
            textBox3.Text = "" + count;
            textBox2.Text = "";
            ListBox1.Items.Add(count+")  "+price); //列出項目

            //清單自動滾動 (每次的頭頭會換成下一位)
            ListBox1.TopIndex = ListBox1.Items.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            textBox2.Text = "";
            textBox3.Text = "0";
            textBox4.Text = "0";
            ListBox1.Items.Clear();
            ListBox1.Items.Add("清單");

            //清除上一次計數
            count = 0;
            add = 1;
            total = 0;
        }
    }
}
