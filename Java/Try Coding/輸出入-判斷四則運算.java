import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		double a = Double.parseDouble(br.readLine());
		double b = Double.parseDouble(br.readLine());
		double result;
		String c = br.readLine(), g="";
		
		if(a==b){
			g = "=";
		}else if(a<b){
			g = "<";
		}else if(a>b){
			g = ">";
		}
		
		switch(c){
			case"+":
				result = a+b;
				break;
			case"-":
				result = a-b;
				break;
			case"*":
				result = a*b;
				break;
			case"/":
				result = a/b;
				break;
			default:
				System.out.println(""+a+g+b);
				System.out.print("Invalid operator");
				return;
		}
		
		System.out.println(""+a+g+b);
		System.out.printf("%.2f", result);
		
	}
}
