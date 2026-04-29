import java.io.*; //星號表"全部" //放public前面
public class ReadString{
  public static void main(String[] argv throws IO Exception){
    BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
    // new 保留資料流空間 //緩衝字流轉換
    String str = br.readLine();
  }
}
