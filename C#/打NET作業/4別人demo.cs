//用label顯示計數 //共用

//全域變數
double money = 0;
int num = 0;

### button1_Click 累加按鈕 ###
num += 1;
double x = Convert.ToDouble(textBox1.Text);
textBox1.Text = "";
money += x;
label4.Text = (num+1).ToString();
label5.Text = (num).ToString();
label8.Text = money.ToString();

### button2_Click 歸零按鈕 ###
//區域變數
money = 0;
num = 1;
label4.Text = (num).ToString();
label5.Text = (num-1).ToString();
label8.Text = money.ToString();
