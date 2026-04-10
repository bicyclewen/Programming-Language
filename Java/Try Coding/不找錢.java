public class Main{
	public static void main(String[] args){
		int total = 45*3+21*7;
		int coins = 0;
		
		coins += total/50;
		total %= 50;
		
		coins += total/10;
		total %= 10;
		
		coins += total/5;
		total %= 5;
		
		coins += total;
		System.out.print(coins);
	}
}
