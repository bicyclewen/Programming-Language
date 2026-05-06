//ReadString ~ 從鍵盤讀取資料，將之轉為數值型別
import java.io.*; //星號表"全部" //放public前面
public class ReadString{
  public static void main(String[] args) throws IOException{
    //建立讀取器 // new 保留資料流空間 //緩衝字流轉換
    BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    //讀取字串
    String str = br.readLine();
    br.close();
    
  }
}

//Convert strings to numeric types:
//String s = "123"; String t = "12.34";
byte b = Byte.parseByte(s);
short c = Short.parseShort(s);
int d = Integer.parseInt(s);
long e = Long.parseLong(s);
Float f = Float.parseFloat(t);
double d = Double.parseDouble(t);
