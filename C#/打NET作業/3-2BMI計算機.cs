namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //身高textbox
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //體重textbox
        {
            textBox3.BackColor = Color.White;
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e) //BMI結果
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //計算按鈕
        {
            textBox3.Text = ""; //清除前一筆輸出
            double h = Convert.ToDouble(textBox1.Text);
            double w = Convert.ToDouble(textBox2.Text);
            double BMI = w / (h * h);
            textBox3.Text = BMI.ToString("F2");
            textBox3.BackColor = Color.Gold;

            //移動箭頭 //調整與介面頂端的距離(.Top)
            //派對鸚鵡最高!!!!
            if (BMI < 18.5){
                rock_parrot.Top = 80;
            }if (BMI>=18.5 && BMI<24){
                rock_parrot.Top = 130;
            }if (BMI >= 24 && BMI < 27){
                rock_parrot.Top = 175;
            }if (BMI >= 27 && BMI < 30){
                rock_parrot.Top = 220;
            }if (BMI >= 30 && BMI < 35){
                rock_parrot.Top = 265;
            }if (BMI >= 35){
                rock_parrot.Top = 320;
            }
        }
    }
}
