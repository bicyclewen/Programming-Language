/* 使用遞迴函數計算 X^n 的值，X、n由user輸入 */
private double calculate(double x, int n) {
    if (n < 0) { //次方為負
        if (x==0) {
            return -1;
        }
        return 1.0 / calculate(x, -n);
    }
    if (x == 1|| n == 0) {return 1;} //底數為1或次方為0
    if (x == 0) {return 0;} //底數為0

    return x * calculate(x, n - 1); //呼叫自己~
}
private void button1_Click(object sender, EventArgs e){ //"計算"按鈕
    try {
        double x = Convert.ToDouble(textBox1.Text);
        int n = Convert.ToInt32(textBox2.Text);
        double result = calculate(x,n);

        if (result==-1) {
            MessageBox.Show("請輸入正確格式");
            label1.Text = "";
            textBox1.Text = textBox2.Text = "";
            return;
        }
        label1.Text = x + " ^ " + n + " = " + result;
    }
    catch {
        MessageBox.Show("請輸入正確格式");
    }
}
