button1_Click //計算按鈕
    double general = Convert.ToDouble(textBox1.Text);
    double mid = Convert.ToDouble(textBox2.Text);
    double final = Convert.ToDouble(textBox3.Text);

    double overall = general * 0.3 + mid * 0.3 + final * 0.4;
    label5.Text = Math.Round(overall, 2).ToString();
    label5.BackColor = Color.White;

textBox1_TextChanged
    textBox1.MaxLength = 3; //輸入分數不超過三位數

textBox2_TextChanged
    textBox2.MaxLength = 3;

textBox3_TextChanged
    textBox3.MaxLength = 3;
