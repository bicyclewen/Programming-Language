/*Chap8 實作題一
宣告一維陣列grade[]，用文字方塊輸入四筆學生成績資料: 95、85、76、56後，計算總分及平均
1. 計算全班總分
2. 計算平均
3. 最高分
4. 最低分
*/
double[] grade = new double[0];
                  
button1_Click //"輸入"按鈕
    try {
        double score = Convert.ToDouble(textBox1.Text);
        if (score>=0 && score<=100) { 
            Array.Resize(ref grade, grade.Length+1); //新朋友 : 陣列長度+1
            grade[grade.Length - 1] = double.Parse(textBox1.Text); //最後一格放最新輸入的成績
            textBox4.Text += (textBox1.Text + "\r\n");
            textBox1.Text = "";
        }
        else {
            MessageBox.Show("請輸入正確範圍之數值");
            textBox1.Text = "";
        }
    }
    catch {
        MessageBox.Show("請輸入正確格式之數值");
        textBox1.Text = "";
    }
    
}

button4_Click //"重置"按鈕
    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
    label2.Text = "全體總分: ";
    label3.Text = "全體平均: ";
    label4.Text = "最高分: ";
    label5.Text = "最低分: ";
}

button2_Click //"搜尋"按鈕
    string findword = textBox2.Text;
    int nowPosition = 0;
    int pos = textBox4.Text.IndexOf(findword, nowPosition);

    if (pos != -1){
        textBox4.Focus();
        textBox4.SelectionStart = pos;
        textBox4.SelectionLength = findword.Length;
        nowPosition = pos + 1;
    }
    else{
        MessageBox.Show("無其他結果");
        nowPosition = 0;
        return;
    }
}

button3_Click //"取代"按鈕
    textBox4.Text = textBox4.Text.Replace(textBox2.Text, textBox3.Text);
}

button5_Click //"計算"按鈕
    Calculate();
}

private void Calculate() { //處理成績計算的地方
    double sum = 0;
    double max = grade[0], min = grade[0];

    for (int i=0; i<grade.Length; i++) {
        sum += grade[i];

        if (grade[i]>max) { //最高分~~
            max = grade[i];
        }
        if (grade[i]<min) { //最低分~~
            min = grade[i];
        }

        double average = sum / grade.Length;
        label2.Text = "全體總分: " + sum;
        label3.Text = "全體平均: " + average.ToString("F2");
        label4.Text = "最高分: " + max;
        label5.Text = "最低分: " + min;
    }
}
