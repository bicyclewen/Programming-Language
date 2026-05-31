/*建立一簡易文件處理器，其內容含以下:
  1. 取得字串(文件)長度
  2. 取出前?字元
  3. 取出第?個字元處的?個字元
  4. 搜尋
  5. 取代
*/
private void Update(object sender, EventArgs e){ //自動更新底下的字數
    try{
        string text = textBox1.Text;
        //功能一 : 總字數
        int total = textBox1.Text.Length;
        label1.Text = ($"總字數 : {total}");

        //功能二 : 取前n個字
        if (textBox2.Text != ""){
            int n = Convert.ToInt32(textBox2.Text);
            string result2 = text.Substring(0, n);
            label3.Text = ($"個字是 : {result2}");
        }

        //功能三 : 取n1到n2的字
        if (textBox3.Text != "" && textBox4.Text != ""){
            int n1 = Convert.ToInt32(textBox3.Text);
            int n2 = Convert.ToInt32(textBox4.Text);
            if (n1>=0 && n2>=0 && n1<=total) {
                int min = Math.Min(n2,total-n1);
                string result3 = text.Substring(n1, min);
                label6.Text = ($"個字是 : {result3}");
            }
            else {
                label6.Text = ($"個字是 : 超出範圍~~~");
            }
        }
    }
    catch {
        MessageBox.Show("請輸入正確格式之數值");
    }
}

private void button1_Click(object sender, EventArgs e){ //"搜尋"按鈕
    //功能四 : 搜尋
    int findword = textBox1.Text.IndexOf(textBox5.Text);
    if (findword != -1){
        textBox1.SelectionStart = findword;
        textBox1.SelectionLength = textBox5.Text.Length;
        textBox1.Focus();
    }
}

private void button2_Click(object sender, EventArgs e){ //"取代"按鈕
    //功能五 : 取代
    textBox1.Text = textBox1.Text.Replace(textBox5.Text, textBox6.Text);
}
