/*建立C#應用程式: 一根繩子長 ? 公尺(user輸入)
每次對折，計算需折幾次，方能小於 ? 公分(user輸入)*/
button1_Click //"計算"按鈕
    double current = Convert.ToDouble(textBox1.Text)*100;
    double target = Convert.ToDouble(textBox2.Text);
    int time = 0;
    while (current >= target) {
        current /= 2;
        time++;
    }
    label3.Text = "要對折 " + time + " 次喔";
