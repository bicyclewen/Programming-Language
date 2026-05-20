/* 建立換零錢機之APP，零錢種類: 500元、100元、50元、10元、5元、1元
   從幣值高的開始換 */
private void Update(object sender, EventArgs e){ //計算剩餘金額
   try{
      TextBox[] box = { textBox2, textBox3, textBox4, textBox5, textBox6 };
      int[] money = { 500, 100, 50, 10, 5 };
      int ctotal = 0;
      int total = textBox1.Text == "" ? 0 : Convert.ToInt32(textBox1.Text);

      for (int i=0; i<box.Length; i++) {
            int c = box[i].Text == "" ? 0 : Convert.ToInt32(box[i].Text);
            ctotal += c * money[i];
      }

      if (total<ctotal) {
            foreach (TextBox index in box){
               index.Text = "";
            }
            label11.Text = "";
            MessageBox.Show("已超過可兌換之金額", "魔力耗盡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
      }
      label11.Text = "" + (total - ctotal); //原本這條寫在 if(total<ctotal) 前面，導致觸發Update事件，所以才會跳兩次MessageBox~
   }
   catch{
      MessageBox.Show("請輸入正確數值", "霹靂卡霹靂拉拉", MessageBoxButtons.OK, MessageBoxIcon.Warning);
   }
}

private void button1_Click(object sender, EventArgs e){ //"兌換"按鈕
   TextBox[] box = {textBox2, textBox3, textBox4, textBox5,textBox6};
   int[] money = { 500, 100, 50, 10, 5 };
   int total = textBox1.Text == "" ? 0 : Convert.ToInt32(textBox1.Text);
   if (total <= 0) {
      MessageBox.Show("請先輸入欲兌換之總金額","霹靂卡霹靂拉拉",MessageBoxButtons.OK,MessageBoxIcon.Information);
   }
   string list = ""; //紀錄各幣值兌換數量的清單
   for (int i=0; i<box.Length; i++) {
      int add = box[i].Text == "" ? 0 : Convert.ToInt32(box[i].Text);
      list += (money[i]+" * "+add+"\r\n");
   }
   int c1 = label11.Text == "" ? 0 : Convert.ToInt32(label11.Text);
   list += ("1 * "+c1);

   DialogResult tell = MessageBox.Show(
                        "已兌換(∩^o^)⊃━☆ﾟ.*･｡ \r\n" +
                        "----------------------\r\n"+
                        list + "\r\n"+
                        "----------------------\r\n" +
                        "總金額: "+total + "\r\n" +
                        "是否列印魔法明細?","",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information
                     );
   if (tell == DialogResult.Yes) {
      string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
      string receipt = "==========魔法明細==========\r\n" +
                       "交易時間: " + time + "\r\n" +
                       "總金額 : " + total + "\r\n" +
                       "---------------兌換數量--------------\r\n" +
                       list +
                       "\r\n==========================\r\n"+
                       "(\\ (\\\r\n(｡• ω•｡)つ—☆ • * ｡\r\n⊂.....ノ • ゜+.\r\nし— J...........°｡ +*ˊ˙˙)\r\n..................... ·ˊ,·*ˊ\"),·*ˊ\")\r\n.............................(,·ˊ(,·'* ☆";
       DialogResult tell2 = MessageBox.Show(receipt, "噗鈴");
       if (tell2==DialogResult.OK) { 
           foreach (TextBox index in box){
           index.Text = "";
      }
       textBox1.Text = "";
 }
   }
   else if (tell == DialogResult.No){
      foreach (TextBox index in box){
            index.Text = "";
      }
      textBox1.Text = "";
   }
}

private void button3_Click(object sender, EventArgs e){ //"清除"按鈕
   TextBox[] box = {textBox2, textBox3, textBox4, textBox5, textBox6, textBox8 ,textBox1};
   foreach (TextBox index in box){
      index.Text = "";
   }
}

private void button2_Click(object sender, EventArgs e){ //"自動"按鈕 //指定兌換特定金額，剩餘金額由高到低自動兌換
   int total = Convert.ToInt32(textBox1.Text);
   int[] money = {500, 100, 50, 10, 5 };
   TextBox[] box = {textBox2,textBox3,textBox4,textBox5,textBox6 };

   //原本用bool做判斷，但太落落長，改用迴圈+陣列
   //紀錄user已輸入之金額
   int ctotal = 0;
   for (int i=0; i<money.Length; i++) {
      if (box[i].Text != "") {
         ctotal += Convert.ToInt32(box[i].Text) * money[i];
      }
   }
        
   int auto = total - ctotal; //要自動兌換的金額
   if (auto<0) {
      MessageBox.Show("已超過可兌換之金額", "魔力耗盡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      auto = 0;
   }
   // 僅兌換使用者沒填的幣值 (自動補齊空格)
   for (int i=0; i<money.Length; i++) {
      if (box[i].Text=="") {
         int add = auto / money[i];
         auto %= money[i];

         box[i].Text = "" + add;
      }
   }
      label11.Text = "" + auto; // 一元的格子
}
