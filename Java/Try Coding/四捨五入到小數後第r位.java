/*數學運算:請由鏈盤讀取三個正整數值,對其進行次方及除法運算後,顯示四捨五入至指定小數位數的結果。
此間題的輸入為三個正整數(d、n、r),每行一筆資料,第1、2、3行分別為d、n以及r的值;
輸出為d/3”的運算結果,四捨五入至小數點後第r位。
輸入範例:
123
2
4
輸出範例:
13.6667
*/
import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		double d = Double.parseDouble(br.readLine());
		double n = Double.parseDouble(br.readLine());
		double r = Double.parseDouble(br.readLine());
		
		double rr = Math.pow(10,r);
		double re = d/Math.pow(3,n);
		double rre = Math.round(re*rr)/rr;
		System.out.print(rre);
	}
}
