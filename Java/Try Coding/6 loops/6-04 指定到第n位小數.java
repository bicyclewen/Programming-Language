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
			
			v = (v%d)*10;
			for(int i=1; i<=n; i++){
				System.out.print(v/d);
				v = (v%d)*10;
			}
		}
	}
}
