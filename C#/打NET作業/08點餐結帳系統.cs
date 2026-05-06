int total = 0;
button2_Click //"更新"按鈕
    total = 0;
    int m, l, d;
    int medium, large, plus = 15;
    checkedListBox1.Items.Clear();
    //主餐區//////////////////////////////////////////////////////////////
    if (checkBox1.Checked){ //清麵線
        m = (textBox1.Text == "") ? 0 : Convert.ToInt32(textBox1.Text);
        l = (textBox8.Text == "") ? 0 : Convert.ToInt32(textBox8.Text);
        medium = 45;
        large = medium + plus;
        //新增項目至checkedListBox1
        if (m > 0) { checkedListBox1.Items.Add("清麵線(中) " + medium + " x " + m + " = "+(m*medium)) ; }
        if (l > 0) { checkedListBox1.Items.Add("清麵線(大) " + large + " x " + l + " = " + (l * large)); }
        total += (m * medium + l * large);
    }
    if (checkBox2.Checked){ //大腸麵線
        m = (textBox2.Text == "") ? 0 : Convert.ToInt32(textBox2.Text);
        l = (textBox7.Text == "") ? 0 : Convert.ToInt32(textBox7.Text);
        medium = 70;
        large = medium + plus;
        //新增項目至checkedListBox1
        if (m > 0) { checkedListBox1.Items.Add("大腸麵線(中) " + medium + " x " + m + " = " + (m * medium)); }
        if (l > 0) { checkedListBox1.Items.Add("大腸麵線(大) " + large + " x " + l + " = " + (l * large)); }
        total += (m * medium + l * large);
    }
    if (checkBox3.Checked){ //蚵仔麵線
        m = (textBox3.Text == "") ? 0 : Convert.ToInt32(textBox3.Text);
        l = (textBox6.Text == "") ? 0 : Convert.ToInt32(textBox6.Text);
        medium = 90;
        large = medium + plus;
        //新增項目至checkedListBox1
        if (m > 0) { checkedListBox1.Items.Add("蚵仔麵線(中) " + medium + " x " + m + " = " + (m * medium)); }
        if (l > 0) { checkedListBox1.Items.Add("蚵仔麵線(大) " + large + " x " + l + " = " + (l * large)); }
        total += (m * medium + l * large);
    }
    if (checkBox4.Checked){ //綜合麵線
        m = (textBox4.Text == "") ? 0 : Convert.ToInt32(textBox4.Text);
        l = (textBox5.Text == "") ? 0 : Convert.ToInt32(textBox5.Text);
        medium = 95;
        large = medium + plus;
        //新增項目至checkedListBox1
        if (m > 0) { checkedListBox1.Items.Add("綜合麵線(中) " + medium + " x " + m + " = " + (m * medium)); }
        if (l > 0) { checkedListBox1.Items.Add("綜合麵線(大) " + large + " x " + l + " = " + (l * large)); }
        total += (m * medium + l * large);
    }

    //飲料區//////////////////////////////////////////////////////////////
    if (checkBox7.Checked){ //紅茶
        d = (textBox9.Text == "") ? 0 : Convert.ToInt32(textBox9.Text);
        //新增項目至checkedListBox1
        if (d > 0) { checkedListBox1.Items.Add("紅茶 " + 25 + " x " + d + " = " + 25*d) ; }
        total += (25 * d);
    }
    if (checkBox5.Checked){ //桂花釀烏梅汁
        d = (textBox11.Text == "") ? 0 : Convert.ToInt32(textBox11.Text);
        if (d > 0) { checkedListBox1.Items.Add("桂花釀烏梅汁 " + 50 + " x " + d + " = " + 50 * d); }
        total += (50 * d);
    }
    if (checkBox6.Checked){ //鮮奶茶
        d = (textBox10.Text == "") ? 0 : Convert.ToInt32(textBox10.Text);
        if (d > 0) { checkedListBox1.Items.Add("鮮奶茶 " + 50 + " x " + d + " = " + 50 * d); }
        total += (50 * d);
    }
    label15.Text = "總金額: " + total; //按鈕底下顯示的總金額

button1_Click //"結帳"按鈕
    int discount=0;
    int delivery = 0;
    if (radioButton1.Checked) {
        total = Convert.ToInt32(total*0.9);
        discount = (int)(total * 0.1);
    }
    if (radioButton2.Checked) {
        total -= 50;
        discount = 50;
    }
    //外送費
    if (checkBox8.Checked) { 
        delivery = (total >= 300) ? 0 : 300;
        total += delivery;
    }
    //應付金額為正
    if (total<0) {
        total = 0;
    }
    MessageBox.Show("折扣: -"+ discount +"$\n外送: +"+delivery+ "$\n應付金額:" + total+"$", "確認金額", MessageBoxButtons.OK, MessageBoxIcon.Information);


button3_Click //"刪除"按鈕
    //刪除checkedListBox有打勾的項目
    for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--){ //從後面開始刪
        string item = checkedListBox1.CheckedItems[i].ToString();
        int index = item.LastIndexOf("="); //找到"="位置
        //更新總金額
        string money = item.Substring(index + 1);//以"="為準切割，得"="後的金額數
        total -= Convert.ToInt32(money);
        checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[i]);
    }
    label15.Text = "總金額: " + total;
