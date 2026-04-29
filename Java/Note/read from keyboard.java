import java.io.*; //星號表"全部" //放public前面
public class ReadString{
  public static void main(throws IO Exception String[] argv){
    BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    // new 保留資料流空間 //緩衝字流轉換
    String str = br.readLine();
  }
}

//Convert strings to numeric types:
//String s = "123"; String t = "12.34";
byte b = Byte.parseByte(s);
short c = Short.parseShort(s);
int d = Integer.parseInt(s);
long e = Long.parseLong(s);
Float f = Float.parseFloat(t);
