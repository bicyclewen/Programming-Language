// Form 1 //////////////////////////////////
int count = 0;

button1_Click //"確認"按鈕
  if (textBox1.Text == "123"){
    count = 0;
    Form2 f2 = new Form2();
    f2.Show();
    textBox1.Text = "";
  }else{
    count++;
    if (count == 3){
        MessageBox.Show("連續三次錯誤", "偵測錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        this.Close();
    }
    textBox1.Text = "";
    pictureBox2.Visible = true; //跳出叉叉符號
    }

button2_Click //"離開"按鈕
  DialogResult i = MessageBox.Show("是否要離開", "成績計算系統", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
  if (i == DialogResult.OK) {
      this.Close();
  } 

// Form 2 //////////////////////////////////
button1_Click //"計算"按鈕
  double general = Convert.ToDouble(textBox1.Text);
  double mid = Convert.ToDouble(textBox2.Text);
  double final = Convert.ToDouble(textBox3.Text);

  double overall = general * 0.3 + mid * 0.3 + final * 0.4;
  label5.Text = Math.Round(overall, 2).ToString();
  label5.ForeColor = (overall >= 60) ? Color.Green : Color.Red;

button2_Click //"回上一頁"按鈕
  this.Close();
  
