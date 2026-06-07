import java.io.*;
public class Main{
	public static void main(String[] args) throws IOException{
		BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
		int v = Integer.parseInt(br.readLine());
		int d = Integer.parseInt(br.readLine());
		int n = Integer.parseInt(br.readLine());
		
		if(v<=0||d<=0||n<=0){
			System.out.print("Invalid value");
		}else{
			int intP = v/d;
			System.out.print(intP+".");
			int decP=0, temp = v%d;
			
			for(int i=1; i<=n; i++){
				temp *= 10;
				decP = temp/d;
				System.out.print(decP);
				temp %= d;
			}
		}
	}
}
