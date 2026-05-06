button1_Click //"計費"按鈕
  int dist = Convert.ToInt32(textBox1.Text);
  int fare = 90;

  if (dist > 1500) {
    int ex_dist = dist - 1500;
    fare += ((ex_dist + 500 - 1) / 500) * 8;
  }
  label2.Text = (dist > 0) ? Convert.ToString(fare) : "?";

button2_Click //"清除"按鈕
  //重設
  label2.Text = "0";
  textBox1.Text = "";

*修改 label 的 Autosize = false 能限制label在介面的範圍
