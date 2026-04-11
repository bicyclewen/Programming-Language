/*
王先生是位打工族,一天最多可以排班8小時,時薪是183元,
請計算每個月他最少必須工作多少天加多少小時,方能領到不少於30000元的薪資。
此問題沒有輸入;輸出為能夠領取不少於30000元薪資的每月最少工作天數與
小時數,每行一筆資料,第1行為天數,第2行為小時數,格式如輸出範例
輸出範例:
20
4
*/
public class Main{
	public static void main(String[] args){
		int wage = 183, hr=0;
		int total =0;
		while(total<30000){
			total += wage;
			hr ++;
		}
		System.out.printf("%d%n%d", hr/8, hr%8);
	}
}

/*
#static double ceil(double a):取得大於或等於a的最小整數值,回傳對等之double型別數值。
承上題題目使用 Math.ceil 方法來實作。
*/
public class Main{
	public static void main(String[] args){
		double wage = 183;
		double target = 30000;
		
		int hr = (int)Math.ceil(target/wage);
		System.out.printf("%d\n%d", hr/8, hr%8);
	}
}
