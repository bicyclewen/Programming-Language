button1_Click //計算按鈕
    double general = Convert.ToDouble(textBox1.Text);
    double mid = Convert.ToDouble(textBox2.Text);
    double final = Convert.ToDouble(textBox3.Text);

    double overall = general * 0.3 + mid * 0.3 + final * 0.4;
    string txt = "   您的總成績 = ";
    txt += Convert.ToString(overall);
    MessageBox.Show(txt, "成績計算系統", MessageBoxButtons.OK, MessageBoxIcon.Information);

textBox1_TextChanged
    textBox1.MaxLength = 3;

textBox2_TextChanged
        {
            textBox2.MaxLength = 3;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.MaxLength = 3;
        }
    }
}
