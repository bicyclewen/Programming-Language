int errorBox = 0;
int num = 5;

//計算總和 sum函數
private double sum(){ 
    TextBox[] box = { textBox1, textBox2, textBox3, textBox4, textBox5 };
    double total = 0;

    for (int i = 0; i <= num - 1; i++){
        try{
            double score = Convert.ToDouble(box[i].Text);
            if (score<0 || score>100) {
                errorBox = i + 1;
                return -1;
            }
            else {
                total += score;
            }
        }
        catch{
            errorBox = i + 1;
            return -1;
        }
    }
    return total;
}

//計算平均 average函數
private double average(double sum){ 
    return (sum/ num);
}

//"計算"按鈕
button1_Click 
    double sumResult = sum();
    if (sumResult == -1){
        MessageBox.Show("第" + errorBox + "項的格式錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }else{
        MessageBox.Show(
            "總分 : " + sumResult + "\r\n" +
            "平均 : " + average(sumResult).ToString("F2"),
            "確認成績",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}

//"清除"按鈕
button2_Click(object sender, EventArgs e){ 
    TextBox[] box = { textBox1, textBox2, textBox3, textBox4, textBox5 };
    foreach (TextBox index in box) {
        index.Text = "";
    }
}
