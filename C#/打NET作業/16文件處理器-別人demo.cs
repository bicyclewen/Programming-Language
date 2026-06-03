/*功能四: 搜尋
這個寫法像一般文件、pdf閱讀器等，一個一個框出搜尋之項目 */

//button4_Click 搜尋按鈕
string keyword = textBox3.Text;
int currentpos = 0;
int pos = textBox4.Text.IndexOf(keyword.currentpos); //字元位址
if(pos != -1){
  textBox6.Focus();
  textBox6.SelectionStart = pos;
  textBox6.SelectionLength = keyword.Length;
  currentpos = pos + 1; //下一個搜尋到的字元
}else{
  MessageBox.Show("搜尋完畢");
  currentpos = 0;
  return;
}
//textBox6是最初輸入的那些字串，textBox3是搜尋框
