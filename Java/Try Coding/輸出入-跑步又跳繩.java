import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		double run = Double.parseDouble(br.readLine());
		int c = 6000;
		
		if(run%1!=0 || run<0){
			System.out.print("Invalid value");
		}else{
			double runn = run*700;
			if(runn>=c){
				System.out.print(0);
			}else{
				c -= runn;
				int result = (int)Math.ceil(c/115.0);
				System.out.print(result*10);
			}
			
		}
	}
}
