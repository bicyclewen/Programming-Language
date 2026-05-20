private int bill(int time) {
    int money = 0;
    if (time <= 60) {
            money += time * 2;
    }else {
            money += 60 * 2 + (time - 60) * 1;
    }
    return money;
}

private void button1_Click(object sender, EventArgs e){ //"結帳"按鈕
    try{
        int time = Convert.ToInt32(textBox1.Text);
        if (time<0) {
            MessageBox.Show("客人，請輸入正確格式之時間","店員說 : ");
        }
        label1.Text = "" + bill(time)+ " 元";
    }
    catch {
        MessageBox.Show("客人，請輸入正確格式之時間", "店員說 : ");
    }
}
