import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		double one = Double.parseDouble(br.readLine());
		double two = Double.parseDouble(br.readLine());
		double thr = Double.parseDouble(br.readLine());
		double fou = Double.parseDouble(br.readLine());
		double fiv = Double.parseDouble(br.readLine());
		
		if(one%1!=0||two%1!=0||thr%1!=0||fou%1!=0||fiv%1!=0){
			System.out.print("Invalid value");
			return;
		}
		
		int birth = (int)one;
		int month = (int)two;
		double shoe = (int)thr;
		int sock = (int)fou;
		int money = (int)fiv;
		
		if(birth<1||birth>12||month<1|month>12){
			System.out.print("Invalid value");
			return;
		}else if(shoe<0||sock<0||money<0){
			System.out.print("Invalid value");
			return;
		}else{
			shoe *= 4499;
			sock *= 599;
		}
		
		if(month==birth){
			shoe *= 0.9;
		}
		
		if(shoe+sock <= money){
			System.out.print("Yes");
		}else{
			System.out.print("No");
		}
	}
}
