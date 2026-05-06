button1_Click //"Hello"按鈕
    label3.Text = label3.Text + " " + textBox1.Text;

button2_Click //"相加"按鈕
    double x = Convert.ToDouble(textBox2.Text);
    double y = Convert.ToDouble(textBox3.Text);
    label6.Text = label6.Text + (x + y); //直接串接即可
/*
label3 歡迎:
label6 sum:
*/
