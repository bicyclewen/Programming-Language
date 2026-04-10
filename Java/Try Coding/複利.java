/*問題:
  某銀行的定期存款年利率為2%,複利計算,最長存款年限為5年。
  小明存入本金50000元,存款期間為3年,請計算這3年內,各年的利息所得與本利和。
  此問題沒有輸入;輸出為3年存款期間內,各年的利息所得與本利和,每行一筆資料,
  第1至3行分別為第1至3年當年的利息與本利和,格式為:年度:利息,本利和,如輸出範例,數值四捨五入至整數位
  輸出範例:
  1: 1000, 51000
  2: 1020, 52020
  3: 1040,53060 */

public class Main{
	public static void main(String[] args){
		double P = 50000;
		double r = 0.02;
		
		for(int i=1; i<=3; i++){
			double interest = P*r;
			P = P + interest;
			System.out.printf("%d: %.0f, %.0f", i, interest, P);
			
			if(i<3){
				System.out.print("\n");
			}
		
    }
	}
}
