textBox1_TextChanged //身高textbox
    textBox3.BackColor = Color.White;

textBox2_TextChanged //體重textbox
    textBox3.BackColor = Color.White;

button1_Click //計算按鈕
    textBox3.Text = ""; //清除前一筆輸出
    double h = Convert.ToDouble(textBox1.Text);
    double w = Convert.ToDouble(textBox2.Text);
    double BMI = w / (h * h);
    textBox3.Text = BMI.ToString("F2");
    textBox3.BackColor = Color.Gold;

//移動箭頭 //調整與介面頂端的距離(.Top)，此作法需注意每台電腦之解析度
//派對鸚鵡最高!!!!
    if (BMI < 18.5){
        rock_parrot.Top = 80;
    }if (BMI>=18.5 && BMI<24){
        rock_parrot.Top = 130;
    }if (BMI >= 24 && BMI < 27){
        rock_parrot.Top = 175;
    }if (BMI >= 27 && BMI < 30){
        rock_parrot.Top = 220;
    }if (BMI >= 30 && BMI < 35){
        rock_parrot.Top = 265;
    }if (BMI >= 35){
        rock_parrot.Top = 320;
    }
