try{
  double ropeLength = double.Parse(txtRopeM.Text)*100;
  double targetLength = double.Parse(txtTargetCm.Text);
  int count = 0;

  while(ropeLength >= targetLength){
    ropeLength = ropeLength/2; //對折
    count++;
  }
  lblResult.Text = $"對折{count}次後，長度變為{ropeLength.ToString("F1")}公分";
}
catch(Exception){
  MessageBox.Show("請輸入正確的數字格式");
}
