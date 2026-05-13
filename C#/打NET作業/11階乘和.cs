/* S!+(S+2)!+...+e! = ?
   S、e皆同為奇數或偶數，且S<=e
   若不符則警告並清空，要求使用者重新輸入 */
button1 //"GO!"按鈕
try {
    int S = Convert.ToInt32(textBox1.Text), E = Convert.ToInt32(textBox2.Text);
    int result2=0;
    if (S<=E && (E-S)%2==0) { // 確定S<=E 且 S、E 皆為偶數或奇數
        textBox3.Text = "";
        for (int i = S; i <= E; i += 2) { //第一層~算整體總和
            int result1 = 1;
            for (int j = S; j <= i; j++) { //第二層~算個別總和
                result1 *= j;
            }
            result2 += result1;
            if (i==S | i==E) {
                textBox3.Text += (i == S) ? (S + "! + ") : (E+"! = "+result2);
            }
            else {
                textBox3.Text += (i+"! + ");
            }
        }
        
    }
    else {
        DialogResult tell = MessageBox.Show("S<=E，且 S、E 需皆為偶數或奇數", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        if (tell == DialogResult.OK) {
        textBox1.Text = textBox2.Text = textBox3.Text = "";
        }
    }
}
catch{
    MessageBox.Show("請輸入整數數值", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
