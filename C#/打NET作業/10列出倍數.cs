/*建立C#應用程式: 由 ? 到 ? (由user輸入)
顯示其中所有 ? (由user輸入)的倍數之數字*/
button1 //"GO!"按鈕
try {
    textBox4.Text = "";
    int lower = Convert.ToInt32(textBox1.Text);
    int upper = Convert.ToInt32(textBox2.Text);
    int number = Convert.ToInt32(textBox3.Text);
    int i = lower;
    
    //尋找首項
    while (i%number!=0) { 
        i++;
    }
    while (i<=upper) {
        textBox4.Text += (i+"\r\n");
        i += number;
    }

}
catch {
    MessageBox.Show("請輸入正確數字~");
}
